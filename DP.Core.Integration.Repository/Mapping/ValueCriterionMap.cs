using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DP.Core.Domain.Entity;
using DP.Core.Integration.Repository.Mapping.Common;

namespace DP.Core.Integration.Repository.Mapping
{
    public class ValueCriterionMap : KeyEntityMap<ValueCriterion>
    {
        public ValueCriterionMap()
        {
            //#region Primary Key

            //this.HasKey(k => k.UniqueId);

            //#endregion

            //#region Table & Column Mappings

            //this.ToTable("Field", "Field");
            //this.Property(p => p.UniqueId).HasColumnName("Id");
            //this.Property(p => p.CriterionUniqueId).HasColumnName("CriterionId");
            //this.Property(p => p.FieldUniqueId).HasColumnName("FieldId");
            //this.Property(p => p.BDValue).HasColumnName("Value");

            //#endregion

            //#region Relationships

            //#endregion
        }
    }
}