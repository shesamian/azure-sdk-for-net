// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageRcmFabricCreationInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("vmwareSiteId");
            writer.WriteStringValue(VMwareSiteId);
            writer.WritePropertyName("physicalSiteId");
            writer.WriteStringValue(PhysicalSiteId);
            writer.WritePropertyName("sourceAgentIdentity");
            writer.WriteObjectValue(SourceAgentIdentity);
            writer.WritePropertyName("instanceType");
            writer.WriteStringValue(InstanceType);
            writer.WriteEndObject();
        }
    }
}
