using Volo.Abp.Modularity;

namespace App.Icxl.App;

[DependsOn(
    typeof(AppDomainTestModule),
    typeof(AppApplicationModule)
    )]
public class AppApplicationTestModule : AbpModule
{
}
