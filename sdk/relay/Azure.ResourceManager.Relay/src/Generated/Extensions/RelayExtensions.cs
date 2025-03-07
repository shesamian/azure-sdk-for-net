// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Relay.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Relay
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Relay. </summary>
    public static partial class RelayExtensions
    {
        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary>
        /// Check the specified namespace name availability.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Relay/checkNameAvailability
        /// Operation Id: Namespaces_CheckNameAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Parameters to check availability of the specified namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<RelayNameAvailabilityResult>> CheckRelayNamespaceNameAvailabilityAsync(this SubscriptionResource subscriptionResource, RelayNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return await GetExtensionClient(subscriptionResource).CheckRelayNamespaceNameAvailabilityAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check the specified namespace name availability.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Relay/checkNameAvailability
        /// Operation Id: Namespaces_CheckNameAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> Parameters to check availability of the specified namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<RelayNameAvailabilityResult> CheckRelayNamespaceNameAvailability(this SubscriptionResource subscriptionResource, RelayNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return GetExtensionClient(subscriptionResource).CheckRelayNamespaceNameAvailability(content, cancellationToken);
        }

        /// <summary>
        /// Lists all the available namespaces within the subscription regardless of the resourceGroups.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Relay/namespaces
        /// Operation Id: Namespaces_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RelayNamespaceResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<RelayNamespaceResource> GetRelayNamespacesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetRelayNamespacesAsync(cancellationToken);
        }

        /// <summary>
        /// Lists all the available namespaces within the subscription regardless of the resourceGroups.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Relay/namespaces
        /// Operation Id: Namespaces_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RelayNamespaceResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<RelayNamespaceResource> GetRelayNamespaces(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetRelayNamespaces(cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of RelayNamespaceResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of RelayNamespaceResources and their operations over a RelayNamespaceResource. </returns>
        public static RelayNamespaceCollection GetRelayNamespaces(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetRelayNamespaces();
        }

        /// <summary>
        /// Returns the description for the specified namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}
        /// Operation Id: Namespaces_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<RelayNamespaceResource>> GetRelayNamespaceAsync(this ResourceGroupResource resourceGroupResource, string namespaceName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetRelayNamespaces().GetAsync(namespaceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns the description for the specified namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Relay/namespaces/{namespaceName}
        /// Operation Id: Namespaces_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<RelayNamespaceResource> GetRelayNamespace(this ResourceGroupResource resourceGroupResource, string namespaceName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetRelayNamespaces().Get(namespaceName, cancellationToken);
        }

        #region RelayNamespaceAuthorizationRuleResource
        /// <summary>
        /// Gets an object representing a <see cref="RelayNamespaceAuthorizationRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RelayNamespaceAuthorizationRuleResource.CreateResourceIdentifier" /> to create a <see cref="RelayNamespaceAuthorizationRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RelayNamespaceAuthorizationRuleResource" /> object. </returns>
        public static RelayNamespaceAuthorizationRuleResource GetRelayNamespaceAuthorizationRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                RelayNamespaceAuthorizationRuleResource.ValidateResourceId(id);
                return new RelayNamespaceAuthorizationRuleResource(client, id);
            }
            );
        }
        #endregion

        #region RelayHybridConnectionAuthorizationRuleResource
        /// <summary>
        /// Gets an object representing a <see cref="RelayHybridConnectionAuthorizationRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RelayHybridConnectionAuthorizationRuleResource.CreateResourceIdentifier" /> to create a <see cref="RelayHybridConnectionAuthorizationRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RelayHybridConnectionAuthorizationRuleResource" /> object. </returns>
        public static RelayHybridConnectionAuthorizationRuleResource GetRelayHybridConnectionAuthorizationRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                RelayHybridConnectionAuthorizationRuleResource.ValidateResourceId(id);
                return new RelayHybridConnectionAuthorizationRuleResource(client, id);
            }
            );
        }
        #endregion

        #region WcfRelayAuthorizationRuleResource
        /// <summary>
        /// Gets an object representing a <see cref="WcfRelayAuthorizationRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="WcfRelayAuthorizationRuleResource.CreateResourceIdentifier" /> to create a <see cref="WcfRelayAuthorizationRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="WcfRelayAuthorizationRuleResource" /> object. </returns>
        public static WcfRelayAuthorizationRuleResource GetWcfRelayAuthorizationRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                WcfRelayAuthorizationRuleResource.ValidateResourceId(id);
                return new WcfRelayAuthorizationRuleResource(client, id);
            }
            );
        }
        #endregion

        #region RelayNamespaceResource
        /// <summary>
        /// Gets an object representing a <see cref="RelayNamespaceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RelayNamespaceResource.CreateResourceIdentifier" /> to create a <see cref="RelayNamespaceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RelayNamespaceResource" /> object. </returns>
        public static RelayNamespaceResource GetRelayNamespaceResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                RelayNamespaceResource.ValidateResourceId(id);
                return new RelayNamespaceResource(client, id);
            }
            );
        }
        #endregion

        #region RelayNetworkRuleSetResource
        /// <summary>
        /// Gets an object representing a <see cref="RelayNetworkRuleSetResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RelayNetworkRuleSetResource.CreateResourceIdentifier" /> to create a <see cref="RelayNetworkRuleSetResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RelayNetworkRuleSetResource" /> object. </returns>
        public static RelayNetworkRuleSetResource GetRelayNetworkRuleSetResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                RelayNetworkRuleSetResource.ValidateResourceId(id);
                return new RelayNetworkRuleSetResource(client, id);
            }
            );
        }
        #endregion

        #region RelayHybridConnectionResource
        /// <summary>
        /// Gets an object representing a <see cref="RelayHybridConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RelayHybridConnectionResource.CreateResourceIdentifier" /> to create a <see cref="RelayHybridConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RelayHybridConnectionResource" /> object. </returns>
        public static RelayHybridConnectionResource GetRelayHybridConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                RelayHybridConnectionResource.ValidateResourceId(id);
                return new RelayHybridConnectionResource(client, id);
            }
            );
        }
        #endregion

        #region WcfRelayResource
        /// <summary>
        /// Gets an object representing a <see cref="WcfRelayResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="WcfRelayResource.CreateResourceIdentifier" /> to create a <see cref="WcfRelayResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="WcfRelayResource" /> object. </returns>
        public static WcfRelayResource GetWcfRelayResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                WcfRelayResource.ValidateResourceId(id);
                return new WcfRelayResource(client, id);
            }
            );
        }
        #endregion

        #region RelayPrivateEndpointConnectionResource
        /// <summary>
        /// Gets an object representing a <see cref="RelayPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RelayPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="RelayPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RelayPrivateEndpointConnectionResource" /> object. </returns>
        public static RelayPrivateEndpointConnectionResource GetRelayPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                RelayPrivateEndpointConnectionResource.ValidateResourceId(id);
                return new RelayPrivateEndpointConnectionResource(client, id);
            }
            );
        }
        #endregion

        #region RelayPrivateLinkResource
        /// <summary>
        /// Gets an object representing a <see cref="RelayPrivateLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="RelayPrivateLinkResource.CreateResourceIdentifier" /> to create a <see cref="RelayPrivateLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RelayPrivateLinkResource" /> object. </returns>
        public static RelayPrivateLinkResource GetRelayPrivateLinkResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                RelayPrivateLinkResource.ValidateResourceId(id);
                return new RelayPrivateLinkResource(client, id);
            }
            );
        }
        #endregion
    }
}
