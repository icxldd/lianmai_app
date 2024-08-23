using System.Threading.Tasks;
using Volo.Abp.Users;

namespace App.Icxl.App;


public class SimpleAppService : AppAppServiceBase, ISimpleAppService
{

    public ICurrentUser currentUser { get; set; }

    public SimpleAppService(ICurrentUser currentUser)
    {
        this.currentUser = currentUser;
    }

    public Task<string> TestApi(string text)
    {

        if (currentUser.Id.HasValue)
        {
            return Task.FromResult(currentUser.Id.ToString());
        }
        else
        {

            return Task.FromResult("123");
        }
    }
}