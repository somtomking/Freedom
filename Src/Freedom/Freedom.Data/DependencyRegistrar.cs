using Autofac;
using Freedom.Data.Repository.Customers;
using Freedom.Domain.Customers;
using Freedom.Infrastructure;
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
        public void Register(ContainerBuilder builder,ITypeFinder typeFinder)
        {
            
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
            builder.RegisterType<CustomerRepository>().As<ICustomerRepository>();
        }

        public int Order
        {
            get { return 0; }
        }
    }
}
