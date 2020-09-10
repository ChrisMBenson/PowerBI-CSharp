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
    /// The workspace object for Generate Token Request V2.
    /// </summary>
    public partial class GenerateTokenRequestV2TargetWorkspace
    {
        /// <summary>
        /// Initializes a new instance of the
        /// GenerateTokenRequestV2TargetWorkspace class.
        /// </summary>
        public GenerateTokenRequestV2TargetWorkspace()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// GenerateTokenRequestV2TargetWorkspace class.
        /// </summary>
        /// <param name="id">Workspace Id</param>
        public GenerateTokenRequestV2TargetWorkspace(System.Guid id)
        {
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets workspace Id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}