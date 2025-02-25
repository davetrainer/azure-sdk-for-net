// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class HybridContainerServiceAgentPoolProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType.Value.ToString());
            }
            if (Optional.IsDefined(OSSku))
            {
                writer.WritePropertyName("osSKU"u8);
                writer.WriteStringValue(OSSku.Value.ToString());
            }
            if (Optional.IsCollectionDefined(NodeLabels))
            {
                writer.WritePropertyName("nodeLabels"u8);
                writer.WriteStartObject();
                foreach (var item in NodeLabels)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(NodeTaints))
            {
                writer.WritePropertyName("nodeTaints"u8);
                writer.WriteStartArray();
                foreach (var item in NodeTaints)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(MaxCount))
            {
                writer.WritePropertyName("maxCount"u8);
                writer.WriteNumberValue(MaxCount.Value);
            }
            if (Optional.IsDefined(MinCount))
            {
                writer.WritePropertyName("minCount"u8);
                writer.WriteNumberValue(MinCount.Value);
            }
            if (Optional.IsDefined(EnableAutoScaling))
            {
                writer.WritePropertyName("enableAutoScaling"u8);
                writer.WriteBooleanValue(EnableAutoScaling.Value);
            }
            if (Optional.IsDefined(MaxPods))
            {
                writer.WritePropertyName("maxPods"u8);
                writer.WriteNumberValue(MaxPods.Value);
            }
            writer.WriteEndObject();
        }

        internal static HybridContainerServiceAgentPoolProfile DeserializeHybridContainerServiceAgentPoolProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<HybridContainerServiceOSType> osType = default;
            Optional<HybridContainerServiceOSSku> ossku = default;
            Optional<IDictionary<string, string>> nodeLabels = default;
            Optional<IList<string>> nodeTaints = default;
            Optional<int> maxCount = default;
            Optional<int> minCount = default;
            Optional<bool> enableAutoScaling = default;
            Optional<int> maxPods = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("osType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osType = new HybridContainerServiceOSType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("osSKU"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ossku = new HybridContainerServiceOSSku(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("nodeLabels"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    nodeLabels = dictionary;
                    continue;
                }
                if (property.NameEquals("nodeTaints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    nodeTaints = array;
                    continue;
                }
                if (property.NameEquals("maxCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("enableAutoScaling"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableAutoScaling = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("maxPods"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxPods = property.Value.GetInt32();
                    continue;
                }
            }
            return new HybridContainerServiceAgentPoolProfile(Optional.ToNullable(osType), Optional.ToNullable(ossku), Optional.ToDictionary(nodeLabels), Optional.ToList(nodeTaints), Optional.ToNullable(maxCount), Optional.ToNullable(minCount), Optional.ToNullable(enableAutoScaling), Optional.ToNullable(maxPods));
        }
    }
}
