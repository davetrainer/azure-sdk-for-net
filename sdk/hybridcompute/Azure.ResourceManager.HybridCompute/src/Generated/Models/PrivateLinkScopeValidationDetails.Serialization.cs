// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridCompute.Models
{
    public partial class PrivateLinkScopeValidationDetails
    {
        internal static PrivateLinkScopeValidationDetails DeserializePrivateLinkScopeValidationDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> id = default;
            Optional<HybridComputePublicNetworkAccessType> publicNetworkAccess = default;
            Optional<IReadOnlyList<HybridComputeConnectionDetail>> connectionDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publicNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicNetworkAccess = new HybridComputePublicNetworkAccessType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("connectionDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HybridComputeConnectionDetail> array = new List<HybridComputeConnectionDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HybridComputeConnectionDetail.DeserializeHybridComputeConnectionDetail(item));
                    }
                    connectionDetails = array;
                    continue;
                }
            }
            return new PrivateLinkScopeValidationDetails(id.Value, Optional.ToNullable(publicNetworkAccess), Optional.ToList(connectionDetails));
        }
    }
}
