﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace LINGYUN.Abp.BackgroundTasks;
/// <summary>
/// 作业调度接口
/// </summary>
/// <remarks>
/// 使用场景: 调度作业到作业调度器(调度到指定运行节点作业)
/// </remarks>
public interface IJobDispatcher
{
    /// <summary>
    /// 调度单个作业
    /// </summary>
    /// <param name="job">作业明细</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<bool> DispatchAsync(JobInfo job, CancellationToken cancellationToken = default);
    /// <summary>
    /// 调度多个作业
    /// </summary>
    /// <param name="jobs">作业列表</param>
    /// <param name="nodeName">运行节点</param>
    /// <param name="tenantId">租户标识</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<bool> DispatchAsync(
        IEnumerable<JobInfo> jobs,
        string nodeName = null,
        Guid? tenantId = null,
        CancellationToken cancellationToken = default);
}
