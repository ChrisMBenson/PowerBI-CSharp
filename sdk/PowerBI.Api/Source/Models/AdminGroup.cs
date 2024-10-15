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
    /// A Power BI group returned by admin APIs
    /// </summary>
    public partial class AdminGroup
    {
        /// <summary>
        /// Initializes a new instance of the AdminGroup class.
        /// </summary>
        public AdminGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AdminGroup class.
        /// </summary>
        /// <param name="id">The workspace ID</param>
        /// <param name="name">The group name</param>
        /// <param name="isReadOnly">Whether the group is read-only</param>
        /// <param name="isOnDedicatedCapacity">Whether the group is assigned
        /// to a dedicated capacity</param>
        /// <param name="capacityId">The capacity ID</param>
        /// <param name="dataflowStorageId">The Power BI dataflow storage
        /// account ID</param>
        /// <param name="defaultDatasetStorageFormat">The default dataset
        /// storage format in the workspace. Returned only when
        /// `isOnDedicatedCapacity` is `true`. Possible values include:
        /// 'Small', 'Large'</param>
        /// <param name="logAnalyticsWorkspace">The Log Analytics workspace
        /// assigned to the group.  This is returned only when retrieving a
        /// single group.</param>
        /// <param name="description">The group description</param>
        /// <param name="type">The type of group being returned. Possible
        /// values include: 'PersonalGroup', 'Personal', 'Workspace',
        /// 'Group'</param>
        /// <param name="state">The group state</param>
        /// <param name="users">(Empty value) The users that belong to the
        /// group and their access rights. This property will be removed from
        /// the payload response in an upcoming release. You can retrieve user
        /// information on a Power BI item (such as a report or a dashboard) by
        /// using the [Get Group Users As
        /// Admin](/rest/api/power-bi/admin/groups-get-group-users-as-admin)
        /// API call, or the
        /// [PostWorkspaceInfo](/rest/api/power-bi/admin/workspace-info-post-workspace-info)
        /// API call with the `getArtifactUsers` parameter.</param>
        /// <param name="reports">The reports that belong to the group</param>
        /// <param name="dashboards">The dashboards that belong to the
        /// group</param>
        /// <param name="datasets">The datasets that belong to the
        /// group</param>
        /// <param name="dataflows">The dataflows that belong to the
        /// group</param>
        /// <param name="workbooks">The workbooks that belong to the
        /// group</param>
        /// <param name="pipelineId">The deployment pipeline ID that the
        /// workspace is assigned to.</param>
        /// <param name="hasWorkspaceLevelSettings">Whether the workspace has
        /// custom settings</param>
        public AdminGroup(System.Guid id, string name = default(string), bool? isReadOnly = default(bool?), bool? isOnDedicatedCapacity = default(bool?), System.Guid? capacityId = default(System.Guid?), System.Guid? dataflowStorageId = default(System.Guid?), string defaultDatasetStorageFormat = default(string), AzureResource logAnalyticsWorkspace = default(AzureResource), string description = default(string), GroupType? type = default(GroupType?), string state = default(string), IList<GroupUser> users = default(IList<GroupUser>), IList<AdminReport> reports = default(IList<AdminReport>), IList<AdminDashboard> dashboards = default(IList<AdminDashboard>), IList<AdminDataset> datasets = default(IList<AdminDataset>), IList<AdminDataflow> dataflows = default(IList<AdminDataflow>), IList<Workbook> workbooks = default(IList<Workbook>), System.Guid? pipelineId = default(System.Guid?), bool? hasWorkspaceLevelSettings = default(bool?))
        {
            Id = id;
            Name = name;
            IsReadOnly = isReadOnly;
            IsOnDedicatedCapacity = isOnDedicatedCapacity;
            CapacityId = capacityId;
            DataflowStorageId = dataflowStorageId;
            DefaultDatasetStorageFormat = defaultDatasetStorageFormat;
            LogAnalyticsWorkspace = logAnalyticsWorkspace;
            Description = description;
            Type = type;
            State = state;
            Users = users;
            Reports = reports;
            Dashboards = dashboards;
            Datasets = datasets;
            Dataflows = dataflows;
            Workbooks = workbooks;
            PipelineId = pipelineId;
            HasWorkspaceLevelSettings = hasWorkspaceLevelSettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the workspace ID
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the group name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets whether the group is read-only
        /// </summary>
        [JsonProperty(PropertyName = "isReadOnly")]
        public bool? IsReadOnly { get; set; }

        /// <summary>
        /// Gets or sets whether the group is assigned to a dedicated capacity
        /// </summary>
        [JsonProperty(PropertyName = "isOnDedicatedCapacity")]
        public bool? IsOnDedicatedCapacity { get; set; }

        /// <summary>
        /// Gets or sets the capacity ID
        /// </summary>
        [JsonProperty(PropertyName = "capacityId")]
        public System.Guid? CapacityId { get; set; }

        /// <summary>
        /// Gets or sets the Power BI dataflow storage account ID
        /// </summary>
        [JsonProperty(PropertyName = "dataflowStorageId")]
        public System.Guid? DataflowStorageId { get; set; }

        /// <summary>
        /// Gets or sets the default dataset storage format in the workspace.
        /// Returned only when `isOnDedicatedCapacity` is `true`. Possible
        /// values include: 'Small', 'Large'
        /// </summary>
        [JsonProperty(PropertyName = "defaultDatasetStorageFormat")]
        public string DefaultDatasetStorageFormat { get; set; }

        /// <summary>
        /// Gets or sets the Log Analytics workspace assigned to the group.
        /// This is returned only when retrieving a single group.
        /// </summary>
        [JsonProperty(PropertyName = "logAnalyticsWorkspace")]
        public AzureResource LogAnalyticsWorkspace { get; set; }

        /// <summary>
        /// Gets or sets the group description
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the type of group being returned. Possible values
        /// include: 'PersonalGroup', 'Personal', 'Workspace', 'Group'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public GroupType? Type { get; set; }

        /// <summary>
        /// Gets or sets the group state
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets (Empty value) The users that belong to the group and
        /// their access rights. This property will be removed from the payload
        /// response in an upcoming release. You can retrieve user information
        /// on a Power BI item (such as a report or a dashboard) by using the
        /// [Get Group Users As
        /// Admin](/rest/api/power-bi/admin/groups-get-group-users-as-admin)
        /// API call, or the
        /// [PostWorkspaceInfo](/rest/api/power-bi/admin/workspace-info-post-workspace-info)
        /// API call with the `getArtifactUsers` parameter.
        /// </summary>
        [JsonProperty(PropertyName = "users")]
        public IList<GroupUser> Users { get; set; }

        /// <summary>
        /// Gets or sets the reports that belong to the group
        /// </summary>
        [JsonProperty(PropertyName = "reports")]
        public IList<AdminReport> Reports { get; set; }

        /// <summary>
        /// Gets or sets the dashboards that belong to the group
        /// </summary>
        [JsonProperty(PropertyName = "dashboards")]
        public IList<AdminDashboard> Dashboards { get; set; }

        /// <summary>
        /// Gets or sets the datasets that belong to the group
        /// </summary>
        [JsonProperty(PropertyName = "datasets")]
        public IList<AdminDataset> Datasets { get; set; }

        /// <summary>
        /// Gets or sets the dataflows that belong to the group
        /// </summary>
        [JsonProperty(PropertyName = "dataflows")]
        public IList<AdminDataflow> Dataflows { get; set; }

        /// <summary>
        /// Gets or sets the workbooks that belong to the group
        /// </summary>
        [JsonProperty(PropertyName = "workbooks")]
        public IList<Workbook> Workbooks { get; set; }

        /// <summary>
        /// Gets or sets the deployment pipeline ID that the workspace is
        /// assigned to.
        /// </summary>
        [JsonProperty(PropertyName = "pipelineId")]
        public System.Guid? PipelineId { get; set; }

        /// <summary>
        /// Gets or sets whether the workspace has custom settings
        /// </summary>
        [JsonProperty(PropertyName = "hasWorkspaceLevelSettings")]
        public bool? HasWorkspaceLevelSettings { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (LogAnalyticsWorkspace != null)
            {
                LogAnalyticsWorkspace.Validate();
            }
            if (Users != null)
            {
                foreach (var element in Users)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Reports != null)
            {
                foreach (var element1 in Reports)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (Dashboards != null)
            {
                foreach (var element2 in Dashboards)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
            if (Datasets != null)
            {
                foreach (var element3 in Datasets)
                {
                    if (element3 != null)
                    {
                        element3.Validate();
                    }
                }
            }
            if (Dataflows != null)
            {
                foreach (var element4 in Dataflows)
                {
                    if (element4 != null)
                    {
                        element4.Validate();
                    }
                }
            }
        }
    }
}