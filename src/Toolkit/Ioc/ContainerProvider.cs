using Microsoft.Extensions.DependencyInjection;

namespace Sharemee.Toolkit.Ioc;

/// <summary>
/// 
/// </summary>
public class ContainerProvider
{
    /// <summary>
    /// 
    /// </summary>
    public IServiceCollection Service { get; }

    /// <summary>
    /// 
    /// </summary>
    public ContainerProvider()
    {
        Service = new ServiceCollection();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public IServiceProvider Build() => Service.BuildServiceProvider();
}
