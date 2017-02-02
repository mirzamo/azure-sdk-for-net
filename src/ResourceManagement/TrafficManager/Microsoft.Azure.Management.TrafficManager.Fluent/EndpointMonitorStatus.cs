// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
using Microsoft.Azure.Management.Resource.Fluent.Core;

namespace Microsoft.Azure.Management.TrafficManager.Fluent
{
    /// <summary>
    /// Traffic manager profile endpoint monitor statuses.
    /// </summary>
    public partial class EndpointMonitorStatus : ExpandableStringEnum<EndpointMonitorStatus>
    {
        public static readonly EndpointMonitorStatus Inactive = Parse("Inactive");
        public static readonly EndpointMonitorStatus Disabled = Parse("Disabled");
        public static readonly EndpointMonitorStatus Online = Parse("Online");
        public static readonly EndpointMonitorStatus Degraded = Parse("Degraded");
        public static readonly EndpointMonitorStatus CheckingEndpoint = Parse("CheckingEndpoint");
        public static readonly EndpointMonitorStatus Stopped = Parse("Stopped");
    }
}