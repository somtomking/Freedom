using Freedom.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freedom
{
    public static class Ioc
    {
        public static T Resolve<T>() where T : class
        {
            return EngineContext.Current.Resolve<T>();
        }
        public static object Resolve(Type type)
        {
            return EngineContext.Current.Resolve(type);
        }
        public static T[] ResolveAll<T>()
        {
            return EngineContext.Current.ResolveAll<T>();
        }
    }
}
