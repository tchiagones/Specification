using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DP.Core.Domain.Entity;
using DP.Core.Domain.Enum;

namespace DP.Core.Domain.Interface.Service
{
    /// <summary>
    /// Serviço de tratamento
    /// </summary>
    public interface ISegmentService<T>
    {

        #region TransformEntity

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="valueCompare"></param>
        /// <returns></returns>
        ICollection<T> TransformEntity(T source,
            DP.Core.Domain.Entity.Service service,
            Client client,
            string fieldName,
            DPSpecificationType specificationType,
            ValueCompare valueCompare);

        #endregion

        #region GetCriterion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Criterion GetCriterion(int id);

        #endregion

        #region GetCriteria

        /// <summary>
        /// 
        /// </summary>
        /// <param name="serviceId"></param>
        /// <param name="clientId"></param>
        /// <returns></returns>
        ICollection<Criterion> GetCriteria(int serviceId, int clientId);

        #endregion

        #region GetTranslateSpecification

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        SegmentMapper GetTranslateSpecification(int id);

        #endregion

        #region InsertUpdateTranslateSpecification

        /// <summary>
        /// 
        /// </summary>
        /// <param name="translateSpecification"></param>
        void InsertUpdateTranslateSpecification(SegmentMapper translateSpecification);

        #endregion

        #region GetExpressions

        /// <summary>
        /// 
        /// </summary>
        /// <param name="criterionId"></param>
        /// <returns></returns>
        ICollection<Expression> GetExpressions(int criterionId);

        #endregion

    }
}
