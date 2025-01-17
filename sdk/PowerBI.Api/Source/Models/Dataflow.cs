// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The metadata of a dataflow. Below is a list of properties that may be
    /// returned for a dataflow. Only a subset of the properties will be
    /// returned depending on the API called, the caller permissions and the
    /// availability of the data in the Power BI database.
    /// </summary>
    public partial class Dataflow : DataflowBaseProperties
    {
        /// <summary>
        /// Initializes a new instance of the Dataflow class.
        /// </summary>
        public Dataflow()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Dataflow class.
        /// </summary>
        /// <param name="objectId">The dataflow ID</param>
        /// <param name="name">The dataflow name</param>
        /// <param name="description">The dataflow description</param>
        /// <param name="modelUrl">A URL to the dataflow definition file
        /// (model.json)</param>
        /// <param name="configuredBy">The dataflow owner</param>
        /// <param name="users">(Empty value) The dataflow user access details.
        /// This property will be removed from the payload response in an
        /// upcoming release. You can retrieve user information on a Power BI
        /// dataflow by using the [Get Dataflow Users as
        /// Admin](/rest/api/power-bi/admin/dataflows-get-dataflow-users-as-admin)
        /// API call, or the
        /// [PostWorkspaceInfo](/rest/api/power-bi/admin/workspace-info-post-workspace-info)
        /// API call with the `getArtifactUser` parameter.</param>
        public Dataflow(System.Guid objectId, string name = default(string), string description = default(string), string modelUrl = default(string), string configuredBy = default(string), IList<DataflowUser> users = default(IList<DataflowUser>))
            : base(objectId, name, description, modelUrl, configuredBy, users)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
