// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor
{
    internal class ServiceCreateAnomalyDetectionConfigurationHeaders
    {
        private readonly Response _response;
        public ServiceCreateAnomalyDetectionConfigurationHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> Location of the newly created resource. </summary>
        public string Location => _response.Headers.TryGetValue("Location", out string value) ? value : null;
    }
}
