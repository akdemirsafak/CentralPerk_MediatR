using System.Reflection;
using Autofac;
using CentralPerk.API.Repository;
using CentralPerk.API.RepositoryCore;
using Module = Autofac.Module;

namespace CentralPerk.API.DependencyResolver;

public class AutoFacResolver:Module
{
    protected override void Load(ContainerBuilder builder)
    {
        
    }
}