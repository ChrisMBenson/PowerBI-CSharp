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
    /// The results from a single dataset query
    /// </summary>
    public partial class DatasetExecuteQueriesQueryResult
    {
        /// <summary>
        /// Initializes a new instance of the DatasetExecuteQueriesQueryResult
        /// class.
        /// </summary>
        public DatasetExecuteQueriesQueryResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatasetExecuteQueriesQueryResult
        /// class.
        /// </summary>
        /// <param name="tables">A list of tables data for a query</param>
        /// <param name="error">The details of an error, if present.</param>
        public DatasetExecuteQueriesQueryResult(IList<DatasetExecuteQueriesTableResult> tables = default(IList<DatasetExecuteQueriesTableResult>), DatasetExecuteQueriesError error = default(DatasetExecuteQueriesError))
        {
            Tables = tables;
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a list of tables data for a query
        /// </summary>
        [JsonProperty(PropertyName = "tables")]
        public IList<DatasetExecuteQueriesTableResult> Tables { get; set; }

        /// <summary>
        /// Gets or sets the details of an error, if present.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public DatasetExecuteQueriesError Error { get; set; }

    }
}