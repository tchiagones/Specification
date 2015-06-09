using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DP.Core.Domain.Entity;
using DP.Core.Domain.Enum;
using DP.Framework.Integration.Specification;

namespace DP.Core.Domain.Factory
{
    public static class SpecificationFactory
    {
        public static ISpecification<List<ValueCompare>> Resolve(Criterion criterion)
        {
            ISpecification<List<ValueCompare>> spec = null;

            foreach (var item in criterion.Specifications.OrderBy(o => o.Order))
            {
                if (spec == null)
                {
                    spec = ResolveSpecification(item);
                    continue;
                }

                switch (item.OperatorLogical)
                {
                    case OperatorLogical.And:
                        spec = spec.And(ResolveSpecification(item));
                        break;
                    case OperatorLogical.Or:
                        spec = spec.Or(ResolveSpecification(item));
                        break;
                }
            }

            return spec;
        }

        private static ISpecification<List<ValueCompare>> ResolveSpecification(DPSpecification specification)
        {
            return ExpressionFactory.Resolve(specification);
        }


    }


}
