using System.Threading.Tasks;

namespace App.Icxl.App;

public interface ISimpleAppService
{
    public Task<string> TestApi(string text);
}