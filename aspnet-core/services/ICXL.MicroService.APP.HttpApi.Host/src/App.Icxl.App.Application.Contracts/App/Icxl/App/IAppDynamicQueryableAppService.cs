using LINGYUN.Abp.Dynamic.Queryable;

namespace App.Icxl.App;
/// <summary>
/// 提供动态查询接口定义
/// </summary>
/// <typeparam name="TEntityDto">实体dto类型</typeparam>
public interface IAppDynamicQueryableAppService<TEntityDto> : IDynamicQueryableAppService<TEntityDto>
{
}
