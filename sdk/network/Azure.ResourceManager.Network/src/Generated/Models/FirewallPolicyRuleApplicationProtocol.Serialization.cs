// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class FirewallPolicyRuleApplicationProtocol : IUtf8JsonSerializable, IJsonModel<FirewallPolicyRuleApplicationProtocol>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FirewallPolicyRuleApplicationProtocol>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FirewallPolicyRuleApplicationProtocol>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPolicyRuleApplicationProtocol>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirewallPolicyRuleApplicationProtocol)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ProtocolType))
            {
                writer.WritePropertyName("protocolType"u8);
                writer.WriteStringValue(ProtocolType.Value.ToString());
            }
            if (Optional.IsDefined(Port))
            {
                writer.WritePropertyName("port"u8);
                writer.WriteNumberValue(Port.Value);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        FirewallPolicyRuleApplicationProtocol IJsonModel<FirewallPolicyRuleApplicationProtocol>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPolicyRuleApplicationProtocol>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirewallPolicyRuleApplicationProtocol)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFirewallPolicyRuleApplicationProtocol(document.RootElement, options);
        }

        internal static FirewallPolicyRuleApplicationProtocol DeserializeFirewallPolicyRuleApplicationProtocol(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<FirewallPolicyRuleApplicationProtocolType> protocolType = default;
            Optional<int> port = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("protocolType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protocolType = new FirewallPolicyRuleApplicationProtocolType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("port"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    port = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FirewallPolicyRuleApplicationProtocol(Optional.ToNullable(protocolType), Optional.ToNullable(port), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FirewallPolicyRuleApplicationProtocol>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPolicyRuleApplicationProtocol>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FirewallPolicyRuleApplicationProtocol)} does not support '{options.Format}' format.");
            }
        }

        FirewallPolicyRuleApplicationProtocol IPersistableModel<FirewallPolicyRuleApplicationProtocol>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPolicyRuleApplicationProtocol>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFirewallPolicyRuleApplicationProtocol(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FirewallPolicyRuleApplicationProtocol)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FirewallPolicyRuleApplicationProtocol>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
