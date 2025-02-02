// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataShare.Models
{
    public partial class ShareSubscriptionSynchronization : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("synchronizationId"u8);
            writer.WriteStringValue(SynchronizationId);
            writer.WriteEndObject();
        }

        internal static ShareSubscriptionSynchronization DeserializeShareSubscriptionSynchronization(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> durationMs = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<string> message = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<string> status = default;
            Guid synchronizationId = default;
            Optional<SynchronizationMode> synchronizationMode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("durationMs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    durationMs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("synchronizationId"u8))
                {
                    synchronizationId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("synchronizationMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    synchronizationMode = new SynchronizationMode(property.Value.GetString());
                    continue;
                }
            }
            return new ShareSubscriptionSynchronization(Optional.ToNullable(durationMs), Optional.ToNullable(endTime), message.Value, Optional.ToNullable(startTime), status.Value, synchronizationId, Optional.ToNullable(synchronizationMode));
        }
    }
}
