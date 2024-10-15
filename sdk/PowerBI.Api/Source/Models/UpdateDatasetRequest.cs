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
    /// Update dataset request
    /// </summary>
    public partial class UpdateDatasetRequest
    {
        /// <summary>
        /// Initializes a new instance of the UpdateDatasetRequest class.
        /// </summary>
        public UpdateDatasetRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdateDatasetRequest class.
        /// </summary>
        /// <param name="targetStorageMode">The dataset storage mode</param>
        public UpdateDatasetRequest(string targetStorageMode = default(string), DatasetQueryScaleOutSettings queryScaleOutSettings = default(DatasetQueryScaleOutSettings))
        {
            TargetStorageMode = targetStorageMode;
            QueryScaleOutSettings = queryScaleOutSettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the dataset storage mode
        /// </summary>
        [JsonProperty(PropertyName = "targetStorageMode")]
        public string TargetStorageMode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "queryScaleOutSettings")]
        public DatasetQueryScaleOutSettings QueryScaleOutSettings { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (QueryScaleOutSettings != null)
            {
                QueryScaleOutSettings.Validate();
            }
        }
    }
}