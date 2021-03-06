// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The swagger external documentation
    /// </summary>
    public partial class SwaggerExternalDocumentation
    {
        /// <summary>
        /// Initializes a new instance of the SwaggerExternalDocumentation
        /// class.
        /// </summary>
        public SwaggerExternalDocumentation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SwaggerExternalDocumentation
        /// class.
        /// </summary>
        /// <param name="description">The document description.</param>
        /// <param name="uri">The documentation Uri.</param>
        /// <param name="extensions">The vendor extensions.</param>
        public SwaggerExternalDocumentation(string description = default(string), string uri = default(string), IDictionary<string, object> extensions = default(IDictionary<string, object>))
        {
            Description = description;
            Uri = uri;
            Extensions = extensions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the document description.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the documentation Uri.
        /// </summary>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or sets the vendor extensions.
        /// </summary>
        [JsonProperty(PropertyName = "extensions")]
        public IDictionary<string, object> Extensions { get; set; }

    }
}
