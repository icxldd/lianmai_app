using System.Threading.Tasks;

namespace App.Icxl.App;


public class SimpleAppService:AppAppServiceBase, ISimpleAppService
{
    public Task<string> TestApi(string text)
    {
        return Task.FromResult("123");
    }
}