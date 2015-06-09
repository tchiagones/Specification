using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DP.Core.Domain.Entity.Common;

namespace DP.Core.Domain.Entity
{
    /// <summary>
    /// Representa um critério de validação utilizado por uma expressão de especificação
    /// </summary>
    public class Criterion : KeyEntity
    {

        #region Regular Properties

        public string Name { get; set; }
        #endregion

        #region One Relashionships

        public virtual Service Service { get; set; }
        public virtual Client Client { get; set; }

        #endregion

        #region Many RelationShips


        public virtual Field Field { get; set; }
        public virtual ICollection<ValueCriterion> AvailableValues { get; set; }
        public virtual ICollection<DPSpecification> Specifications { get; set; }
        //public virtual ICollection<SegmentMapper> SegmentMappers { get; set; }

        #endregion
    }
}
