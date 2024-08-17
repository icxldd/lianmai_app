using LINGYUN.Abp.SettingManagement;
using Microsoft.AspNetCore.Authorization;
using App.Icxl.App.Permissions;
using App.Icxl.App.Localization;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Features;
using Volo.Abp.MultiTenancy;
using Volo.Abp.SettingManagement;
using Volo.Abp.Settings;
using Volo.Abp.Users;

namespace App.Icxl.App.SettingManagement;

public class AppSettingAppService : ApplicationService, IAppSettingAppService
{
    protected ISettingManager SettingManager { get; }
    protected ISettingDefinitionManager SettingDefinitionManager { get; }

    public AppSettingAppService(
        ISettingManager settingManager,
        ISettingDefinitionManager settingDefinitionManager)
    {
        SettingManager = settingManager;
        SettingDefinitionManager = settingDefinitionManager;
        LocalizationResource = typeof(AppResource);
    }

    public virtual async Task<SettingGroupResult> GetAllForCurrentTenantAsync()
    {
        return await GetAllForProviderAsync(TenantSettingValueProvider.ProviderName, CurrentTenant.GetId().ToString());
    }

    [Authorize]
    public virtual async Task<SettingGroupResult> GetAllForCurrentUserAsync()
    {
        return await GetAllForProviderAsync(UserSettingValueProvider.ProviderName, CurrentUser.GetId().ToString());
    }

    public virtual async Task<SettingGroupResult> GetAllForGlobalAsync()
    {
        return await GetAllForProviderAsync(GlobalSettingValueProvider.ProviderName, null);
    }

    [Authorize(AppPermissions.ManageSettings)]
    public virtual async Task SetCurrentTenantAsync(UpdateSettingsDto input)
    {
        // 增加特性检查
        await CheckFeatureAsync();

        if (CurrentTenant.IsAvailable)
        {
            foreach (var setting in input.Settings)
            {
                await SettingManager.SetForTenantAsync(CurrentTenant.GetId(), setting.Name, setting.Value);
            }

            await CurrentUnitOfWork.SaveChangesAsync();
        }
    }

    [Authorize]
    public virtual async Task SetCurrentUserAsync(UpdateSettingsDto input)
    {
        // 增加特性检查
        await CheckFeatureAsync();

        foreach (var setting in input.Settings)
        {
            await SettingManager.SetForCurrentUserAsync(setting.Name, setting.Value);
        }

        await CurrentUnitOfWork.SaveChangesAsync();
    }

    [Authorize(AppPermissions.ManageSettings)]
    public virtual async Task SetGlobalAsync(UpdateSettingsDto input)
    {
        // 增加特性检查
        await CheckFeatureAsync();

        foreach (var setting in input.Settings)
        {
            await SettingManager.SetGlobalAsync(setting.Name, setting.Value);
        }

        await CurrentUnitOfWork.SaveChangesAsync();
    }


    protected virtual async Task CheckFeatureAsync()
    {
        await FeatureChecker.CheckEnabledAsync(SettingManagementFeatures.Enable);
    }

    protected virtual async Task<SettingGroupResult> GetAllForProviderAsync(string providerName, string providerKey)
    {
        var settingGroups = new SettingGroupResult();

        //TODO: 当前项目所有配置项在此定义返回

        await Task.CompletedTask;

        return settingGroups;
    }
}
