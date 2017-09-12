using Autofac;
using Grand.Core.Configuration;
using Grand.Core.Infrastructure;
using Grand.Core.Infrastructure.DependencyManagement;
using NopBrasil.Plugin.Shipping.Correios.Controllers;
using NopBrasil.Plugin.Shipping.Correios.Service;

namespace NopBrasil.Plugin.Shipping.Correios.Infrastructure
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder, GrandConfig grandConfig)
        {
            builder.RegisterType<ShippingCorreiosController>().AsSelf();
            builder.RegisterType<CorreiosService>().As<ICorreiosService>().InstancePerDependency();
        }

        public int Order => 2;
    }
}
