// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HealthcareApis;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    /// <summary> The properties of a service instance. </summary>
    public partial class HealthcareApisServiceProperties
    {
        /// <summary> Initializes a new instance of <see cref="HealthcareApisServiceProperties"/>. </summary>
        public HealthcareApisServiceProperties()
        {
            AccessPolicies = new ChangeTrackingList<HealthcareApisServiceAccessPolicyEntry>();
            PrivateEndpointConnections = new ChangeTrackingList<HealthcareApisPrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of <see cref="HealthcareApisServiceProperties"/>. </summary>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="accessPolicies"> The access policies of the service instance. </param>
        /// <param name="cosmosDbConfiguration"> The settings for the Cosmos DB database backing the service. </param>
        /// <param name="authenticationConfiguration"> The authentication configuration for the service instance. </param>
        /// <param name="corsConfiguration"> The settings for the CORS configuration of the service instance. </param>
        /// <param name="exportConfiguration"> The settings for the export operation of the service instance. </param>
        /// <param name="privateEndpointConnections"> The list of private endpoint connections that are set up for this resource. </param>
        /// <param name="publicNetworkAccess"> Control permission for data plane traffic coming from public networks while private endpoint is enabled. </param>
        /// <param name="acrConfiguration"> The azure container registry settings used for convert data operation of the service instance. </param>
        /// <param name="importConfiguration"> The settings for the import operation of the service instance. </param>
        internal HealthcareApisServiceProperties(HealthcareApisProvisioningState? provisioningState, IList<HealthcareApisServiceAccessPolicyEntry> accessPolicies, HealthcareApisServiceCosmosDbConfiguration cosmosDbConfiguration, HealthcareApisServiceAuthenticationConfiguration authenticationConfiguration, HealthcareApisServiceCorsConfiguration corsConfiguration, ServiceExportConfigurationInfo exportConfiguration, IList<HealthcareApisPrivateEndpointConnectionData> privateEndpointConnections, HealthcareApisPublicNetworkAccess? publicNetworkAccess, HealthcareApisServiceAcrConfiguration acrConfiguration, HealthcareApisServiceImportConfiguration importConfiguration)
        {
            ProvisioningState = provisioningState;
            AccessPolicies = accessPolicies;
            CosmosDbConfiguration = cosmosDbConfiguration;
            AuthenticationConfiguration = authenticationConfiguration;
            CorsConfiguration = corsConfiguration;
            ExportConfiguration = exportConfiguration;
            PrivateEndpointConnections = privateEndpointConnections;
            PublicNetworkAccess = publicNetworkAccess;
            AcrConfiguration = acrConfiguration;
            ImportConfiguration = importConfiguration;
        }

        /// <summary> The provisioning state. </summary>
        public HealthcareApisProvisioningState? ProvisioningState { get; }
        /// <summary> The access policies of the service instance. </summary>
        public IList<HealthcareApisServiceAccessPolicyEntry> AccessPolicies { get; }
        /// <summary> The settings for the Cosmos DB database backing the service. </summary>
        public HealthcareApisServiceCosmosDbConfiguration CosmosDbConfiguration { get; set; }
        /// <summary> The authentication configuration for the service instance. </summary>
        public HealthcareApisServiceAuthenticationConfiguration AuthenticationConfiguration { get; set; }
        /// <summary> The settings for the CORS configuration of the service instance. </summary>
        public HealthcareApisServiceCorsConfiguration CorsConfiguration { get; set; }
        /// <summary> The settings for the export operation of the service instance. </summary>
        internal ServiceExportConfigurationInfo ExportConfiguration { get; set; }
        /// <summary> The name of the default export storage account. </summary>
        public string ExportStorageAccountName
        {
            get => ExportConfiguration is null ? default : ExportConfiguration.StorageAccountName;
            set
            {
                if (ExportConfiguration is null)
                    ExportConfiguration = new ServiceExportConfigurationInfo();
                ExportConfiguration.StorageAccountName = value;
            }
        }

        /// <summary> The list of private endpoint connections that are set up for this resource. </summary>
        public IList<HealthcareApisPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary> Control permission for data plane traffic coming from public networks while private endpoint is enabled. </summary>
        public HealthcareApisPublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> The azure container registry settings used for convert data operation of the service instance. </summary>
        public HealthcareApisServiceAcrConfiguration AcrConfiguration { get; set; }
        /// <summary> The settings for the import operation of the service instance. </summary>
        public HealthcareApisServiceImportConfiguration ImportConfiguration { get; set; }
    }
}
