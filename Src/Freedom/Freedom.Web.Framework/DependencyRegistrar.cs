using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Freedom.Infrastructure;
using Freedom.Infrastructure.DependencyManagement;
using Freedom.Web.Framework.Themes;
using Freedom.Web.Framework.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freedom.Web.Framework
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public void Register(ContainerBuilder builder, ITypeFinder typeFinder)
        {
            //controllers
            builder.RegisterControllers(typeFinder.GetAssemblies().ToArray());
            //theme
            builder.RegisterType<ThemeProvider>().As<IThemeProvider>().InstancePerLifetimeScope();
            builder.RegisterType<ThemeContext>().As<IThemeContext>().InstancePerLifetimeScope();
            builder.RegisterType<PageHeadBuilder>().As<IPageHeadBuilder>().InstancePerLifetimeScope();
        }

        public int Order
        {
            get { return 2; }
        }
    }
}
