using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DP.Core.Domain.Entity;
using DP.Core.Integration.Repository.Mapping.Common;

namespace DP.Core.Integration.Repository.Mapping
{
    public class SourceSegmentMap : KeyEntityMap<SourceSegment>
    {
        public SourceSegmentMap()
        {
            //#region Primary Key

            //this.HasKey(k => k.UniqueId);

            //#endregion

            //#region Table & Column Mappings

            //this.ToTable("SourceSegment", "SourceSegment");
            //this.Property(p => p.UniqueId).HasColumnName("Id");
            //this.Property(p => p.Name).HasColumnName("Name");

            //#endregion

            //#region Relationships

            //#endregion
        }
    }
}