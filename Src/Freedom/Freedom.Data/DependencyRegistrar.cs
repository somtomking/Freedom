using Freedom.Infrastructure.DependencyManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freedom.Data
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public void Register(Autofac.ContainerBuilder builder, Infrastructure.ITypeFinder typeFinder)
        {

        }

        public int Order
        {
            get { return 0; }
        }
    }
}
