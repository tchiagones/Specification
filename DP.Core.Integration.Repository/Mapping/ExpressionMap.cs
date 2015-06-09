using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DP.Core.Domain.Entity;
using DP.Core.Integration.Repository.Mapping.Common;

namespace DP.Core.Integration.Repository.Mapping
{
    public class ExpressionMap : KeyEntityMap<Expression>
    {
        public ExpressionMap()
        {
            //#region Primary Key

            //this.HasKey(k => k.UniqueId);

            //#endregion

            //#region Table & Column Mappings

            //this.ToTable("Expression", "Expression");
            //this.Property(p => p.UniqueId).HasColumnName("Id");
            //this.Property(p => p.Order).HasColumnName("Order");
            //this.Property(p => p.OperatorLogical).HasColumnName("OperatorLogical");
            //this.Property(p => p.OperatorArithmetic).HasColumnName("OperatorArithmetic");

            //#endregion

            //#region Relationships

            //#endregion
        }
    }
}