using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DP.Core.Domain.Entity.Common;

namespace DP.Core.Domain.Entity
{
    public class DestinationSegment : KeyEntity
    {
        #region Regular Properties


        public string Name { get; set; }

        #endregion

        #region One Relashionships

        #endregion

        #region Many RelationShips

        //public virtual ICollection<SegmentMapper> SegmentMappers { get; set; }

        public virtual ICollection<Segment> Segments { get; set; }


        #endregion
    }
}
