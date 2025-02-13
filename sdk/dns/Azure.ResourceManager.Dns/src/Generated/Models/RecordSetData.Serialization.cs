// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Dns.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Dns
{
    public partial class RecordSetData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Metadata))
            {
                writer.WritePropertyName("metadata");
                writer.WriteStartObject();
                foreach (var item in Metadata)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(TtlInSeconds))
            {
                writer.WritePropertyName("TTL");
                writer.WriteNumberValue(TtlInSeconds.Value);
            }
            if (Optional.IsDefined(TargetResource))
            {
                writer.WritePropertyName("targetResource");
                JsonSerializer.Serialize(writer, TargetResource);
            }
            if (Optional.IsCollectionDefined(ARecords))
            {
                writer.WritePropertyName("ARecords");
                writer.WriteStartArray();
                foreach (var item in ARecords)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AaaaRecords))
            {
                writer.WritePropertyName("AAAARecords");
                writer.WriteStartArray();
                foreach (var item in AaaaRecords)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MXRecords))
            {
                writer.WritePropertyName("MXRecords");
                writer.WriteStartArray();
                foreach (var item in MXRecords)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(NSRecords))
            {
                writer.WritePropertyName("NSRecords");
                writer.WriteStartArray();
                foreach (var item in NSRecords)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PtrRecords))
            {
                writer.WritePropertyName("PTRRecords");
                writer.WriteStartArray();
                foreach (var item in PtrRecords)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SrvRecords))
            {
                writer.WritePropertyName("SRVRecords");
                writer.WriteStartArray();
                foreach (var item in SrvRecords)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(TxtRecords))
            {
                writer.WritePropertyName("TXTRecords");
                writer.WriteStartArray();
                foreach (var item in TxtRecords)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(CnameRecord))
            {
                writer.WritePropertyName("CNAMERecord");
                writer.WriteObjectValue(CnameRecord);
            }
            if (Optional.IsDefined(SoaRecord))
            {
                writer.WritePropertyName("SOARecord");
                writer.WriteObjectValue(SoaRecord);
            }
            if (Optional.IsCollectionDefined(CaaRecords))
            {
                writer.WritePropertyName("caaRecords");
                writer.WriteStartArray();
                foreach (var item in CaaRecords)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static RecordSetData DeserializeRecordSetData(JsonElement element)
        {
            Optional<ETag> etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IDictionary<string, string>> metadata = default;
            Optional<long> ttl = default;
            Optional<string> fqdn = default;
            Optional<string> provisioningState = default;
            Optional<WritableSubResource> targetResource = default;
            Optional<IList<DnsARecord>> aRecords = default;
            Optional<IList<DnsAaaaRecord>> aaaaRecords = default;
            Optional<IList<DnsMXRecord>> mxRecords = default;
            Optional<IList<DnsNSRecord>> nsRecords = default;
            Optional<IList<DnsPtrRecord>> ptrRecords = default;
            Optional<IList<DnsSrvRecord>> srvRecords = default;
            Optional<IList<DnsTxtRecord>> txtRecords = default;
            Optional<DnsCnameRecord> cnameRecord = default;
            Optional<DnsSoaRecord> soaRecord = default;
            Optional<IList<DnsCaaRecord>> caaRecords = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("metadata"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            metadata = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("TTL"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            ttl = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("fqdn"))
                        {
                            fqdn = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("targetResource"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            targetResource = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.ToString());
                            continue;
                        }
                        if (property0.NameEquals("ARecords"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<DnsARecord> array = new List<DnsARecord>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DnsARecord.DeserializeDnsARecord(item));
                            }
                            aRecords = array;
                            continue;
                        }
                        if (property0.NameEquals("AAAARecords"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<DnsAaaaRecord> array = new List<DnsAaaaRecord>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DnsAaaaRecord.DeserializeDnsAaaaRecord(item));
                            }
                            aaaaRecords = array;
                            continue;
                        }
                        if (property0.NameEquals("MXRecords"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<DnsMXRecord> array = new List<DnsMXRecord>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DnsMXRecord.DeserializeDnsMXRecord(item));
                            }
                            mxRecords = array;
                            continue;
                        }
                        if (property0.NameEquals("NSRecords"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<DnsNSRecord> array = new List<DnsNSRecord>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DnsNSRecord.DeserializeDnsNSRecord(item));
                            }
                            nsRecords = array;
                            continue;
                        }
                        if (property0.NameEquals("PTRRecords"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<DnsPtrRecord> array = new List<DnsPtrRecord>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DnsPtrRecord.DeserializeDnsPtrRecord(item));
                            }
                            ptrRecords = array;
                            continue;
                        }
                        if (property0.NameEquals("SRVRecords"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<DnsSrvRecord> array = new List<DnsSrvRecord>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DnsSrvRecord.DeserializeDnsSrvRecord(item));
                            }
                            srvRecords = array;
                            continue;
                        }
                        if (property0.NameEquals("TXTRecords"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<DnsTxtRecord> array = new List<DnsTxtRecord>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DnsTxtRecord.DeserializeDnsTxtRecord(item));
                            }
                            txtRecords = array;
                            continue;
                        }
                        if (property0.NameEquals("CNAMERecord"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            cnameRecord = DnsCnameRecord.DeserializeDnsCnameRecord(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("SOARecord"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            soaRecord = DnsSoaRecord.DeserializeDnsSoaRecord(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("caaRecords"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<DnsCaaRecord> array = new List<DnsCaaRecord>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DnsCaaRecord.DeserializeDnsCaaRecord(item));
                            }
                            caaRecords = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new RecordSetData(id, name, type, systemData.Value, Optional.ToNullable(etag), Optional.ToDictionary(metadata), Optional.ToNullable(ttl), fqdn.Value, provisioningState.Value, targetResource, Optional.ToList(aRecords), Optional.ToList(aaaaRecords), Optional.ToList(mxRecords), Optional.ToList(nsRecords), Optional.ToList(ptrRecords), Optional.ToList(srvRecords), Optional.ToList(txtRecords), cnameRecord.Value, soaRecord.Value, Optional.ToList(caaRecords));
        }
    }
}
