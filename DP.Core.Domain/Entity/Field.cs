using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using DP.Core.Domain.Entity.Common;

namespace DP.Core.Domain.Entity
{
    public class Field : KeyEntity
    {
        #region Regular Properties

        public string Name { get; set; }

        #endregion

        #region One Relashionships


        #endregion

        #region Many RelationShips

        public virtual ICollection<Criterion> Criteria { get; set; }

        #endregion

    }
}
