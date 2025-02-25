// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> Describes the VM SKU capabilities like MemoryGB, vCPUs, etc. </summary>
    public partial class HybridContainerServiceVmSkuCapabilities
    {
        /// <summary> Initializes a new instance of <see cref="HybridContainerServiceVmSkuCapabilities"/>. </summary>
        internal HybridContainerServiceVmSkuCapabilities()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HybridContainerServiceVmSkuCapabilities"/>. </summary>
        /// <param name="name"> Name of the VM SKU capability. </param>
        /// <param name="value"> Value of the VM SKU capability. </param>
        internal HybridContainerServiceVmSkuCapabilities(string name, string value)
        {
            Name = name;
            Value = value;
        }

        /// <summary> Name of the VM SKU capability. </summary>
        public string Name { get; }
        /// <summary> Value of the VM SKU capability. </summary>
        public string Value { get; }
    }
}
