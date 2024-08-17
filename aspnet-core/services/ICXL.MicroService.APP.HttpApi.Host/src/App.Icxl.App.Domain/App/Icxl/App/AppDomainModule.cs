using LINGYUN.Abp.DataProtection;
using Microsoft.Extensions.DependencyInjection;
using App.Icxl.App.ObjectExtending;
using Volo.Abp.AutoMapper;
using Volo.Abp.Domain.Entities.Events.Distributed;
using Volo.Abp.Modularity;
using Volo.Abp.ObjectExtending.Modularity;
using Volo.Abp.Threading;

namespace App.Icxl.App;

[DependsOn(
    typeof(AbpAutoMapperModule),
    typeof(AbpDataProtectionModule),
    typeof(AppDomainSharedModule))]
public class AppDomainModule : AbpModule
{
    private static readonly OneTimeRunner OneTimeRunner = new();
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<AppDomainModule>();

        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddProfile<AppDomainMapperProfile>(validate: true);
        });

        Configure<AbpDistributedEntityEventOptions>(options =>
        {
        });
    }

    public override void PostConfigureServices(ServiceConfigurationContext context)
    {
        OneTimeRunner.Run(() =>
        {
            // 扩展实体配置
            //ModuleExtensionConfigurationHelper.ApplyEntityConfigurationToEntity(
            //    AppModuleExtensionConsts.ModuleName,
            //    AppModuleExtensionConsts.EntityNames.Entity,
            //    typeof(Entity)
            //);
        });
    }
}
