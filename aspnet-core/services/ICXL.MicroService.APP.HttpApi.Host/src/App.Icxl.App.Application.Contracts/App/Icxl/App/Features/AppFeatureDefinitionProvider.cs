using App.Icxl.App.Localization;
using Volo.Abp.Features;
using Volo.Abp.Localization;

namespace App.Icxl.App.Features;

public class AppFeatureDefinitionProvider : FeatureDefinitionProvider
{
    public override void Define(IFeatureDefinitionContext context)
    {
        var group = context.AddGroup(AppFeatureNames.GroupName, L("Features:App"));
    }

    private static ILocalizableString L(string name)
    {
        return LocalizableString.Create<AppResource>(name);
    }
}
