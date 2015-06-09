using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using DP.Core.Domain.Entity.Common;
using DP.Framework.Integration.Repository;

namespace DP.Core.Domain.Entity
{
    public class Service : BaseEntity
    {
        public int UniqueId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Client> Clients { get; set; }


    }
}
