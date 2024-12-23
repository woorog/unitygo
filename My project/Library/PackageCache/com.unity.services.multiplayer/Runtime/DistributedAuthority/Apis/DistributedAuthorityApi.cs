//-----------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by the C# SDK Code Generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------


using System.Threading.Tasks;
using System.Collections.Generic;
using Unity.Services.DistributedAuthority.Models;
using Unity.Services.DistributedAuthority.Http;
using Unity.Services.Authentication.Internal;
using Unity.Services.DistributedAuthority.DistributedAuthority;

namespace Unity.Services.DistributedAuthority.Apis.DistributedAuthority
{
    /// <summary>
    /// Interface for the DistributedAuthorityApiClient
    /// </summary>
    internal interface IDistributedAuthorityApiClient
    {
            /// <summary>
            /// Async Operation.
            /// Create new session.
            /// </summary>
            /// <param name="request">Request object for CreateSession.</param>
            /// <param name="operationConfiguration">Configuration for CreateSession.</param>
            /// <returns>Task for a Response object containing status code, headers, and Models.Session object.</returns>
            /// <exception cref="Unity.Services.DistributedAuthority.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<Models.Session>> CreateSessionAsync(Unity.Services.DistributedAuthority.DistributedAuthority.CreateSessionRequest request, Configuration operationConfiguration = null);

    }

    ///<inheritdoc cref="IDistributedAuthorityApiClient"/>
    internal class DistributedAuthorityApiClient : BaseApiClient, IDistributedAuthorityApiClient
    {
        private IAccessToken _accessToken;
        private const int _baseTimeout = 10;
        private Configuration _configuration;
        /// <summary>
        /// Accessor for the client configuration object. This returns a merge
        /// between the current configuration and the global configuration to
        /// ensure the correct combination of headers and a base path (if it is
        /// set) are returned.
        /// </summary>
        public Configuration Configuration
        {
            get {
                // We return a merge between the current configuration and the
                // global configuration to ensure we have the correct
                // combination of headers and a base path (if it is set).
                Configuration globalConfiguration = new Configuration("http://localhost:3000", 10, 4, null);
                return Configuration.MergeConfigurations(_configuration, globalConfiguration);
            }
            set { _configuration = value; }
        }

        /// <summary>
        /// DistributedAuthorityApiClient Constructor.
        /// </summary>
        /// <param name="httpClient">The HttpClient for DistributedAuthorityApiClient.</param>
        /// <param name="accessToken">The Authentication token for the client.</param>
        /// <param name="configuration"> DistributedAuthorityApiClient Configuration object.</param>
        public DistributedAuthorityApiClient(IHttpClient httpClient,
            IAccessToken accessToken,
            Configuration configuration = null) : base(httpClient)
        {
            // We don't need to worry about the configuration being null at
            // this stage, we will check this in the accessor.
            _configuration = configuration;

            _accessToken = accessToken;
        }


        /// <summary>
        /// Async Operation.
        /// Create new session.
        /// </summary>
        /// <param name="request">Request object for CreateSession.</param>
        /// <param name="operationConfiguration">Configuration for CreateSession.</param>
        /// <returns>Task for a Response object containing status code, headers, and Models.Session object.</returns>
        /// <exception cref="Unity.Services.DistributedAuthority.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<Models.Session>> CreateSessionAsync(Unity.Services.DistributedAuthority.DistributedAuthority.CreateSessionRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(Models.Session)   },{"400", typeof(Models.ErrorResponseBody)   },{"401", typeof(Models.ErrorResponseBody)   },{"404", typeof(Models.ErrorResponseBody)   },{"409", typeof(Models.ErrorResponseBody)   },{"500", typeof(Models.ErrorResponseBody)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("POST",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(_accessToken, finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<Models.Session>(response, statusCodeToTypeMap);
            return new Response<Models.Session>(response, handledResponse);
        }

    }
}
