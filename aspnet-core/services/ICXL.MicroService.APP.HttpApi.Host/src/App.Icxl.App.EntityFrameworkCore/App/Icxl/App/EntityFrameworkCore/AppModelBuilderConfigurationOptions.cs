using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace App.Icxl.App.EntityFrameworkCore;

public class AppModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
{
    public AppModelBuilderConfigurationOptions(
        [NotNull] string tablePrefix = "",
        [CanBeNull] string schema = null)
        : base(
            tablePrefix,
            schema)
    {

    }
}
