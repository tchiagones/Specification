using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using DP.Core.Domain.Entity;

namespace DP.Core.Integration.Repository.Mapping
{
    public class ClientMap : EntityTypeConfiguration<Client>
    {

        public ClientMap()
        {
            this.ToTable("T_SIS_CLIENTE");

            this.HasKey(o => o.UniqueId);
            this.Property(o => o.UniqueId).HasColumnName("clienteId");
            this.Property(o => o.Name).HasColumnName("nome");
            

        }
    }
}
