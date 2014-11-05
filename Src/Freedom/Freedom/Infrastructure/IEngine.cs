using Freedom.Configuration;
using Freedom.Infrastructure.DependencyManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freedom.Infrastructure
{
    public partial interface IEngine
    {
        void Initialize(AppConfig config);
        T Resolve<T>() where T : class;
        object Resolve(Type type);
        T[] ResolveAll<T>();
        ContainerManager ContainerManager { get; }
    }
}
