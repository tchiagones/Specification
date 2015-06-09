using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DP.Core.Domain.Entity;
using DP.Core.Domain.Enum;
using DP.Framework.Integration.Specification;

namespace DP.Core.Domain.Factory
{
    public static class ExpressionFactory
    {

        public static ISpecification<List<ValueCompare>> Resolve(DPSpecification specification)
        {
            ISpecification<List<ValueCompare>> expSpec = null;

            foreach (var item in specification.Expressions.OrderBy(o => o.Order))
            {
                if (expSpec == null)
                {
                    expSpec = ResolveExpressionSpecification(item);
                    continue;
                }

                switch (item.OperatorLogical)
                {
                    case OperatorLogical.And:
                        expSpec = expSpec.And(ResolveExpressionSpecification(item));
                        break;
                    case OperatorLogical.Or:
                        expSpec = expSpec.Or(ResolveExpressionSpecification(item));
                        break;
                }
            }
            return expSpec;
        }

        private static ISpecification<List<ValueCompare>> ResolveExpressionSpecification(Expression item)
        {
            var comparer = Comparer<object>.Default;
            switch (item.OperatorArithmetic)
            {
                case OperatorArithmetic.Equal:
                    return new ExpressionSpecification<List<ValueCompare>>(v =>
                        comparer.Compare(v.Where(x => x.SpecificationType== item.Specification.SpecificationType)
                        .Single().Value, item.ValueCriterion.Value).Equals(0));

                case OperatorArithmetic.EqualOrGreaterThan:
                    return new ExpressionSpecification<List<ValueCompare>>(v =>
                        comparer.Compare(v.Where(w => w.SpecificationType == item.Specification.SpecificationType)
                        .Single().Value, item.ValueCriterion.Value) >= 0);
                case OperatorArithmetic.EqualOrLessThan:
                    return new ExpressionSpecification<List<ValueCompare>>(v =>
                        comparer.Compare(v.Where(w => w.SpecificationType == item.Specification.SpecificationType)
                        .Single().Value, item.ValueCriterion.Value) <= 0);
                default:
                    throw new ArgumentException(string.Format("Não existe operador implementado para o {0} fornecido.", item.OperatorArithmetic));
            }
        }
    }


}
