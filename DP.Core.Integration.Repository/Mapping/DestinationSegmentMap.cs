using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DP.Core.Domain.Entity;
using DP.Core.Integration.Repository.Mapping.Common;

namespace DP.Core.Integration.Repository.Mapping
{
    public class DestinationSegmentMap : KeyEntityMap<DestinationSegment>
    {
        public DestinationSegmentMap()
        {
            //#region Primary Key

            //this.HasKey(k => k.UniqueId);

            //#endregion

            //#region Table & Column Mappings

            //this.ToTable("DestinationSegment", "DestinationSegment");
            //this.Property(p => p.UniqueId).HasColumnName("Id");
            //this.Property(p => p.Name).HasColumnName("Name");

            //#endregion

            //#region Relationships

            //this.HasMany(m => m.SegmentMappers);

            //#endregion
        }
    }
}