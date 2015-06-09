using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DP.Core.Domain.Entity;
using DP.Core.Integration.Repository.Mapping.Common;

namespace DP.Core.Integration.Repository.Mapping
{
    public class DPSpecificationMap : KeyEntityMap<DPSpecification>
    {
        public DPSpecificationMap()            
        {
            //this.Property(p => p.Order).HasColumnName("Order");
            //this.Property(p => p.OperatorLogical).HasColumnName("OperatorLogical");
            //this.Property(p => p.OperatorArithmetic).HasColumnName("OperatorArithmetic");
            //this.Property(p => p.SpecificationType).HasColumnName("SpecificationType");       
        }
    }
}