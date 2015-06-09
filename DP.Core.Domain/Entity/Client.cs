using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using DP.Core.Domain.Entity.Common;
using DP.Framework.Integration.Repository;

namespace DP.Core.Domain.Entity
{
    public class Client : BaseEntity
    {
        #region Regular Properties

        public int UniqueId { get; set; }
        public string Name { get; set; }

        #endregion

        #region One Relashionships

        #endregion

        #region Many RelationShips

        public virtual ICollection<Service> Services { get; set; }

        #endregion
    }
}
