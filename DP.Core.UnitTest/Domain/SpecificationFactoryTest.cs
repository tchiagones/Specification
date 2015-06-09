using System;
using System.Collections.Generic;
using DP.Core.Domain.Entity;
using DP.Framework.Integration.Specification;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using DP.Core.Domain.Enum;
using DP.Core.Domain.Factory;
using DP.Core.Integration.Repository;

namespace DP.Core.UnitTest
{
    [TestClass]
    public class SpecificationFactoryTest
    {
        [TestMethod]
        public void ResolverCriterioLocalidadeTest()
        {
            Criterion criterioLocalidade = new Criterion();
            GetCriterionSpecifications(ref criterioLocalidade);

            var ValidDateTime = DateTime.Now;
            var ErrorDateTime = new DateTime(2021, 8, 30);//data depois
            var ErrorDateTime2 = new DateTime(2014, 5, 30);//data antes

            List<ValueCompare> list = new List<ValueCompare>();
            list.Add(new ValueCompare("SP", DPSpecificationType.Code, "Localidade")); // specificationLocalidade
            list.Add(new ValueCompare(ValidDateTime, DPSpecificationType.Date, "DataVigência")); // specificationVigencia 

            ISpecification<List<ValueCompare>> rule = SpecificationFactory.Resolve(criterioLocalidade);

            //Assert.IsNotNull(rule);

            var isSatisfiedBy = rule.IsSatisfiedBy(list);

            Assert.IsTrue(isSatisfiedBy);

            if (!isSatisfiedBy)
                return;

            //TODO:
            //DO SEGMENTATION HERE
        }

        private void GetCriterionSpecifications(ref Criterion criterioLocalidade)
        {
            DPSpecification specificationVigencia = new DPSpecification();
            specificationVigencia.UniqueId = Guid.NewGuid();
            specificationVigencia.Expressions = new List<Expression>();
            specificationVigencia.OperatorLogical = OperatorLogical.And;
            specificationVigencia.Order = 1;
            specificationVigencia.SpecificationType = DPSpecificationType.Date;

            GetSpecificationVigenciaExpressions(ref specificationVigencia, criterioLocalidade);

            DPSpecification specificationLocalidade = new DPSpecification();
            specificationLocalidade.Expressions = new List<Expression>();
            specificationLocalidade.UniqueId = Guid.NewGuid();
            specificationLocalidade.OperatorLogical = OperatorLogical.And;
            specificationLocalidade.Order = 0;
            specificationLocalidade.SpecificationType = DPSpecificationType.Code;

            GetSpecificationLocalidadeExpressions(ref specificationLocalidade, criterioLocalidade);

            criterioLocalidade.Specifications = new List<DPSpecification>();
            criterioLocalidade.Specifications.Add(specificationLocalidade);
            criterioLocalidade.Specifications.Add(specificationVigencia);
        }

        private void GetSpecificationLocalidadeExpressions(ref DPSpecification specificationLocalidade, Criterion criterioLocalidade)
        {
            Expression expressionSP = new Expression();
            expressionSP.OperatorArithmetic = OperatorArithmetic.Equal;
            expressionSP.ValueCriterion = new ValueCriterion();
            expressionSP.ValueCriterion.Criterion = criterioLocalidade;
            expressionSP.ValueCriterion.Specification = specificationLocalidade;
            expressionSP.Order = 1;
            expressionSP.OperatorLogical = OperatorLogical.Or;
            expressionSP.ValueCriterion.Value = "SP";
            expressionSP.Specification = specificationLocalidade;

            Expression expressionRJ = new Expression();
            expressionRJ.OperatorArithmetic = OperatorArithmetic.Equal;
            expressionRJ.ValueCriterion = new ValueCriterion();
            expressionRJ.ValueCriterion.Criterion = criterioLocalidade;
            expressionRJ.ValueCriterion.Specification = specificationLocalidade;
            expressionRJ.Order = 0;
            expressionRJ.ValueCriterion.Value = "RJ";
            expressionRJ.Specification = specificationLocalidade;

            specificationLocalidade.Expressions.Add(expressionRJ);
            specificationLocalidade.Expressions.Add(expressionSP);
        }

        private void GetSpecificationVigenciaExpressions(ref DPSpecification specificationVigencia, Criterion criterioLocalidade)
        {
            Expression expressionDataFinal = new Expression();
            expressionDataFinal.OperatorArithmetic = OperatorArithmetic.EqualOrLessThan;
            expressionDataFinal.ValueCriterion = new ValueCriterion();
            expressionDataFinal.ValueCriterion.Criterion = criterioLocalidade;
            expressionDataFinal.ValueCriterion.Specification = specificationVigencia;
            expressionDataFinal.Order = 1;
            expressionDataFinal.ValueCriterion.Value = new DateTime(2020, 12, 30);
            expressionDataFinal.Specification = specificationVigencia;
            expressionDataFinal.OperatorLogical = OperatorLogical.And;

            Expression expressionDataInicial = new Expression();
            expressionDataInicial.OperatorArithmetic = OperatorArithmetic.EqualOrGreaterThan;
            expressionDataInicial.ValueCriterion = new ValueCriterion();
            expressionDataInicial.ValueCriterion.Criterion = criterioLocalidade;
            expressionDataInicial.ValueCriterion.Specification = specificationVigencia;
            expressionDataInicial.Order = 0;
            expressionDataInicial.ValueCriterion.Value = new DateTime(2015, 1, 1);
            expressionDataInicial.Specification = specificationVigencia;

            specificationVigencia.Expressions = new List<Expression>();
            specificationVigencia.Expressions.Add(expressionDataInicial);
            specificationVigencia.Expressions.Add(expressionDataFinal);
        }
    }
}
