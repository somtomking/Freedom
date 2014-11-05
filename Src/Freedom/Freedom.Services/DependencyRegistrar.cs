using Autofac;
using Freedom.Infrastructure;
using Freedom.Infrastructure.DependencyManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Freedom.Services
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public void Register(ContainerBuilder builder, ITypeFinder typeFinder)
        {
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly());
        }

        public int Order
        {
            get { return 1; }
        }
    }
}
