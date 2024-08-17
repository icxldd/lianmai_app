using LINGYUN.Abp.Dynamic.Queryable;
using App.Icxl.App.Localization;

namespace App.Icxl.App;
/// <summary>
/// 提供动态查询控制器实现
/// </summary>
/// <typeparam name="TEntityDto">实体dto类型</typeparam>
public abstract class AppDynamicQueryableControllerBase<TEntityDto> : DynamicQueryableControllerBase<TEntityDto>
{
    protected AppDynamicQueryableControllerBase(
        IDynamicQueryableAppService<TEntityDto> service)
        : base(service)
    {
        LocalizationResource = typeof(AppResource);
    }
}
