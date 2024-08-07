﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Dns
{
    using System.Collections;
    using System.Collections.Generic;
    using Microsoft.Azure.Management.Dns.Models;

    /// <summary>
    /// A DNS zone
    /// </summary>
    public class DnsZone
    {
        /// <summary>
        /// Gets or sets the name of the DNS zone.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the name of the resource group to which this zone belongs.
        /// </summary>
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// Gets or sets the Etag of this zone
        /// </summary>
        public string Etag { get; set; }

        /// <summary>
        /// Gets or sets the tags of this resource
        /// </summary>
        public Hashtable Tags { get; set; }

        /// <summary>
        /// Name servers provisioned for this zone
        /// </summary>
        public List<string> NameServers { get; set; }

        /// <summary>
        /// Type of this Zone
        /// </summary>
        public ZoneType? ZoneType { get; set; }

        /// <summary>
        /// Virtual Networks whose names will be registered on this zone
        /// </summary>
        public List<string> RegistrationVirtualNetworkIds { get; set; }

        /// <summary>
        /// Virtual Networks that will have this zone in their resolution scope
        /// </summary>
        public List<string> ResolutionVirtualNetworkIds { get; set; }

        /// <summary>
        /// Gets or sets the number of records for this zone
        /// </summary>
        public long? NumberOfRecordSets { get; set; }
        /// <summary>
        /// Gets or sets the max number of records for this zone
        /// </summary>
        public long? MaxNumberOfRecordSets { get; set; }

        /// <summary>
        /// Gets or sets the signing keys for this zone
        /// </summary>
        public List<SigningKey> SigningKeys { get; set; }
    }
}
