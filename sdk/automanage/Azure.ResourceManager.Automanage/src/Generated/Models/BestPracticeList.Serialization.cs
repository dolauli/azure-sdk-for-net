// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Automanage;

namespace Azure.ResourceManager.Automanage.Models
{
    internal partial class BestPracticeList
    {
        internal static BestPracticeList DeserializeBestPracticeList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<AutomanageBestPracticeData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<AutomanageBestPracticeData> array = new List<AutomanageBestPracticeData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AutomanageBestPracticeData.DeserializeAutomanageBestPracticeData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new BestPracticeList(Optional.ToList(value));
        }
    }
}
