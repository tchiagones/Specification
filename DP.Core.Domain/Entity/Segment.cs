using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DP.Core.Domain.Entity;
using DP.Core.Domain.Entity.Common;

namespace DP.Core.Domain.Entity
{
    public class Segment : KeyEntity
    {
        public virtual Nullable<int> EntityId { get; set; }

        public virtual Guid GuidEntity { get; set; }

        public virtual EntityType EntityType { get; set; }
    }
}
