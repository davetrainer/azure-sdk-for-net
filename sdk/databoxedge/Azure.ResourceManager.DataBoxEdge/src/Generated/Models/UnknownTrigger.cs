// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.DataBoxEdge;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> The UnknownTrigger. </summary>
    internal partial class UnknownTrigger : DataBoxEdgeTriggerData
    {
        /// <summary> Initializes a new instance of <see cref="UnknownTrigger"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Trigger Kind. </param>
        internal UnknownTrigger(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, TriggerEventType kind) : base(id, name, resourceType, systemData, kind)
        {
            Kind = kind;
        }
    }
}
