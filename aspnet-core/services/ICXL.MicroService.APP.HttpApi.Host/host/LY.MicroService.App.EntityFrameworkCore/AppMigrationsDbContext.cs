using App.Icxl.App;
using App.Icxl.App.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace LY.MicroService.App.EntityFrameworkCore;

[ConnectionStringName(AppDbProperties.ConnectionStringName)]
public class AppMigrationsDbContext : AbpDbContext<AppMigrationsDbContext>
{
    public AppMigrationsDbContext(DbContextOptions<AppMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ConfigureApp();
    }
}
