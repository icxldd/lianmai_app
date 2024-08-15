﻿using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace LINGYUN.Abp.BackgroundTasks.Internal;

internal class DefaultBackgroundWorker : BackgroundService
{
    private readonly IJobStore _jobStore;
    private readonly IJobPublisher _jobPublisher;
    private readonly AbpBackgroundTasksOptions _options;

    public DefaultBackgroundWorker(
        IJobStore jobStore,
        IJobPublisher jobPublisher,
        IOptions<AbpBackgroundTasksOptions> options)
    {
        _jobStore = jobStore;
        _jobPublisher = jobPublisher;
        _options = options.Value;
    }

    protected async override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await QueuePollingJob();
        await QueueCleaningJob();
        await QueueCheckingJob();
    }

    private async Task QueuePollingJob()
    {
        if (_options.JobFetchEnabled)
        {
            var pollingJob = BuildPollingJobInfo();
            await _jobPublisher.PublishAsync(pollingJob);
        }
    }

    private async Task QueueCleaningJob()
    {
        if (_options.JobCleanEnabled)
        {
            var cleaningJob = BuildCleaningJobInfo();
            await _jobPublisher.PublishAsync(cleaningJob);
        }
    }

    private async Task QueueCheckingJob()
    {
        if (_options.JobCheckEnabled)
        {
            var checkingJob = BuildCheckingJobInfo();
            await _jobPublisher.PublishAsync(checkingJob);
        }
    }



    private JobInfo BuildPollingJobInfo()
    {
        return new JobInfo
        {
            Id = "Polling",
            Name = nameof(BackgroundPollingJob),
            Group = "Polling",
            Description = "Polling tasks to be executed",
            Args = new Dictionary<string, object>(),
            Status = JobStatus.Running,
            BeginTime = DateTime.Now,
            CreationTime = DateTime.Now,
            Cron = _options.JobFetchCronExpression,
            JobType = JobType.Period,
            Priority = JobPriority.High,
            Source = JobSource.System,
            LockTimeOut = _options.JobFetchLockTimeOut,
            NodeName = _options.NodeName,
            Type = typeof(BackgroundPollingJob).AssemblyQualifiedName,
        };
    }

    private JobInfo BuildCleaningJobInfo()
    {
        return new JobInfo
        {
            Id = "Cleaning",
            Name = nameof(BackgroundCleaningJob),
            Group = "Cleaning",
            Description = "Cleaning tasks to be executed",
            Args = new Dictionary<string, object>(),
            Status = JobStatus.Running,
            BeginTime = DateTime.Now,
            CreationTime = DateTime.Now,
            Cron = _options.JobCleanCronExpression,
            JobType = JobType.Period,
            Priority = JobPriority.High,
            Source = JobSource.System,
            NodeName = _options.NodeName,
            Type = typeof(BackgroundCleaningJob).AssemblyQualifiedName,
        };
    }

    private JobInfo BuildCheckingJobInfo()
    {
        return new JobInfo
        {
            Id = "Checking",
            Name = nameof(BackgroundCheckingJob),
            Group = "Checking",
            Description = "Checking tasks to be executed",
            Args = new Dictionary<string, object>(),
            Status = JobStatus.Running,
            BeginTime = DateTime.Now,
            CreationTime = DateTime.Now,
            Cron = _options.JobCheckCronExpression,
            LockTimeOut = _options.JobCheckLockTimeOut,
            JobType = JobType.Period,
            Priority = JobPriority.High,
            Source = JobSource.System,
            NodeName = _options.NodeName,
            Type = typeof(BackgroundCheckingJob).AssemblyQualifiedName,
        };
    }
}
