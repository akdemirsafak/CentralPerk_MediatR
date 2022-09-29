using Autofac;
using CentralPerk.API.Repository;
using CentralPerk.API.RepositoryCore;

namespace CentralPerk.API.DependencyResolver;

public class AutoFacResolver : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<ProductRepository>().As<IProductRepository>();
        builder.RegisterType<CustomerRepository>().As<ICustomerRepository>().InstancePerLifetimeScope();
    }
}