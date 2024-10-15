// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class TileBaseProperties
    {
        /// <summary>
        /// Initializes a new instance of the TileBaseProperties class.
        /// </summary>
        public TileBaseProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TileBaseProperties class.
        /// </summary>
        /// <param name="id">The tile ID</param>
        /// <param name="title">The display name of the tile </param>
        /// <param name="reportId">The report ID. Available only for tiles
        /// created from a report.</param>
        /// <param name="datasetId">The dataset ID. Available only for tiles
        /// created from a report or by using a dataset, such as Q&amp;A
        /// tiles.</param>
        public TileBaseProperties(System.Guid id, string title = default(string), System.Guid? reportId = default(System.Guid?), string datasetId = default(string))
        {
            Id = id;
            Title = title;
            ReportId = reportId;
            DatasetId = datasetId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the tile ID
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the display name of the tile
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the report ID. Available only for tiles created from a
        /// report.
        /// </summary>
        [JsonProperty(PropertyName = "reportId")]
        public System.Guid? ReportId { get; set; }

        /// <summary>
        /// Gets or sets the dataset ID. Available only for tiles created from
        /// a report or by using a dataset, such as Q&amp;amp;A tiles.
        /// </summary>
        [JsonProperty(PropertyName = "datasetId")]
        public string DatasetId { get; set; }

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