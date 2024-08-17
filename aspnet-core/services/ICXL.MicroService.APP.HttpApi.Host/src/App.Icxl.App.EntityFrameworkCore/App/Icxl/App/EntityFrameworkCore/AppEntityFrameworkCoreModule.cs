using LINGYUN.Abp.Data.DbMigrator;
using LINGYUN.Abp.DataProtection.EntityFrameworkCore;
using LINGYUN.Abp.Saas.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;
using Volo.Abp.EntityFrameworkCore.MySQL;

namespace App.Icxl.App.EntityFrameworkCore;

[DependsOn(
    typeof(AppDomainModule),
    typeof(AbpDataDbMigratorModule),
    typeof(AbpDataProtectionEntityFrameworkCoreModule),
    typeof(AbpEntityFrameworkCoreMySQLModule),
    typeof(AbpSaasEntityFrameworkCoreModule))]
public class AppEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        // 配置Ef
        Configure<AbpDbContextOptions>(options =>
        {
            options.UseMySQL();
            options.UseMySQL<AppDbContext>();
        });

        context.Services.AddAbpDbContext<AppDbContext>(options =>
        {
            options.AddDefaultRepositories<IAppDbContext>();
        });
    }
}
