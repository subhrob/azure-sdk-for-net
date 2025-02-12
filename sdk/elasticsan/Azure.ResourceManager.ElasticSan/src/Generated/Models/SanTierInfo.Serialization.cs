// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ElasticSan.Models
{
    public partial class SanTierInfo
    {
        internal static SanTierInfo DeserializeSanTierInfo(JsonElement element)
        {
            Optional<long> maxSizeTiB = default;
            Optional<long> minSizeTiB = default;
            Optional<long> minIncrementSizeTiB = default;
            Optional<long> iopsPerBaseTiB = default;
            Optional<long> mbpsPerBaseTiB = default;
            Optional<long> maxMbps = default;
            Optional<long> maxElasticSanVolumeGroupCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxSizeTiB"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxSizeTiB = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("minSizeTiB"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    minSizeTiB = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("minIncrementSizeTiB"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    minIncrementSizeTiB = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("iopsPerBaseTiB"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    iopsPerBaseTiB = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("mbpsPerBaseTiB"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    mbpsPerBaseTiB = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("maxMBps"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxMbps = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("maxVolumeGroupCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxElasticSanVolumeGroupCount = property.Value.GetInt64();
                    continue;
                }
            }
            return new SanTierInfo(Optional.ToNullable(maxSizeTiB), Optional.ToNullable(minSizeTiB), Optional.ToNullable(minIncrementSizeTiB), Optional.ToNullable(iopsPerBaseTiB), Optional.ToNullable(mbpsPerBaseTiB), Optional.ToNullable(maxMbps), Optional.ToNullable(maxElasticSanVolumeGroupCount));
        }
    }
}
