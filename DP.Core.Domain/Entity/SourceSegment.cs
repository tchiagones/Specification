using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DP.Core.Domain.Entity.Common;

namespace DP.Core.Domain.Entity
{
    public class SourceSegment : KeyEntity
    {
        #region Regular Properties

        public string Name { get; set; }



        #endregion

        #region One Relashionships

        public virtual SegmentMapper SegmentMapper { get; set; }

        public virtual Segment Segment { get; set; }

        #endregion

        #region Many RelationShips

        #endregion
    }
}
