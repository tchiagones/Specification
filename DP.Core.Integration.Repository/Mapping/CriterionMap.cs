using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DP.Core.Domain.Entity;
using DP.Core.Integration.Repository.Mapping.Common;

namespace DP.Core.Integration.Repository.Mapping
{
    public class CriterionMap : KeyEntityMap<Criterion>
    {
        public CriterionMap()
        {

            

            //this.Property(p => p.Name).HasColumnName("Name");


            //this.HasRequired(o => o.Service)
            //    .WithMany();

            //this.HasRequired(o => o.Client)
            //    .WithMany();


            //this.HasOptional(o => o.Field)
            //    .WithMany(o => o.Criteria);



            
        }
    }
}