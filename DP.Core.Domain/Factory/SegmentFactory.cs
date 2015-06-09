using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using DP.Core.Domain.Entity;

namespace DP.Core.Domain.Factory
{
    public static class SegmentFactory<T>
    {
        public static List<T> Resolve(List<Segment> segments)
        {
            List<T> results = new List<T>();

            foreach (var item in segments)
            {
                try
                {
                    Assembly assembly = Assembly.Load(item.EntityType.AssemblyName);
                    Type t = assembly.GetType(item.EntityType.AssemblyName);

                    if (t != typeof(CommunicationType)) throw new ArgumentException("O tipo de segmento fornecido precisa ser CommunicationType.\n");

                    T instance = (T)Activator.CreateInstance(t);
                    results.Add(instance);
                }
                catch (Exception e)
                {
                    throw new ArgumentException(string.Format("O tipo de segmento fornecido precisa ser CommunicationType.\n{0}", e.ToString()));
                }
            }
            return results;
        }

        public static List<Segment> Resolve(List<T> segments)
        {
            List<Segment> results = new List<Segment>();

            foreach (var item in segments)
            {
                try
                {
                    if (typeof(T) != typeof(CommunicationType)) throw new ArgumentException("O tipo de segmento fornecido precisa ser CommunicationType.\n");

                    var segment = new Segment { EntityType = new EntityType { AssemblyName = item.GetType().ToString() } };
                    results.Add(segment);
                }
                catch (Exception e)
                {
                    throw new ArgumentException(string.Format("O tipo de segmento fornecido precisa ser CommunicationType.\n{0}", e.ToString()));
                }
            }
            return results;
        }
    }
}
