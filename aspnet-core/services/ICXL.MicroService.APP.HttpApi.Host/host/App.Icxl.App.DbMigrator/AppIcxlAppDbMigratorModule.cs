using App.Icxl.App.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace App.Icxl.App.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AppEntityFrameworkCoreModule)
    )]
public class AppIcxlAppDbMigratorModule : AbpModule
{
}
