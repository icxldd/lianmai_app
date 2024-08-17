using App.Icxl.App.Localization;
using Volo.Abp.Application.Services;

namespace App.Icxl.App;

public abstract class AppAppServiceBase : ApplicationService
{
    protected AppAppServiceBase()
    {
        LocalizationResource = typeof(AppResource);
        ObjectMapperContext = typeof(AppApplicationModule);
    }
}
