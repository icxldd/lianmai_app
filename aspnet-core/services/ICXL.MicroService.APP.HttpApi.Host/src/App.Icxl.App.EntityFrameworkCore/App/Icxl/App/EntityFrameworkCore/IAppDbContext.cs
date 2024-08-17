using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace App.Icxl.App.EntityFrameworkCore;

[ConnectionStringName(AppDbProperties.ConnectionStringName)]
public interface IAppDbContext : IEfCoreDbContext
{
    
    
    
    DbSet<TestHome> TestHome { get; set; }
}
