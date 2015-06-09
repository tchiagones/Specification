using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DP.Core.Domain.Entity;
using DP.Core.Integration.Repository.Mapping.Common;

namespace DP.Core.Integration.Repository.Mapping
{
    public class BaseMap : KeyEntityMap<Base>
    {
        public BaseMap()
        {


            //this.Property(p => p.Name)
            //    .HasColumnName("Name");

            //this.HasRequired(o => o.Service)
            //    .WithMany();




        }
    }
}
