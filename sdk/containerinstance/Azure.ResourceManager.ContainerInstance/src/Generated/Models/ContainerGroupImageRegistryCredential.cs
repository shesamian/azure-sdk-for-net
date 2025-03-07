// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> Image registry credential. </summary>
    public partial class ContainerGroupImageRegistryCredential
    {
        /// <summary> Initializes a new instance of ContainerGroupImageRegistryCredential. </summary>
        /// <param name="server"> The Docker image registry server without a protocol such as &quot;http&quot; and &quot;https&quot;. </param>
        /// <param name="username"> The username for the private registry. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="server"/> or <paramref name="username"/> is null. </exception>
        public ContainerGroupImageRegistryCredential(string server, string username)
        {
            if (server == null)
            {
                throw new ArgumentNullException(nameof(server));
            }
            if (username == null)
            {
                throw new ArgumentNullException(nameof(username));
            }

            Server = server;
            Username = username;
        }

        /// <summary> Initializes a new instance of ContainerGroupImageRegistryCredential. </summary>
        /// <param name="server"> The Docker image registry server without a protocol such as &quot;http&quot; and &quot;https&quot;. </param>
        /// <param name="username"> The username for the private registry. </param>
        /// <param name="password"> The password for the private registry. </param>
        /// <param name="identity"> The identity for the private registry. </param>
        /// <param name="identityUri"> The identity URL for the private registry. </param>
        internal ContainerGroupImageRegistryCredential(string server, string username, string password, string identity, Uri identityUri)
        {
            Server = server;
            Username = username;
            Password = password;
            Identity = identity;
            IdentityUri = identityUri;
        }

        /// <summary> The Docker image registry server without a protocol such as &quot;http&quot; and &quot;https&quot;. </summary>
        public string Server { get; set; }
        /// <summary> The username for the private registry. </summary>
        public string Username { get; set; }
        /// <summary> The password for the private registry. </summary>
        public string Password { get; set; }
        /// <summary> The identity for the private registry. </summary>
        public string Identity { get; set; }
        /// <summary> The identity URL for the private registry. </summary>
        public Uri IdentityUri { get; set; }
    }
}
