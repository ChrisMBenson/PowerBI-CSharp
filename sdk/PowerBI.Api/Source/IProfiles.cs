// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Profiles operations.
    /// </summary>
    public partial interface IProfiles
    {
        /// <summary>
        /// Returns a list of service principal profiles for the organization.
        /// </summary>
        /// <remarks>
        ///
        /// ## Permissions
        ///
        /// The user must be a Fabric administrator or authenticate using a
        /// service principal.
        ///
        /// ## Required Scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        ///
        /// ## Limitations
        ///
        /// Maximum 200 requests per hour.
        /// </remarks>
        /// <param name='filter'>
        /// Filters the results based on a boolean condition, using 'id',
        /// 'displayName', or 'servicePrincipalId'. Supports only 'eq'
        /// operator.
        /// </param>
        /// <param name='top'>
        /// Returns only the first n results. This parameter must be in the
        /// range of 1-5000.
        /// </param>
        /// <param name='skip'>
        /// Skips the first n results. Use with top to fetch results beyond the
        /// first 5000.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<AdminServicePrincipalProfiles>> GetProfilesAsAdminWithHttpMessagesAsync(string filter = default(string), int? top = default(int?), int? skip = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the specified service principal profile.
        /// </summary>
        /// <remarks>
        ///
        /// ## Permissions
        ///
        /// The user must be a Fabric administrator.
        ///
        /// ## Required Scope
        ///
        /// Tenant.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        ///
        /// ## Limitations
        ///
        /// Maximum 200 requests per hour.
        /// </remarks>
        /// <param name='profileId'>
        /// The service principal profile ID
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse> DeleteProfileAsAdminWithHttpMessagesAsync(System.Guid profileId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of service principal profiles.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;Returns a list of profiles that belongs to service
        /// principal caller.
        ///
        /// ## Limitations
        ///
        /// Can only be called by a service principal.
        /// </remarks>
        /// <param name='top'>
        /// Returns only the first n results
        /// </param>
        /// <param name='skip'>
        /// Skips the first n results
        /// </param>
        /// <param name='filter'>
        /// Get a profile by DisplayName
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<ServicePrincipalProfiles>> GetProfilesWithHttpMessagesAsync(int? top = default(int?), int? skip = default(int?), string filter = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a new service principal profile.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;Creates a new profile that belongs to service principal
        /// caller.
        ///
        /// ## Limitations
        ///
        /// Can only be called by a service principal. The maximum number of
        /// profiles a single service principal can have, is 100,000.
        /// </remarks>
        /// <param name='createOrUpdateProfileRequest'>
        /// The create profile request
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<ServicePrincipalProfile>> CreateProfileWithHttpMessagesAsync(CreateOrUpdateProfileRequest createOrUpdateProfileRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the specified service principal profile.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;Returns the specified profile if it exists and belongs
        /// to service principal caller.
        ///
        /// ## Limitations
        ///
        /// Can only be called by a service principal.
        /// </remarks>
        /// <param name='profileId'>
        /// The service principal profile ID
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<ServicePrincipalProfile>> GetProfileWithHttpMessagesAsync(System.Guid profileId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the specified service principal profile name.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;Updates the specified profile name if it exists and
        /// belongs to service principal caller.
        ///
        /// ## Limitations
        ///
        /// Can only be called by a service principal.
        /// </remarks>
        /// <param name='profileId'>
        /// The service principal profile ID
        /// </param>
        /// <param name='createOrUpdateProfileRequest'>
        /// The update profile request
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<ServicePrincipalProfile>> UpdateProfileWithHttpMessagesAsync(System.Guid profileId, CreateOrUpdateProfileRequest createOrUpdateProfileRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the specified service principal profile.
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;Deletes the specified profile if it exists and belongs
        /// to service principal caller.
        ///
        /// ## Limitations
        ///
        /// Can only be called by a service principal.
        /// </remarks>
        /// <param name='profileId'>
        /// The service principal profile ID
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        Task<HttpOperationResponse> DeleteProfileWithHttpMessagesAsync(System.Guid profileId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
