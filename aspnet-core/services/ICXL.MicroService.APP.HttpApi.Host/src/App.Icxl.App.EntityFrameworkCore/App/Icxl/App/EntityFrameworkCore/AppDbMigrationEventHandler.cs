using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DistributedLocking;
using Volo.Abp.EntityFrameworkCore.Migrations;
using Volo.Abp.EventBus.Distributed;
using Volo.Abp.MultiTenancy;
using Volo.Abp.Uow;

namespace App.Icxl.App.EntityFrameworkCore;

public class AppDbMigrationEventHandler : EfCoreDatabaseMigrationEventHandlerBase<AppDbContext>
{
    protected IDataSeeder DataSeeder { get; }

    public AppDbMigrationEventHandler(
        IDataSeeder dataSeeder,
        ITenantStore tenantStore,
        ICurrentTenant currentTenant, 
        IUnitOfWorkManager unitOfWorkManager, 
        IAbpDistributedLock abpDistributedLock,
        IDistributedEventBus distributedEventBus, 
        ILoggerFactory loggerFactory) 
        : base(
            ConnectionStringNameAttribute.GetConnStringName<AppDbContext>(),
            currentTenant, unitOfWorkManager, tenantStore, abpDistributedLock, distributedEventBus, loggerFactory)
    {
        DataSeeder = dataSeeder;
    }

    protected async override Task SeedAsync(Guid? tenantId)
    {
        await DataSeeder.SeedAsync(tenantId);
    }
}
