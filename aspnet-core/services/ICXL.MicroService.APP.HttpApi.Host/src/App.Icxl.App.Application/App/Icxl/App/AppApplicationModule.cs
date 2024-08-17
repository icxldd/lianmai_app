using LINGYUN.Abp.Dynamic.Queryable;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Application;
using Volo.Abp.Authorization;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace App.Icxl.App;

[DependsOn(
    typeof(AbpAuthorizationModule),
    typeof(AbpDddApplicationModule),
    typeof(AppDomainModule),
    typeof(AppApplicationContractsModule),
    typeof(AbpDynamicQueryableApplicationModule))]
public class AppApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<AppApplicationModule>();

        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddProfile<AppApplicationMapperProfile>(validate: false);
        });
    }
}
