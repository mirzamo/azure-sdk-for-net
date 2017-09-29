// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.AzureStack.Management.Fabric.Admin
{
    using Microsoft.AzureStack;
    using Microsoft.AzureStack.Management;
    using Microsoft.AzureStack.Management.Fabric;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ComputeFabricOperations.
    /// </summary>
    public static partial class ComputeFabricOperationsExtensions
    {
            /// <summary>
            /// Get the status of a compute fabric operation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='provider'>
            /// Name of the provider.
            /// </param>
            /// <param name='computeOperationResult'>
            /// Id of a compute fabric operation.
            /// </param>
            public static OperationStatus Get(this IComputeFabricOperations operations, string location, string provider, string computeOperationResult)
            {
                return operations.GetAsync(location, provider, computeOperationResult).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the status of a compute fabric operation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// Location of the resource.
            /// </param>
            /// <param name='provider'>
            /// Name of the provider.
            /// </param>
            /// <param name='computeOperationResult'>
            /// Id of a compute fabric operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationStatus> GetAsync(this IComputeFabricOperations operations, string location, string provider, string computeOperationResult, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(location, provider, computeOperationResult, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}