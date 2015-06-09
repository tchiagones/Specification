using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DP.Core.Domain.Entity.Common;

namespace DP.Core.Domain.Entity
{
    
    public class Base : KeyEntity
    {
        #region Regular Properties 

        public string Name { get; set; }

        #endregion
        
        #region One Relashionships

        public virtual Service Service{ get; set; }

        #endregion

        #region Many RelationShips
        
        public virtual ICollection<Field> Fields{ get; set; }
        
        #endregion

    }
}
