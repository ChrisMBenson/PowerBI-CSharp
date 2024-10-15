// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for WidelySharedArtifacts.
    /// </summary>
    public static partial class WidelySharedArtifactsExtensions
    {
            /// <summary>
            /// Returns a list of Power BI reports that are shared with the whole
            /// organization through links.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// - The user must be a Fabric administrator or authenticate using a service
            /// principal.
            /// - Delegated permissions are supported.
            ///
            /// ## Required Scope
            ///
            /// Tenant.Read.All or Tenant.ReadWrite.All
            ///
            /// ## Limitations
            ///
            /// Maximum 200 requests per hour.
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='continuationToken'>
            /// Token required to get the next chunk of the result set
            /// </param>
            public static ArtifactAccessResponse LinksSharedToWholeOrganization(this IWidelySharedArtifacts operations, string continuationToken = default(string))
            {
                return operations.LinksSharedToWholeOrganizationAsync(continuationToken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of Power BI reports that are shared with the whole
            /// organization through links.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// - The user must be a Fabric administrator or authenticate using a service
            /// principal.
            /// - Delegated permissions are supported.
            ///
            /// ## Required Scope
            ///
            /// Tenant.Read.All or Tenant.ReadWrite.All
            ///
            /// ## Limitations
            ///
            /// Maximum 200 requests per hour.
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='continuationToken'>
            /// Token required to get the next chunk of the result set
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ArtifactAccessResponse> LinksSharedToWholeOrganizationAsync(this IWidelySharedArtifacts operations, string continuationToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.LinksSharedToWholeOrganizationWithHttpMessagesAsync(continuationToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of Power BI items (such as reports or dashboards) that are
            /// published to the web.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// - The user must be a Fabric administrator or authenticate using a service
            /// principal.
            /// - Delegated permissions are supported.
            ///
            /// ## Required Scope
            ///
            /// Tenant.Read.All or Tenant.ReadWrite.All
            ///
            /// ## Limitations
            ///
            /// Maximum 200 requests per hour.
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='continuationToken'>
            /// Token required to get the next chunk of the result set
            /// </param>
            public static ArtifactAccessResponse PublishedToWeb(this IWidelySharedArtifacts operations, string continuationToken = default(string))
            {
                return operations.PublishedToWebAsync(continuationToken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of Power BI items (such as reports or dashboards) that are
            /// published to the web.
            /// </summary>
            /// <remarks>
            ///
            /// ## Permissions
            ///
            /// - The user must be a Fabric administrator or authenticate using a service
            /// principal.
            /// - Delegated permissions are supported.
            ///
            /// ## Required Scope
            ///
            /// Tenant.Read.All or Tenant.ReadWrite.All
            ///
            /// ## Limitations
            ///
            /// Maximum 200 requests per hour.
            /// &lt;br&gt;&lt;br&gt;
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='continuationToken'>
            /// Token required to get the next chunk of the result set
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ArtifactAccessResponse> PublishedToWebAsync(this IWidelySharedArtifacts operations, string continuationToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PublishedToWebWithHttpMessagesAsync(continuationToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}