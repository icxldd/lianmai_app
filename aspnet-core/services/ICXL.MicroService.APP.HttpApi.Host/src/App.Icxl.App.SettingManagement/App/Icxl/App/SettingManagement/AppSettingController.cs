using Asp.Versioning;
using LINGYUN.Abp.SettingManagement;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using App.Icxl.App.Permissions;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;

namespace App.Icxl.App.SettingManagement;

[RemoteService(Name = AppRemoteServiceConsts.RemoteServiceName)]
[ApiVersion("2.0")]
[Area(AppRemoteServiceConsts.ModuleName)]
[Route("api/App/settings")]
public class AppSettingController : AbpController, IAppSettingAppService
{
    private readonly IAppSettingAppService _settingAppService;
    public AppSettingController(IAppSettingAppService settingAppService)
    {
        _settingAppService = settingAppService;
    }

    [Authorize(AppPermissions.ManageSettings)]
    [HttpPut]
    [Route("by-current-tenant")]
    public virtual async Task SetCurrentTenantAsync(UpdateSettingsDto input)
    {
        await _settingAppService.SetCurrentTenantAsync(input);
    }

    [HttpGet]
    [Route("by-current-tenant")]
    public virtual async Task<SettingGroupResult> GetAllForCurrentTenantAsync()
    {
        return await _settingAppService.GetAllForCurrentTenantAsync();
    }

    [Authorize]
    [HttpPut]
    [Route("by-current-user")]
    public virtual async Task SetCurrentUserAsync(UpdateSettingsDto input)
    {
        await _settingAppService.SetCurrentTenantAsync(input);
    }

    [Authorize]
    [HttpGet]
    [Route("by-current-user")]
    public virtual async Task<SettingGroupResult> GetAllForCurrentUserAsync()
    {
        return await _settingAppService.GetAllForCurrentTenantAsync();
    }

    [Authorize(AppPermissions.ManageSettings)]
    [HttpPut]
    [Route("by-global")]
    public virtual async Task SetGlobalAsync(UpdateSettingsDto input)
    {
        await _settingAppService.SetGlobalAsync(input);
    }

    [HttpGet]
    [Route("by-global")]
    public virtual async Task<SettingGroupResult> GetAllForGlobalAsync()
    {
        return await _settingAppService.GetAllForGlobalAsync();
    }
    
    
    
    [HttpGet]
    [Route("test")]
    public virtual async Task<string> GetTestAsync()
    {

        return "test";
    }
}
