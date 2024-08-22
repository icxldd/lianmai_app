using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace App.Icxl.App;
public class TestHomeAppService : CrudAppService<
    TestHome,
    TestHomeDto,
    Guid,
    PagedResultRequestDto,
    TestHomeCreateOrEditDto>
{
    public TestHomeAppService(IRepository<TestHome, Guid> repository) : base(repository)
    {
    }
}
