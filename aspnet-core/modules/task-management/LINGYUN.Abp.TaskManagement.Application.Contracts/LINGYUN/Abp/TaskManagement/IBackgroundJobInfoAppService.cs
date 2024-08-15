﻿using LINGYUN.Abp.Dynamic.Queryable;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace LINGYUN.Abp.TaskManagement;

public interface IBackgroundJobInfoAppService :
    ICrudAppService<
        BackgroundJobInfoDto,
        string,
        BackgroundJobInfoGetListInput,
        BackgroundJobInfoCreateDto,
        BackgroundJobInfoUpdateDto>,
    IDynamicQueryableAppService<BackgroundJobInfoDto>
{
    Task TriggerAsync(string id);

    Task PauseAsync(string id);

    Task ResumeAsync(string id);

    Task StopAsync(string id);

    Task StartAsync(string id);

    Task BulkDeleteAsync(BackgroundJobInfoBatchInput input);

    Task BulkStopAsync(BackgroundJobInfoBatchInput input);

    Task BulkStartAsync(BackgroundJobInfoBatchInput input);

    Task BulkTriggerAsync(BackgroundJobInfoBatchInput input);

    Task BulkResumeAsync(BackgroundJobInfoBatchInput input);

    Task BulkPauseAsync(BackgroundJobInfoBatchInput input);

    Task<ListResultDto<BackgroundJobDefinitionDto>> GetDefinitionsAsync();
}
