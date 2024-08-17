using App.Icxl.App.EntityFrameworkCore;
using LY.MicroService.App.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace App.Icxl.App.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AppMigrationsEntityFrameworkCoreModule)
    )]
public class AppIcxlAppDbMigratorModule : AbpModule
{
}
