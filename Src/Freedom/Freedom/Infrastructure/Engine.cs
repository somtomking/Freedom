using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freedom.Infrastructure
{
    public partial class Engine : IEngine
    {

        public T Resolve<T>() where T : class
        {
           
        }

        public object Resolve(Type type)
        {
            
        }

        public T[] ResolveAll<T>()
        {
          
        }
    }
}
