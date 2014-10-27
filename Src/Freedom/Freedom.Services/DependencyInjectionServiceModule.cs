using Autofac;
using Freedom.Services.Customers;
using Freedom.Services.Customers.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freedom.Services
{
    public class DependencyInjectionServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ICustomerService>().As<CustomerService>();
             
        }
    }
}
