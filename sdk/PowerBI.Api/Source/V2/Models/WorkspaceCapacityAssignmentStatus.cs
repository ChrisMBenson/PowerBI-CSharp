// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.V2.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Power BI workspace assignment status to capacity response
    /// </summary>
    public partial class WorkspaceCapacityAssignmentStatus
    {
        /// <summary>
        /// Initializes a new instance of the WorkspaceCapacityAssignmentStatus
        /// class.
        /// </summary>
        public WorkspaceCapacityAssignmentStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkspaceCapacityAssignmentStatus
        /// class.
        /// </summary>
        /// <param name="status">Workspace assignment status. Possible values
        /// include: 'Pending', 'InProgress', 'CompletedSuccessfully',
        /// 'AssignmentFailed'</param>
        /// <param name="startTime">Start time of workspace assignment
        /// operation</param>
        /// <param name="endTime">End time of workspace assignment
        /// operation</param>
        /// <param name="capacityId">The capacity id</param>
        /// <param name="activityId">The activity id of the acctual assignment
        /// operation, can be provided in case of assignment failures</param>
        public WorkspaceCapacityAssignmentStatus(AssignmentStatus? status = default(AssignmentStatus?), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), string capacityId = default(string), string activityId = default(string))
        {
            Status = status;
            StartTime = startTime;
            EndTime = endTime;
            CapacityId = capacityId;
            ActivityId = activityId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets workspace assignment status. Possible values include:
        /// 'Pending', 'InProgress', 'CompletedSuccessfully',
        /// 'AssignmentFailed'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public AssignmentStatus? Status { get; set; }

        /// <summary>
        /// Gets or sets start time of workspace assignment operation
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets end time of workspace assignment operation
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets the capacity id
        /// </summary>
        [JsonProperty(PropertyName = "capacityId")]
        public string CapacityId { get; set; }

        /// <summary>
        /// Gets or sets the activity id of the acctual assignment operation,
        /// can be provided in case of assignment failures
        /// </summary>
        [JsonProperty(PropertyName = "activityId")]
        public string ActivityId { get; set; }

    }
}
