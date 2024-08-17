using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.ObjectExtending.Modularity;

namespace App.Icxl.App.ObjectExtending;

public static class AppModuleExtensionConfigurationDictionaryExtensions
{
    public static ModuleExtensionConfigurationDictionary ConfigureApp(
        this ModuleExtensionConfigurationDictionary modules,
        Action<AppModuleExtensionConfiguration> configureAction)
    {
        return modules.ConfigureModule(
            AppModuleExtensionConsts.ModuleName,
            configureAction
        );
    }
}
