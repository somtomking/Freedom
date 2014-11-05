﻿using Autofac;
using Nop.Core.Infrastructure;

namespace Freedom.Infrastructure.DependencyManagement
{
    public interface IDependencyRegistrar
    {
        void Register(ContainerBuilder builder, ITypeFinder typeFinder);

        int Order { get; }
    }
}