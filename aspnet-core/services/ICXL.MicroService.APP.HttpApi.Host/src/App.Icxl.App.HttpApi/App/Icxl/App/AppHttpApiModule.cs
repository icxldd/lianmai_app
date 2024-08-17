using App.Icxl.App.Localization;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.Localization;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.Validation.Localization;
using LINGYUN.Abp.Dynamic.Queryable;

namespace App.Icxl.App;

[DependsOn(
    typeof(AbpAspNetCoreMvcModule),
    typeof(AppApplicationContractsModule),
    typeof(AppApplicationModule),
    typeof(AbpDynamicQueryableHttpApiModule))]
public class AppHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(AppHttpApiModule).Assembly);
        });

        PreConfigure<AbpMvcDataAnnotationsLocalizationOptions>(options =>
        {
            options.AddAssemblyResource(
                typeof(AppResource),
                typeof(AppApplicationContractsModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<AppResource>()
                .AddBaseTypes(typeof(AbpValidationResource));
        });
        
        Configure<AbpAspNetCoreMvcOptions>(options =>
        {
            options.MinifyGeneratedScript = true;
            options
                .ConventionalControllers
                .Create(typeof(AppApplicationModule).Assembly, opts => { opts.RootPath = "app"; });
        });
    }
}
