using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using DP.Core.Domain.Entity.Common;

namespace DP.Core.Domain.Entity
{
    public class SegmentMapper : KeyEntity
    {
        #region Regular Properties

        public string Name { get; set; }

        #endregion

        #region One Relashionships

        public virtual Criterion Criterion { get; set; }
        public virtual SourceSegment SourceSegment { get; set; }
        public virtual ICollection<DestinationSegment> DestinationSegments { get; set; }

        #endregion

        #region Many RelationShips

        #endregion
    }
}
