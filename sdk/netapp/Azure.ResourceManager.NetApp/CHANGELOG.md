# Release History

## 1.1.0-beta.1 (Unreleased)

### Features Added

### Breaking Changes

### Bugs Fixed

### Other Changes

## 1.0.0 (2022-09-28)

This is the first stable release of the NetApp Management client library.

### Features Added

- Upgrading to support new service api version 2022-05-01
- Added QueryRegionInfoNetAppResourceAsync
- NetAppAccount has new EncryptionKeySource
- NetAppAccount has new AccountEncryption properties, KeySource, KeyVaultProperties and Identity
- Added AccountEncryption KeySource changed to Enum
- Added RenewCredentialsAsync to NetAppAccountResource
- Added DisableShowmount and EncryptionKeySource to NetAppAccount
- Added CoolnessPeriod, CoolAccess to NetAppVolume and NetAppVolumePatch
- Added optional RelocateVolumeContent to NetAppVolume.RelocateAsync
- Added SmbAccessBasedEnumeration, smbNonBrowsable, keyVaultPrivateEndpointResourceId, deleteBaseSnapshot to NetAppVolumeData

### Breaking Changes

Polishing since last public beta release:
- Prepended `NetApp` prefix to all single / simple model names.
- Corrected the format of all `ResourceIdentifier` type properties / parameters.
- Corrected the format of all `ResouceType` type properties / parameters.
- Corrected the format of all `ETag` type properties / parameters.
- Corrected the format of all `AzureLocation` type properties / parameters.
- Corrected the format of all binary type properties / parameters.
- Corrected all acronyms which not follow [.Net Naming Guidelines](https://docs.microsoft.com/dotnet/standard/design-guidelines/naming-guidelines).
- Corrected enumeration name by following [Naming Enumerations Rule](https://docs.microsoft.com/dotnet/standard/design-guidelines/names-of-classes-structs-and-interfaces#naming-enumerations).
- Corrected the suffix of `DateTimeOffset` properties / parameters.
- Corrected the name of interval / duration properties / parameters which end with units.
- Optimized the name of some models and functions.
- Removed `location` from `NetAppVault`

### Other Changes

- Upgraded dependent Azure.ResourceManager to 1.3.1.
- Optimized the implementation of methods related to tag operations.

## 1.0.0-beta.1 (2022-08-18)

### Breaking Changes

New design of track 2 initial commit.

### Package Name

The package name has been changed from `Microsoft.Azure.Management.NetApp` to `Azure.ResourceManager.NetApp`.

### General New Features

    - Support MSAL.NET, Azure.Identity is out of box for supporting MSAL.NET
    - Support [OpenTelemetry](https://opentelemetry.io/) for distributed tracing
    - HTTP pipeline with custom policies
    - Better error-handling
    - Support uniform telemetry across all languages

This package follows the [Azure SDK Design Guidelines for .NET](https://azure.github.io/azure-sdk/dotnet_introduction.html) which provide a number of core capabilities that are shared amongst all Azure SDKs, including the intuitive Azure Identity library, an HTTP Pipeline with custom policies, error-handling, distributed tracing, and much more.

This is a Public Preview version, so expect incompatible changes in subsequent releases as we improve the product. To provide feedback, please submit an issue in our [Azure SDK for .NET GitHub repo](https://github.com/Azure/azure-sdk-for-net/issues).
