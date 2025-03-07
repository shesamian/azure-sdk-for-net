// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Enable migration input. </summary>
    public partial class MigrationItemCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of MigrationItemCreateOrUpdateContent. </summary>
        /// <param name="properties"> Enable migration input properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public MigrationItemCreateOrUpdateContent(EnableMigrationInputProperties properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
        }

        /// <summary> Enable migration input properties. </summary>
        public EnableMigrationInputProperties Properties { get; }
    }
}
