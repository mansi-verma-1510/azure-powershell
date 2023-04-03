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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The routes table associated with the ExpressRouteCircuit.
    /// </summary>
    public partial class ExpressRouteCrossConnectionRoutesTableSummary
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ExpressRouteCrossConnectionRoutesTableSummary class.
        /// </summary>
        public ExpressRouteCrossConnectionRoutesTableSummary()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ExpressRouteCrossConnectionRoutesTableSummary class.
        /// </summary>
        /// <param name="neighbor">IP address of Neighbor router.</param>
        /// <param name="asn">Autonomous system number.</param>
        /// <param name="upDown">The length of time that the BGP session has
        /// been in the Established state, or the current status if not in the
        /// Established state.</param>
        /// <param name="stateOrPrefixesReceived">Current state of the BGP
        /// session, and the number of prefixes that have been received from a
        /// neighbor or peer group.</param>
        public ExpressRouteCrossConnectionRoutesTableSummary(string neighbor = default(string), int? asn = default(int?), string upDown = default(string), string stateOrPrefixesReceived = default(string))
        {
            Neighbor = neighbor;
            Asn = asn;
            UpDown = upDown;
            StateOrPrefixesReceived = stateOrPrefixesReceived;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets IP address of Neighbor router.
        /// </summary>
        [JsonProperty(PropertyName = "neighbor")]
        public string Neighbor { get; set; }

        /// <summary>
        /// Gets or sets autonomous system number.
        /// </summary>
        [JsonProperty(PropertyName = "asn")]
        public int? Asn { get; set; }

        /// <summary>
        /// Gets or sets the length of time that the BGP session has been in
        /// the Established state, or the current status if not in the
        /// Established state.
        /// </summary>
        [JsonProperty(PropertyName = "upDown")]
        public string UpDown { get; set; }

        /// <summary>
        /// Gets or sets current state of the BGP session, and the number of
        /// prefixes that have been received from a neighbor or peer group.
        /// </summary>
        [JsonProperty(PropertyName = "stateOrPrefixesReceived")]
        public string StateOrPrefixesReceived { get; set; }

    }
}
