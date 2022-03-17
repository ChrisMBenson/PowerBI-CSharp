// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A Power BI service principal profile create or update request
    /// </summary>
    public partial class CreateOrUpdateProfileRequest
    {
        /// <summary>
        /// Initializes a new instance of the CreateOrUpdateProfileRequest
        /// class.
        /// </summary>
        public CreateOrUpdateProfileRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreateOrUpdateProfileRequest
        /// class.
        /// </summary>
        /// <param name="displayName">The service principal profile
        /// name</param>
        public CreateOrUpdateProfileRequest(string displayName = default(string))
        {
            DisplayName = displayName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the service principal profile name
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

    }
}
