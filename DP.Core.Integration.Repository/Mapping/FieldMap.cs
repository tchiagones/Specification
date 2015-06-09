using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DP.Core.Domain.Entity;
using DP.Core.Integration.Repository.Mapping.Common;

namespace DP.Core.Integration.Repository.Mapping
{
    public class FieldMap : KeyEntityMap<Field>
    {
        public FieldMap() 
        {

            //this.Property(o => o.Name).HasColumnName("Name");

            //this.HasRequired(o => o.Base)
            //    .WithMany(o => o.Fields);

        }

    }
}