using LINGYUN.Abp.Dynamic.Queryable;
using App.Icxl.App.Localization;

namespace App.Icxl.App;
/// <summary>
/// 提供动态查询接口实现
/// </summary>
/// <typeparam name="TEntity">实体类型</typeparam>
/// <typeparam name="TEntityDto">实体dto类型</typeparam>
public abstract class AppDynamicQueryableAppServiceBase<TEntity, TEntityDto> :
    DynamicQueryableAppService<TEntity, TEntityDto>,
    IAppDynamicQueryableAppService<TEntityDto>
{
    protected AppDynamicQueryableAppServiceBase()
    {
        LocalizationResource = typeof(AppResource);
        ObjectMapperContext = typeof(AppApplicationModule);
    }
}
