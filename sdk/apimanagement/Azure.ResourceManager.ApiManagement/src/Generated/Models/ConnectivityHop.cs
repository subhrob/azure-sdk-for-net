// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Net;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Information about a hop between the source and the destination. </summary>
    public partial class ConnectivityHop
    {
        /// <summary> Initializes a new instance of ConnectivityHop. </summary>
        internal ConnectivityHop()
        {
            NextHopIds = new ChangeTrackingList<string>();
            Issues = new ChangeTrackingList<ConnectivityIssue>();
        }

        /// <summary> Initializes a new instance of ConnectivityHop. </summary>
        /// <param name="connectivityHopType"> The type of the hop. </param>
        /// <param name="id"> The ID of the hop. </param>
        /// <param name="address"> The IP address of the hop. </param>
        /// <param name="resourceId"> The ID of the resource corresponding to this hop. </param>
        /// <param name="nextHopIds"> List of next hop identifiers. </param>
        /// <param name="issues"> List of issues. </param>
        internal ConnectivityHop(string connectivityHopType, string id, IPAddress address, ResourceIdentifier resourceId, IReadOnlyList<string> nextHopIds, IReadOnlyList<ConnectivityIssue> issues)
        {
            ConnectivityHopType = connectivityHopType;
            Id = id;
            Address = address;
            ResourceId = resourceId;
            NextHopIds = nextHopIds;
            Issues = issues;
        }

        /// <summary> The type of the hop. </summary>
        public string ConnectivityHopType { get; }
        /// <summary> The ID of the hop. </summary>
        public string Id { get; }
        /// <summary> The IP address of the hop. </summary>
        public IPAddress Address { get; }
        /// <summary> The ID of the resource corresponding to this hop. </summary>
        public ResourceIdentifier ResourceId { get; }
        /// <summary> List of next hop identifiers. </summary>
        public IReadOnlyList<string> NextHopIds { get; }
        /// <summary> List of issues. </summary>
        public IReadOnlyList<ConnectivityIssue> Issues { get; }
    }
}
