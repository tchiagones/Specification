using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DP.Core.Domain.Entity;
using DP.Core.Domain.Enum;
using DP.Core.Domain.Interface.Service;

namespace DP.Core.Service
{
    public class SegmentService<T> : ISegmentService<T>
    {

        public ICollection<T> TransformEntity(T source, Domain.Entity.Service service, Client client, string fieldName, DPSpecificationType specificationType, ValueCompare valueCompare)
        {
            throw new NotImplementedException();
        }

        Criterion ISegmentService<T>.GetCriterion(int id)
        {
            throw new NotImplementedException();
        }

        ICollection<Criterion> ISegmentService<T>.GetCriteria(int serviceId, int clientId)
        {
            throw new NotImplementedException();
        }

        SegmentMapper ISegmentService<T>.GetTranslateSpecification(int id)
        {
            throw new NotImplementedException();
        }

        void ISegmentService<T>.InsertUpdateTranslateSpecification(SegmentMapper translateSpecification)
        {
            throw new NotImplementedException();
        }

        ICollection<Expression> ISegmentService<T>.GetExpressions(int criterionId)
        {
            throw new NotImplementedException();
        }


    }
}
