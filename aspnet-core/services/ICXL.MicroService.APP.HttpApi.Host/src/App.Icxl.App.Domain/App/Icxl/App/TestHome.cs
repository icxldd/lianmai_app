using System;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace App.Icxl.App;

public class TestHome: FullAuditedAggregateRoot<Guid>, IMultiTenant
{
    public string Describe { get; set; }
    public string Address { get; set; }
    
    public Guid? TenantId { get; set; }
}