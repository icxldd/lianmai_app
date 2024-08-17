using LINGYUN.Abp.Dynamic.Queryable;
using Volo.Abp.Application;
using Volo.Abp.Authorization;
using Volo.Abp.Features;
using Volo.Abp.Modularity;

namespace App.Icxl.App;

[DependsOn(
    typeof(AbpFeaturesModule),
    typeof(AbpAuthorizationModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpDynamicQueryableApplicationContractsModule),
    typeof(AppDomainSharedModule))]
public class AppApplicationContractsModule : AbpModule
{
}
