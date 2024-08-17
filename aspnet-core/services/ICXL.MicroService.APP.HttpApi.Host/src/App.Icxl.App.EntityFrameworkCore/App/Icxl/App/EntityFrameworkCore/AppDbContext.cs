﻿using LINGYUN.Abp.DataProtection.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;

namespace App.Icxl.App.EntityFrameworkCore;

[ConnectionStringName(AppDbProperties.ConnectionStringName)]
public class AppDbContext : AbpDataProtectionDbContext<AppDbContext>, IAppDbContext
{
    public AppDbContext(
        DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureApp();
    }
}
