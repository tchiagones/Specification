using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using DP.Core.Domain.Entity.Common;
namespace DP.Core.Domain.Entity
{

    /// <summary>
    /// Representa o valor de um critério
    /// </summary>
    public class ValueCriterion : KeyEntity
    {
        #region Regular Properties
        //public Guid CriterionUniqueId { get; set; }
        //public Guid FieldUniqueId { get; set; }
        public virtual Criterion Criterion { get; set; }
        public virtual string Value { get; set; }
        #endregion

        #region One Relashionships

        #endregion

        #region Many RelationShips

        public virtual DPSpecification Specification { get; set; }

        #endregion


    }
}
