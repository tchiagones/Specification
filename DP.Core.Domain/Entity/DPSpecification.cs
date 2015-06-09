using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DP.Core.Domain.Entity.Common;
using DP.Core.Domain.Enum;
using DP.Framework.Integration.Specification;

namespace DP.Core.Domain.Entity
{
    public class DPSpecification : KeyEntity
    {
        #region Regular Properties
        public virtual int Order { get; set; }

        public OperatorLogical OperatorLogical { get; set; }
        public OperatorArithmetic OperatorArithmetic { get; set; }
        public DPSpecificationType SpecificationType { get; set; }

        #endregion

        #region One Relashionships

        public virtual Criterion Criterion { get; set; }

        #endregion

        #region Many RelationShips

        public virtual ICollection<Expression> Expressions { get; set; }

        #endregion

    }
}
