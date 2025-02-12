// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ArcScVmm.Models
{
    /// <summary> Network Interface model. </summary>
    public partial class NetworkInterfacesUpdate
    {
        /// <summary> Initializes a new instance of NetworkInterfacesUpdate. </summary>
        public NetworkInterfacesUpdate()
        {
        }

        /// <summary> Gets or sets the name of the network interface. </summary>
        public string Name { get; set; }
        /// <summary> Gets or sets the nic MAC address. </summary>
        public string MacAddress { get; set; }
        /// <summary> Gets or sets the ARM Id of the Microsoft.ScVmm/virtualNetwork resource to connect the nic. </summary>
        public string VirtualNetworkId { get; set; }
        /// <summary> Gets or sets the ipv4 address type. </summary>
        public AllocationMethod? IPv4AddressType { get; set; }
        /// <summary> Gets or sets the ipv6 address type. </summary>
        public AllocationMethod? IPv6AddressType { get; set; }
        /// <summary> Gets or sets the mac address type. </summary>
        public AllocationMethod? MacAddressType { get; set; }
        /// <summary> Gets or sets the nic id. </summary>
        public string NicId { get; set; }
    }
}
