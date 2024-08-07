// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using System.Linq;

    /// <summary>
    /// Properties for a CDC table.
    /// </summary>
    public partial class MapperTableProperties
    {
        /// <summary>
        /// Initializes a new instance of the MapperTableProperties class.
        /// </summary>
        public MapperTableProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MapperTableProperties class.
        /// </summary>

        /// <param name="schema">List of columns for the source table.
        /// </param>

        /// <param name="dslConnectorProperties">List of name/value pairs for connection properties.
        /// </param>
        public MapperTableProperties(System.Collections.Generic.IList<MapperTableSchema> schema = default(System.Collections.Generic.IList<MapperTableSchema>), System.Collections.Generic.IList<MapperDslConnectorProperties> dslConnectorProperties = default(System.Collections.Generic.IList<MapperDslConnectorProperties>))

        {
            this.Schema = schema;
            this.DslConnectorProperties = dslConnectorProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets list of columns for the source table.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "schema")]
        public System.Collections.Generic.IList<MapperTableSchema> Schema {get; set; }

        /// <summary>
        /// Gets or sets list of name/value pairs for connection properties.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "dslConnectorProperties")]
        public System.Collections.Generic.IList<MapperDslConnectorProperties> DslConnectorProperties {get; set; }
    }
}