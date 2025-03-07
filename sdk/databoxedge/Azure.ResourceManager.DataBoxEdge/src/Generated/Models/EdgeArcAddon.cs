// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Arc Addon. </summary>
    public partial class EdgeArcAddon : DataBoxEdgeRoleAddonData
    {
        /// <summary> Initializes a new instance of EdgeArcAddon. </summary>
        /// <param name="subscriptionId"> Arc resource subscription Id. </param>
        /// <param name="resourceGroupName"> Arc resource group name. </param>
        /// <param name="resourceName"> Arc resource Name. </param>
        /// <param name="resourceLocation"> Arc resource location. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is null. </exception>
        public EdgeArcAddon(string subscriptionId, string resourceGroupName, string resourceName, AzureLocation resourceLocation)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }

            SubscriptionId = subscriptionId;
            ResourceGroupName = resourceGroupName;
            ResourceName = resourceName;
            ResourceLocation = resourceLocation;
            Kind = AddonType.ArcForKubernetes;
        }

        /// <summary> Initializes a new instance of EdgeArcAddon. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Addon type. </param>
        /// <param name="subscriptionId"> Arc resource subscription Id. </param>
        /// <param name="resourceGroupName"> Arc resource group name. </param>
        /// <param name="resourceName"> Arc resource Name. </param>
        /// <param name="resourceLocation"> Arc resource location. </param>
        /// <param name="version"> Arc resource version. </param>
        /// <param name="hostPlatform"> Host OS supported by the Arc addon. </param>
        /// <param name="hostPlatformType"> Platform where the runtime is hosted. </param>
        /// <param name="provisioningState"> Addon Provisioning State. </param>
        internal EdgeArcAddon(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AddonType kind, string subscriptionId, string resourceGroupName, string resourceName, AzureLocation resourceLocation, string version, DataBoxEdgeOSPlatformType? hostPlatform, HostPlatformType? hostPlatformType, DataBoxEdgeRoleAddonProvisioningState? provisioningState) : base(id, name, resourceType, systemData, kind)
        {
            SubscriptionId = subscriptionId;
            ResourceGroupName = resourceGroupName;
            ResourceName = resourceName;
            ResourceLocation = resourceLocation;
            Version = version;
            HostPlatform = hostPlatform;
            HostPlatformType = hostPlatformType;
            ProvisioningState = provisioningState;
            Kind = kind;
        }

        /// <summary> Arc resource subscription Id. </summary>
        public string SubscriptionId { get; set; }
        /// <summary> Arc resource group name. </summary>
        public string ResourceGroupName { get; set; }
        /// <summary> Arc resource Name. </summary>
        public string ResourceName { get; set; }
        /// <summary> Arc resource location. </summary>
        public AzureLocation ResourceLocation { get; set; }
        /// <summary> Arc resource version. </summary>
        public string Version { get; }
        /// <summary> Host OS supported by the Arc addon. </summary>
        public DataBoxEdgeOSPlatformType? HostPlatform { get; }
        /// <summary> Platform where the runtime is hosted. </summary>
        public HostPlatformType? HostPlatformType { get; }
        /// <summary> Addon Provisioning State. </summary>
        public DataBoxEdgeRoleAddonProvisioningState? ProvisioningState { get; }
    }
}
