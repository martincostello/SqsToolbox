﻿using System.Threading;
using System.Threading.Tasks;
using Amazon.SQS.Model;

namespace DotNetCloud.SqsToolbox.Abstractions
{
    internal interface IFailedDeletionEntryHandler
    {
        Task OnFailureAsync(BatchResultErrorEntry batchResultErrorEntry, CancellationToken cancellationToken = default);
    }
}
