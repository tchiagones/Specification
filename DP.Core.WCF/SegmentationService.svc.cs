using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DP.Core.WCF
{
    public class SegmentationService : ISegmentationService
    {
        public ICollection<T> TransformEntity<T>(T source, ValueCriterion valueCompare)
        {
            throw new NotImplementedException();
        }

        public Criterion GetCriterion(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Criterion> GetCriteria(int serviceId, int clientId)
        {
            throw new NotImplementedException();
        }

        public TranslateSpecification GetTranslateSpecification(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertUpdateTranslateSpecification(TranslateSpecification translateSpecification)
        {
            throw new NotImplementedException();
        }

        public ICollection<Expression> GetExpressions(int criterionId)
        {
            throw new NotImplementedException();
        }
    }
}
