// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class DataLakeStorageAccountDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AccountUri))
            {
                writer.WritePropertyName("accountUrl");
                writer.WriteStringValue(AccountUri.AbsoluteUri);
            }
            if (Optional.IsDefined(Filesystem))
            {
                writer.WritePropertyName("filesystem");
                writer.WriteStringValue(Filesystem);
            }
            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId");
                writer.WriteStringValue(ResourceId);
            }
            if (Optional.IsDefined(CreateManagedPrivateEndpoint))
            {
                writer.WritePropertyName("createManagedPrivateEndpoint");
                writer.WriteBooleanValue(CreateManagedPrivateEndpoint.Value);
            }
            writer.WriteEndObject();
        }

        internal static DataLakeStorageAccountDetails DeserializeDataLakeStorageAccountDetails(JsonElement element)
        {
            Optional<Uri> accountUrl = default;
            Optional<string> filesystem = default;
            Optional<string> resourceId = default;
            Optional<bool> createManagedPrivateEndpoint = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountUrl"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        accountUrl = null;
                        continue;
                    }
                    accountUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("filesystem"))
                {
                    filesystem = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceId"))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createManagedPrivateEndpoint"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    createManagedPrivateEndpoint = property.Value.GetBoolean();
                    continue;
                }
            }
            return new DataLakeStorageAccountDetails(accountUrl.Value, filesystem.Value, resourceId.Value, Optional.ToNullable(createManagedPrivateEndpoint));
        }
    }
}
