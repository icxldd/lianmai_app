using Volo.Abp.Modularity;

namespace App.Icxl.App;

[DependsOn(
    typeof(AppTestBaseModule),
    typeof(AppDomainModule)
    )]
public class AppDomainTestModule : AbpModule
{
}
