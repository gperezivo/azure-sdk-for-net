// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Information about the connection monitor.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ConnectionMonitorResult : IResource
    {
        /// <summary>
        /// Initializes a new instance of the ConnectionMonitorResult class.
        /// </summary>
        public ConnectionMonitorResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConnectionMonitorResult class.
        /// </summary>
        /// <param name="name">Name of the connection monitor.</param>
        /// <param name="id">ID of the connection monitor.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="type">Connection monitor type.</param>
        /// <param name="location">Connection monitor location.</param>
        /// <param name="tags">Connection monitor tags.</param>
        /// <param name="source">Describes the source of connection
        /// monitor.</param>
        /// <param name="destination">Describes the destination of connection
        /// monitor.</param>
        /// <param name="autoStart">Determines if the connection monitor will
        /// start automatically once created.</param>
        /// <param name="monitoringIntervalInSeconds">Monitoring interval in
        /// seconds.</param>
        /// <param name="endpoints">List of connection monitor
        /// endpoints.</param>
        /// <param name="testConfigurations">List of connection monitor test
        /// configurations.</param>
        /// <param name="testGroups">List of connection monitor test
        /// groups.</param>
        /// <param name="outputs">List of connection monitor outputs.</param>
        /// <param name="notes">Optional notes to be associated with the
        /// connection monitor.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// connection monitor. Possible values include: 'Succeeded',
        /// 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="startTime">The date and time when the connection
        /// monitor was started.</param>
        /// <param name="monitoringStatus">The monitoring status of the
        /// connection monitor.</param>
        /// <param name="connectionMonitorType">Type of connection monitor.
        /// Possible values include: 'MultiEndpoint',
        /// 'SingleSourceDestination'</param>
        public ConnectionMonitorResult(string name = default(string), string id = default(string), string etag = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), ConnectionMonitorSource source = default(ConnectionMonitorSource), ConnectionMonitorDestination destination = default(ConnectionMonitorDestination), bool? autoStart = default(bool?), int? monitoringIntervalInSeconds = default(int?), IList<ConnectionMonitorEndpoint> endpoints = default(IList<ConnectionMonitorEndpoint>), IList<ConnectionMonitorTestConfiguration> testConfigurations = default(IList<ConnectionMonitorTestConfiguration>), IList<ConnectionMonitorTestGroup> testGroups = default(IList<ConnectionMonitorTestGroup>), IList<ConnectionMonitorOutput> outputs = default(IList<ConnectionMonitorOutput>), string notes = default(string), string provisioningState = default(string), System.DateTime? startTime = default(System.DateTime?), string monitoringStatus = default(string), string connectionMonitorType = default(string))
        {
            Name = name;
            Id = id;
            Etag = etag;
            Type = type;
            Location = location;
            Tags = tags;
            Source = source;
            Destination = destination;
            AutoStart = autoStart;
            MonitoringIntervalInSeconds = monitoringIntervalInSeconds;
            Endpoints = endpoints;
            TestConfigurations = testConfigurations;
            TestGroups = testGroups;
            Outputs = outputs;
            Notes = notes;
            ProvisioningState = provisioningState;
            StartTime = startTime;
            MonitoringStatus = monitoringStatus;
            ConnectionMonitorType = connectionMonitorType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets name of the connection monitor.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets ID of the connection monitor.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Gets connection monitor type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets connection monitor location.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets connection monitor tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets describes the source of connection monitor.
        /// </summary>
        [JsonProperty(PropertyName = "properties.source")]
        public ConnectionMonitorSource Source { get; set; }

        /// <summary>
        /// Gets or sets describes the destination of connection monitor.
        /// </summary>
        [JsonProperty(PropertyName = "properties.destination")]
        public ConnectionMonitorDestination Destination { get; set; }

        /// <summary>
        /// Gets or sets determines if the connection monitor will start
        /// automatically once created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoStart")]
        public bool? AutoStart { get; set; }

        /// <summary>
        /// Gets or sets monitoring interval in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "properties.monitoringIntervalInSeconds")]
        public int? MonitoringIntervalInSeconds { get; set; }

        /// <summary>
        /// Gets or sets list of connection monitor endpoints.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endpoints")]
        public IList<ConnectionMonitorEndpoint> Endpoints { get; set; }

        /// <summary>
        /// Gets or sets list of connection monitor test configurations.
        /// </summary>
        [JsonProperty(PropertyName = "properties.testConfigurations")]
        public IList<ConnectionMonitorTestConfiguration> TestConfigurations { get; set; }

        /// <summary>
        /// Gets or sets list of connection monitor test groups.
        /// </summary>
        [JsonProperty(PropertyName = "properties.testGroups")]
        public IList<ConnectionMonitorTestGroup> TestGroups { get; set; }

        /// <summary>
        /// Gets or sets list of connection monitor outputs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.outputs")]
        public IList<ConnectionMonitorOutput> Outputs { get; set; }

        /// <summary>
        /// Gets or sets optional notes to be associated with the connection
        /// monitor.
        /// </summary>
        [JsonProperty(PropertyName = "properties.notes")]
        public string Notes { get; set; }

        /// <summary>
        /// Gets the provisioning state of the connection monitor. Possible
        /// values include: 'Succeeded', 'Updating', 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the date and time when the connection monitor was started.
        /// </summary>
        [JsonProperty(PropertyName = "properties.startTime")]
        public System.DateTime? StartTime { get; private set; }

        /// <summary>
        /// Gets the monitoring status of the connection monitor.
        /// </summary>
        [JsonProperty(PropertyName = "properties.monitoringStatus")]
        public string MonitoringStatus { get; private set; }

        /// <summary>
        /// Gets type of connection monitor. Possible values include:
        /// 'MultiEndpoint', 'SingleSourceDestination'
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectionMonitorType")]
        public string ConnectionMonitorType { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Source != null)
            {
                Source.Validate();
            }
            if (Destination != null)
            {
                Destination.Validate();
            }
            if (MonitoringIntervalInSeconds != null)
            {
                if (MonitoringIntervalInSeconds > 1800)
                {
                    throw new ValidationException(ValidationRules.InclusiveMaximum, "MonitoringIntervalInSeconds", 1800);
                }
                if (MonitoringIntervalInSeconds < 30)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "MonitoringIntervalInSeconds", 30);
                }
            }
            if (Endpoints != null)
            {
                foreach (var element in Endpoints)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (TestConfigurations != null)
            {
                foreach (var element1 in TestConfigurations)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (TestGroups != null)
            {
                foreach (var element2 in TestGroups)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
        }
    }
}
