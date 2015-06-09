using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using DP.Core.Domain.Entity;

namespace DP.Core.Integration.Repository.Mapping
{
    public class ServiceMap : EntityTypeConfiguration<Service>
    {
        public ServiceMap()
        {
            this.ToTable("Service", "productionControl");

            this.HasKey(o => o.UniqueId);
            this.Property(o => o.UniqueId).HasColumnName("Id");            

            this.HasMany(o => o.Clients)
                .WithMany(o => o.Services)
                .Map(src =>
                    src.MapLeftKey("ServiceId")
                       .MapRightKey("ClientId")
                       .ToTable("ServiceCommunication", "productionControl"));

        }
    }
}
