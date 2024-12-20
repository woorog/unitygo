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
using Unity.Services.Matchmaker.Models;
using Unity.Services.Matchmaker.Http;
using Unity.Services.Authentication.Internal;
using Unity.Services.Matchmaker.Matches;

namespace Unity.Services.Matchmaker.Apis.Matches
{
    /// <summary>
    /// Interface for the MatchesApiClient
    /// </summary>
    internal interface IMatchesApiClient
    {
            /// <summary>
            /// Async Operation.
            /// Returns the StoredMatchmakingResults.
            /// </summary>
            /// <param name="request">Request object for GetMatchmakingResults.</param>
            /// <param name="operationConfiguration">Configuration for GetMatchmakingResults.</param>
            /// <returns>Task for a Response object containing status code, headers, and Models.StoredMatchmakingResults object.</returns>
            /// <exception cref="Unity.Services.Matchmaker.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<Models.StoredMatchmakingResults>> GetMatchmakingResultsAsync(Unity.Services.Matchmaker.Matches.GetMatchmakingResultsRequest request, Configuration operationConfiguration = null);

    }

    ///<inheritdoc cref="IMatchesApiClient"/>
    internal class MatchesApiClient : BaseApiClient, IMatchesApiClient
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
                Configuration globalConfiguration = new Configuration("https://matchmaker.services.api.unity.com", 10, 4, null);
                return Configuration.MergeConfigurations(_configuration, globalConfiguration);
            }
            set { _configuration = value; }
        }

        /// <summary>
        /// MatchesApiClient Constructor.
        /// </summary>
        /// <param name="httpClient">The HttpClient for MatchesApiClient.</param>
        /// <param name="accessToken">The Authentication token for the client.</param>
        /// <param name="configuration"> MatchesApiClient Configuration object.</param>
        public MatchesApiClient(IHttpClient httpClient,
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
        /// Returns the StoredMatchmakingResults.
        /// </summary>
        /// <param name="request">Request object for GetMatchmakingResults.</param>
        /// <param name="operationConfiguration">Configuration for GetMatchmakingResults.</param>
        /// <returns>Task for a Response object containing status code, headers, and Models.StoredMatchmakingResults object.</returns>
        /// <exception cref="Unity.Services.Matchmaker.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<Models.StoredMatchmakingResults>> GetMatchmakingResultsAsync(Unity.Services.Matchmaker.Matches.GetMatchmakingResultsRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(Models.StoredMatchmakingResults)   },{"400", typeof(Models.ProblemDetails)   },{"404", typeof(Models.ProblemDetails)   },{"429", typeof(Models.ProblemDetails)   },{"500", typeof(Models.ProblemDetails)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("GET",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(_accessToken, finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<Models.StoredMatchmakingResults>(response, statusCodeToTypeMap);
            return new Response<Models.StoredMatchmakingResults>(response, handledResponse);
        }

    }
}
