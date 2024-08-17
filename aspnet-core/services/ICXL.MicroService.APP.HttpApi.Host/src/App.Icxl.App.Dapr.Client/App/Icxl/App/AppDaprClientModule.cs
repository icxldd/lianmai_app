using LINGYUN.Abp.Dapr.Client;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace App.Icxl.App;

[DependsOn(
    typeof(AbpDaprClientModule),
    typeof(AppApplicationContractsModule))]
public class AppDaprClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddStaticDaprClientProxies(
            typeof(AppApplicationContractsModule).Assembly,
            AppRemoteServiceConsts.RemoteServiceName);
    }
}
