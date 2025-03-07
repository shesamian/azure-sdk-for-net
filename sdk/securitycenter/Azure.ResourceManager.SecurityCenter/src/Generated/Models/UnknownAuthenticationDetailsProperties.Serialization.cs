// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    internal partial class UnknownAuthenticationDetailsProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("authenticationType");
            writer.WriteStringValue(AuthenticationType.ToString());
            writer.WriteEndObject();
        }

        internal static UnknownAuthenticationDetailsProperties DeserializeUnknownAuthenticationDetailsProperties(JsonElement element)
        {
            Optional<AuthenticationProvisioningState> authenticationProvisioningState = default;
            Optional<IReadOnlyList<PermissionProperty>> grantedPermissions = default;
            AuthenticationType authenticationType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authenticationProvisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    authenticationProvisioningState = new AuthenticationProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("grantedPermissions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PermissionProperty> array = new List<PermissionProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new PermissionProperty(item.GetString()));
                    }
                    grantedPermissions = array;
                    continue;
                }
                if (property.NameEquals("authenticationType"))
                {
                    authenticationType = new AuthenticationType(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownAuthenticationDetailsProperties(Optional.ToNullable(authenticationProvisioningState), Optional.ToList(grantedPermissions), authenticationType);
        }
    }
}
