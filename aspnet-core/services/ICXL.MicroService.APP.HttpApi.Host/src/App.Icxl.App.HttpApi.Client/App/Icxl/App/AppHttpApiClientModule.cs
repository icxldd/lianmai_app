using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace App.Icxl.App;

[DependsOn(
    typeof(AbpHttpClientModule),
    typeof(AppApplicationContractsModule))]
public class AppHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddStaticHttpClientProxies(
            typeof(AppApplicationContractsModule).Assembly,
            AppRemoteServiceConsts.RemoteServiceName);
    }
}
