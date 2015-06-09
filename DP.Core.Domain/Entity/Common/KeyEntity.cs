using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DP.Framework.Integration.Repository;

namespace DP.Core.Domain.Entity.Common
{

    /// <summary>
    /// Referência de entidade chaveada
    /// </summary>
    public abstract class KeyEntity : BaseEntity
    {
        public Guid UniqueId { get; set; }
    }
}
