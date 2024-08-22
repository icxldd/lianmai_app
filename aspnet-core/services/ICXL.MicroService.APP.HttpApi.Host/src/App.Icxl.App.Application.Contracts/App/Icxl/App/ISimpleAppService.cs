using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace App.Icxl.App;

public interface ISimpleAppService
{
    public Task<string> TestApi(string text);
}

public class TestHomeDto: FullAuditedEntityDto<Guid>
{
    public string Describe { get; set; }
    public string Address { get; set; }

    public Guid? TenantId { get; set; }
}


public class TestHomeCreateOrEditDto : EntityDto<Guid?>
{
    public string Describe { get; set; }
    public string Address { get; set; }
}