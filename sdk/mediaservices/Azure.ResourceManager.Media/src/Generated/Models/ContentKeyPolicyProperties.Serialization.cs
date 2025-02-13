// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class ContentKeyPolicyProperties
    {
        internal static ContentKeyPolicyProperties DeserializeContentKeyPolicyProperties(JsonElement element)
        {
            Optional<Guid> policyId = default;
            Optional<DateTimeOffset> created = default;
            Optional<DateTimeOffset> lastModified = default;
            Optional<string> description = default;
            IReadOnlyList<ContentKeyPolicyPreference> options = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("policyId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    policyId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("created"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    created = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastModified"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastModified = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("options"))
                {
                    List<ContentKeyPolicyPreference> array = new List<ContentKeyPolicyPreference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContentKeyPolicyPreference.DeserializeContentKeyPolicyPreference(item));
                    }
                    options = array;
                    continue;
                }
            }
            return new ContentKeyPolicyProperties(Optional.ToNullable(policyId), Optional.ToNullable(created), Optional.ToNullable(lastModified), description.Value, options);
        }
    }
}
