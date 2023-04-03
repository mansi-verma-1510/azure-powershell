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
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Outbound rule of the load balancer.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class OutboundRule : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the OutboundRule class.
        /// </summary>
        public OutboundRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OutboundRule class.
        /// </summary>
        /// <param name="frontendIPConfigurations">The Frontend IP addresses of
        /// the load balancer.</param>
        /// <param name="backendAddressPool">A reference to a pool of DIPs.
        /// Outbound traffic is randomly load balanced across IPs in the
        /// backend IPs.</param>
        /// <param name="protocol">The protocol for the outbound rule in load
        /// balancer. Possible values include: 'Tcp', 'Udp', 'All'</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="allocatedOutboundPorts">The number of outbound ports
        /// to be used for NAT.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// outbound rule resource. Possible values include: 'Succeeded',
        /// 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="enableTcpReset">Receive bidirectional TCP Reset on TCP
        /// flow idle timeout or unexpected connection termination. This
        /// element is only used when the protocol is set to TCP.</param>
        /// <param name="idleTimeoutInMinutes">The timeout for the TCP idle
        /// connection.</param>
        /// <param name="name">The name of the resource that is unique within
        /// the set of outbound rules used by the load balancer. This name can
        /// be used to access the resource.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="type">Type of the resource.</param>
        public OutboundRule(IList<SubResource> frontendIPConfigurations, SubResource backendAddressPool, string protocol, string id = default(string), int? allocatedOutboundPorts = default(int?), string provisioningState = default(string), bool? enableTcpReset = default(bool?), int? idleTimeoutInMinutes = default(int?), string name = default(string), string etag = default(string), string type = default(string))
            : base(id)
        {
            AllocatedOutboundPorts = allocatedOutboundPorts;
            FrontendIPConfigurations = frontendIPConfigurations;
            BackendAddressPool = backendAddressPool;
            ProvisioningState = provisioningState;
            Protocol = protocol;
            EnableTcpReset = enableTcpReset;
            IdleTimeoutInMinutes = idleTimeoutInMinutes;
            Name = name;
            Etag = etag;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the number of outbound ports to be used for NAT.
        /// </summary>
        [JsonProperty(PropertyName = "properties.allocatedOutboundPorts")]
        public int? AllocatedOutboundPorts { get; set; }

        /// <summary>
        /// Gets or sets the Frontend IP addresses of the load balancer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.frontendIPConfigurations")]
        public IList<SubResource> FrontendIPConfigurations { get; set; }

        /// <summary>
        /// Gets or sets a reference to a pool of DIPs. Outbound traffic is
        /// randomly load balanced across IPs in the backend IPs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.backendAddressPool")]
        public SubResource BackendAddressPool { get; set; }

        /// <summary>
        /// Gets the provisioning state of the outbound rule resource. Possible
        /// values include: 'Succeeded', 'Updating', 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the protocol for the outbound rule in load balancer.
        /// Possible values include: 'Tcp', 'Udp', 'All'
        /// </summary>
        [JsonProperty(PropertyName = "properties.protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or sets receive bidirectional TCP Reset on TCP flow idle
        /// timeout or unexpected connection termination. This element is only
        /// used when the protocol is set to TCP.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableTcpReset")]
        public bool? EnableTcpReset { get; set; }

        /// <summary>
        /// Gets or sets the timeout for the TCP idle connection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.idleTimeoutInMinutes")]
        public int? IdleTimeoutInMinutes { get; set; }

        /// <summary>
        /// Gets or sets the name of the resource that is unique within the set
        /// of outbound rules used by the load balancer. This name can be used
        /// to access the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Gets type of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (FrontendIPConfigurations == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FrontendIPConfigurations");
            }
            if (BackendAddressPool == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "BackendAddressPool");
            }
            if (Protocol == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Protocol");
            }
        }
    }
}
