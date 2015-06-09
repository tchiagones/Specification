using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DP.Core.WCF
{
    [ServiceContract]
    public interface ISegmentationService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="valueCompare"></param>
        /// <returns></returns>
        [OperationContract]
        ICollection<T> TransformEntity<T>(T source, ValueCriterion valueCompare);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract]
        Criterion GetCriterion(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="serviceId"></param>
        /// <param name="clientId"></param>
        /// <returns></returns>
        [OperationContract]
        ICollection<Criterion> GetCriteria(int serviceId, int clientId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract]
        TranslateSpecification GetTranslateSpecification(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="translateSpecification"></param>
        [OperationContract]
        void InsertUpdateTranslateSpecification(TranslateSpecification translateSpecification);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="criterionId"></param>
        /// <returns></returns>
        [OperationContract]
        ICollection<Expression> GetExpressions(int criterionId);
    }

    #region Data Contracts
    [DataContract]
    public class Base
    {
    }

    [DataContract]
    public class Client
    {
    }

    [DataContract]
    public class Communication
    {
    }

    [DataContract]
    public class Criterion
    {
    }

    [DataContract]
    public class DestinationEntity
    {
    }

    [DataContract]
    public class EntityType
    {
    }

    [DataContract]
    public class Expression
    {
    }

    [DataContract]
    public class Field
    {
    }

    [DataContract]
    public class Service
    {
    }

    [DataContract]
    public class SourceEntity
    {
    }

    [DataContract]
    public class TranslateSpecification
    {
    }

    [DataContract]
    public class ValueCriterion
    {
    }
}
    #endregion
