using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DP.Core.Domain.Entity;
using DP.Core.Integration.Repository.Mapping.Common;

namespace DP.Core.Integration.Repository.Mapping
{
    public class SegmentMapperMap : KeyEntityMap<SegmentMapper>
    {
        public SegmentMapperMap()
        {
            //#region Primary Key

            //this.HasKey(k => k.UniqueId);

            //#endregion

            //#region Table & Column Mappings

            //this.ToTable("SegmentMapper", "SegmentMapper");
            //this.Property(p => p.UniqueId).HasColumnName("Id");
            //this.Property(p => p.Name).HasColumnName("Name");

            //#endregion

            //#region Relationships
            //this.HasRequired(r => r.SourceSegment);
            //this.HasMany(m => m.DestinationSegments);

            //#endregion
        }
    }
}