// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Desired outbound IP resources for Azure Spring Cloud instance. </summary>
    internal partial class NetworkProfileOutboundIPs
    {
        /// <summary> Initializes a new instance of NetworkProfileOutboundIPs. </summary>
        internal NetworkProfileOutboundIPs()
        {
            PublicIPs = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of NetworkProfileOutboundIPs. </summary>
        /// <param name="publicIPs"> A list of public IP addresses. </param>
        internal NetworkProfileOutboundIPs(IReadOnlyList<string> publicIPs)
        {
            PublicIPs = publicIPs;
        }

        /// <summary> A list of public IP addresses. </summary>
        public IReadOnlyList<string> PublicIPs { get; }
    }
}
