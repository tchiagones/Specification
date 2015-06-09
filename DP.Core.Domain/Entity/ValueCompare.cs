using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using DP.Core.Domain.Entity.Common;
using DP.Core.Domain.Enum;
namespace DP.Core.Domain.Entity
{

    /// <summary>
    /// Representa o valor de um critério
    /// </summary>
    [NotMapped]
    public class ValueCompare
    {

        public ValueCompare(object value, DPSpecificationType specificationType, String fieldName)
        {
            FieldName = fieldName;
            SpecificationType = specificationType;
            Value = value;
        }


        #region Regular Properties

        public String FieldName { get; private set; }
        public virtual DPSpecificationType SpecificationType { get; private set; }
        public object Value { get; private set; }

        #endregion

        #region One Relashionships

        #endregion

    }
}
