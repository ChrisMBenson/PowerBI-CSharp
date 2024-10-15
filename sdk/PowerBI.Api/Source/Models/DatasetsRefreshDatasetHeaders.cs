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
    /// Defines headers for RefreshDataset operation.
    /// </summary>
    public partial class DatasetsRefreshDatasetHeaders
    {
        /// <summary>
        /// Initializes a new instance of the DatasetsRefreshDatasetHeaders
        /// class.
        /// </summary>
        public DatasetsRefreshDatasetHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatasetsRefreshDatasetHeaders
        /// class.
        /// </summary>
        /// <param name="xMsRequestId">The `refreshId` for [getting refresh
        /// execution
        /// details](#/operationId/Datasets_GetRefreshExecutionDetails) or
        /// [cancelling refresh](/rest/api/power-bi/datasets/cancel-refresh).
        /// This would be returned only if any request payload except
        /// `notifyOption` is set.</param>
        /// <param name="location">The full URI for [getting refresh execution
        /// details](#/operationId/Datasets_GetRefreshExecutionDetails) or
        /// [cancelling refresh](/rest/api/power-bi/datasets/cancel-refresh).
        /// This would be returned only if any request payload except
        /// `notifyOption` is set.</param>
        public DatasetsRefreshDatasetHeaders(System.Guid? xMsRequestId = default(System.Guid?), string location = default(string))
        {
            XMsRequestId = xMsRequestId;
            Location = location;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the `refreshId` for [getting refresh execution
        /// details](#/operationId/Datasets_GetRefreshExecutionDetails) or
        /// [cancelling refresh](/rest/api/power-bi/datasets/cancel-refresh).
        /// This would be returned only if any request payload except
        /// `notifyOption` is set.
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-request-id")]
        public System.Guid? XMsRequestId { get; set; }

        /// <summary>
        /// Gets or sets the full URI for [getting refresh execution
        /// details](#/operationId/Datasets_GetRefreshExecutionDetails) or
        /// [cancelling refresh](/rest/api/power-bi/datasets/cancel-refresh).
        /// This would be returned only if any request payload except
        /// `notifyOption` is set.
        /// </summary>
        [JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

    }
}