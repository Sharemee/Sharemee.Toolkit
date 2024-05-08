using Microsoft.Extensions.DependencyInjection;

namespace Sharemee.Toolkit.Ioc;

public class ContainerProvider
{
    public IServiceCollection Service { get; }

    public ContainerProvider()
    {
        Service = new ServiceCollection();
    }

    public IServiceProvider Build() => Service.BuildServiceProvider();
}
