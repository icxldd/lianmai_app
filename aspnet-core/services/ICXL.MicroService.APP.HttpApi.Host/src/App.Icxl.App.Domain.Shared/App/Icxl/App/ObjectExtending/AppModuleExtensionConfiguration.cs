using System;
using Volo.Abp.ObjectExtending.Modularity;

namespace App.Icxl.App.ObjectExtending;

public class AppModuleExtensionConfiguration : ModuleExtensionConfiguration
{
    public AppModuleExtensionConfiguration ConfigureApp(
        Action<EntityExtensionConfiguration> configureAction)
    {
        return this.ConfigureEntity(
            AppModuleExtensionConsts.EntityNames.Entity,
            configureAction
        );
    }
}
