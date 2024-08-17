using LINGYUN.Abp.SettingManagement;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;
using Volo.Abp.SettingManagement;

namespace App.Icxl.App.SettingManagement;

[DependsOn(
    typeof(AbpSettingManagementApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule),
    typeof(AbpSettingManagementDomainModule))]
public class AppSettingManagementModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(AppSettingManagementModule).Assembly);
        });
    }
}
