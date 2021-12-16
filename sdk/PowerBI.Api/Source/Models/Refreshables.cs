// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A Power BI refreshables list
    /// </summary>
    public partial class Refreshables
    {
        /// <summary>
        /// Initializes a new instance of the Refreshables class.
        /// </summary>
        public Refreshables()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Refreshables class.
        /// </summary>
        /// <param name="odatacontext">OData context</param>
        /// <param name="value">The refreshables</param>
        public Refreshables(string odatacontext = default(string), IList<Refreshable> value = default(IList<Refreshable>))
        {
            Odatacontext = odatacontext;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets oData context
        /// </summary>
        [JsonProperty(PropertyName = "odata.context")]
        public string Odatacontext { get; set; }

        /// <summary>
        /// Gets or sets the refreshables
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<Refreshable> Value { get; set; }

    }
}
