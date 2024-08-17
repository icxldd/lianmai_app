using App.Icxl.App.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace App.Icxl.App;

public abstract class AppControllerBase : AbpControllerBase
{
    protected AppControllerBase()
    {
        LocalizationResource = typeof(AppResource);
    }
}
