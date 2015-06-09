using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DP.Core.Domain.Entity.Common;
using DP.Core.Domain.Enum;


namespace DP.Core.Domain.Entity
{

    /// <summary>
    /// Representa uma expressão de comparação 
    /// </summary>
    public class Expression : KeyEntity
    {
        #region Regular Properties

        public int Order { get; set; }

        public OperatorLogical OperatorLogical { get; set; }
        public OperatorArithmetic OperatorArithmetic { get; set; }

        #endregion

        #region One Relashionships

        public virtual ValueCriterion ValueCriterion { get; set; }
        public virtual DPSpecification Specification { get; set; }

        #endregion

        #region Many RelationShips


        #endregion



    }
}
