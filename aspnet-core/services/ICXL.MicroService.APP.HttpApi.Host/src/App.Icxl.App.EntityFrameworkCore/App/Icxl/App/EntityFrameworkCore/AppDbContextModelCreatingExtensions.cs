using Microsoft.EntityFrameworkCore;
using System;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace App.Icxl.App.EntityFrameworkCore;

public static class AppDbContextModelCreatingExtensions
{
    public static void ConfigureApp(
        this ModelBuilder builder,
        Action<AppModelBuilderConfigurationOptions> optionsAction = null)
    {
        Check.NotNull(builder, nameof(builder));

        var options = new AppModelBuilderConfigurationOptions(
            AppDbProperties.DbTablePrefix,
            AppDbProperties.DbSchema
        );
        optionsAction?.Invoke(options);
        
        
        
        builder.Entity<TestHome>(b =>
        {
            b.ToTable(options.TablePrefix + "TestHome", options.Schema);
            b.ConfigureFullAuditedAggregateRoot();
        });
    }
}
