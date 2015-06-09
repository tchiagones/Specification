using System;
using System.Collections.Generic;
using DP.Core.Domain.Entity;
using DP.Framework.Integration.Specification;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using DP.Core.Domain.Enum;
using DP.Core.Domain.Factory;
using DP.Core.Integration.Repository;

namespace DP.Core.UnitTest.Domain
{
    [TestClass]
    public class LoadCoreTest
    {
        #region Load TestMethods

        #region ValueCriterion

        [TestMethod]
        public void AddValueCriterionTest()
        {
            var valueCriterion = new ValueCriterion
            {
                Criterion = new Criterion(),
                Specification = new DPSpecification(),
                Value = new object()
            };

            AddValueCriterion(valueCriterion);
        }

        public void AddValueCriterion(ValueCriterion valueCriterion)
        {
            var context = new CoreContext();
            var entity = context.Set<ValueCriterion>();
            entity.Add(valueCriterion);
            context.SaveChanges();
        }

        #endregion

        #endregion
    }
}