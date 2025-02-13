// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    /// <summary> Container for collecting tones for DTFM. </summary>
    public partial class CollectTones
    {
        /// <summary> Initializes a new instance of CollectTones. </summary>
        public CollectTones()
        {
            StopTones = new ChangeTrackingList<string>();
        }

        /// <summary> Time to wait between DTMF inputs to stop recognizing. </summary>
        public int? InterToneTimeoutInSeconds { get; set; }
        /// <summary> Maximum number of DTMFs to be collected. </summary>
        public int? MaxTonesToCollect { get; set; }
        /// <summary> List of tones that will stop recognizing. </summary>
        public IList<string> StopTones { get; }
    }
}
