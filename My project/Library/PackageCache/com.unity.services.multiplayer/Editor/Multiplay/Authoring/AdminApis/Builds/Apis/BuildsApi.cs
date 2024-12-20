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
using Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Models;
using Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Http;
using Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Builds;

namespace Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Apis.Builds
{
    /// <summary>
    /// Interface for the BuildsApiClient
    /// </summary>
    internal interface IBuildsApiClient
    {
            /// <summary>
            /// Async Operation.
            /// Create new build.
            /// </summary>
            /// <param name="request">Request object for CreateBuild.</param>
            /// <param name="operationConfiguration">Configuration for CreateBuild.</param>
            /// <returns>Task for a Response object containing status code, headers, and CreateBuild200Response object.</returns>
            /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<CreateBuild200Response>> CreateBuildAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Builds.CreateBuildRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Create a new build version.
            /// </summary>
            /// <param name="request">Request object for CreateNewBuildVersion.</param>
            /// <param name="operationConfiguration">Configuration for CreateNewBuildVersion.</param>
            /// <returns>Task for a Response object containing status code, headers, and IDeserializable object.</returns>
            /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<IDeserializable>> CreateNewBuildVersionAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Builds.CreateNewBuildVersionRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Create or update build files for a given build.
            /// </summary>
            /// <param name="request">Request object for CreateOrUpdateBuildFile.</param>
            /// <param name="operationConfiguration">Configuration for CreateOrUpdateBuildFile.</param>
            /// <returns>Task for a Response object containing status code, headers, and BuildFilesListResultsInner object.</returns>
            /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<BuildFilesListResultsInner>> CreateOrUpdateBuildFileAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Builds.CreateOrUpdateBuildFileRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Delete a single build.
            /// </summary>
            /// <param name="request">Request object for DeleteBuild.</param>
            /// <param name="operationConfiguration">Configuration for DeleteBuild.</param>
            /// <returns>Task for a Response object containing status code, headers.</returns>
            /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response> DeleteBuildAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Builds.DeleteBuildRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Delete a build file by path for a given build.
            /// </summary>
            /// <param name="request">Request object for DeleteBuildFileByPath.</param>
            /// <param name="operationConfiguration">Configuration for DeleteBuildFileByPath.</param>
            /// <returns>Task for a Response object containing status code, headers.</returns>
            /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response> DeleteBuildFileByPathAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Builds.DeleteBuildFileByPathRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Get a single build.
            /// </summary>
            /// <param name="request">Request object for GetBuild.</param>
            /// <param name="operationConfiguration">Configuration for GetBuild.</param>
            /// <returns>Task for a Response object containing status code, headers, and CreateBuild200Response object.</returns>
            /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<CreateBuild200Response>> GetBuildAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Builds.GetBuildRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Get a list of build files for a given build.
            /// </summary>
            /// <param name="request">Request object for GetBuildFiles.</param>
            /// <param name="operationConfiguration">Configuration for GetBuildFiles.</param>
            /// <returns>Task for a Response object containing status code, headers, and BuildFilesList object.</returns>
            /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<BuildFilesList>> GetBuildFilesAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Builds.GetBuildFilesRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Get a list of installs for a single build.
            /// </summary>
            /// <param name="request">Request object for GetBuildInstalls.</param>
            /// <param name="operationConfiguration">Configuration for GetBuildInstalls.</param>
            /// <returns>Task for a Response object containing status code, headers, and List&lt;BuildListInner1&gt; object.</returns>
            /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<List<BuildListInner1>>> GetBuildInstallsAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Builds.GetBuildInstallsRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Get a list of builds.
            /// </summary>
            /// <param name="request">Request object for ListBuilds.</param>
            /// <param name="operationConfiguration">Configuration for ListBuilds.</param>
            /// <returns>Task for a Response object containing status code, headers, and List&lt;BuildListInner&gt; object.</returns>
            /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<List<BuildListInner>>> ListBuildsAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Builds.ListBuildsRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Update a single build.
            /// </summary>
            /// <param name="request">Request object for UpdateBuild.</param>
            /// <param name="operationConfiguration">Configuration for UpdateBuild.</param>
            /// <returns>Task for a Response object containing status code, headers, and CreateBuild200Response object.</returns>
            /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<CreateBuild200Response>> UpdateBuildAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Builds.UpdateBuildRequest request, Configuration operationConfiguration = null);

    }

    ///<inheritdoc cref="IBuildsApiClient"/>
    internal class BuildsApiClient : BaseApiClient, IBuildsApiClient
    {
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
                Configuration globalConfiguration = new Configuration("https://services.unity.com", 10, 4, null);
                return Configuration.MergeConfigurations(_configuration, globalConfiguration);
            }
            set { _configuration = value; }
        }

        /// <summary>
        /// BuildsApiClient Constructor.
        /// </summary>
        /// <param name="httpClient">The HttpClient for BuildsApiClient.</param>
        /// <param name="configuration"> BuildsApiClient Configuration object.</param>
        public BuildsApiClient(IHttpClient httpClient,
            Configuration configuration = null) : base(httpClient)
        {
            // We don't need to worry about the configuration being null at
            // this stage, we will check this in the accessor.
            _configuration = configuration;


        }


        /// <summary>
        /// Async Operation.
        /// Create new build.
        /// </summary>
        /// <param name="request">Request object for CreateBuild.</param>
        /// <param name="operationConfiguration">Configuration for CreateBuild.</param>
        /// <returns>Task for a Response object containing status code, headers, and CreateBuild200Response object.</returns>
        /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<CreateBuild200Response>> CreateBuildAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Builds.CreateBuildRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(CreateBuild200Response)   },{"400", typeof(CreateBuild400Response)   },{"403", typeof(ListBuilds403Response)   },{"424", typeof(CreateBuild424Response)   },{"429", typeof(ListBuilds429Response)   },{"500", typeof(ListBuilds500Response)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("POST",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<CreateBuild200Response>(response, statusCodeToTypeMap);
            return new Response<CreateBuild200Response>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// Create a new build version.
        /// </summary>
        /// <param name="request">Request object for CreateNewBuildVersion.</param>
        /// <param name="operationConfiguration">Configuration for CreateNewBuildVersion.</param>
        /// <returns>Task for a Response object containing status code, headers, and object object.</returns>
        /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<IDeserializable>> CreateNewBuildVersionAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Builds.CreateNewBuildVersionRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"202", typeof(IDeserializable)   },{"400", typeof(CreateBuild400Response)   },{"401", typeof(ListBuilds401Response)   },{"403", typeof(ListBuilds403Response)   },{"404", typeof(ListBuilds404Response)   },{"424", typeof(CreateBuild424Response)   },{"429", typeof(ListBuilds429Response)   },{"500", typeof(ListBuilds500Response)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("POST",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<IDeserializable>(response, statusCodeToTypeMap);
            return new Response<IDeserializable>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// Create or update build files for a given build.
        /// </summary>
        /// <param name="request">Request object for CreateOrUpdateBuildFile.</param>
        /// <param name="operationConfiguration">Configuration for CreateOrUpdateBuildFile.</param>
        /// <returns>Task for a Response object containing status code, headers, and BuildFilesListResultsInner object.</returns>
        /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<BuildFilesListResultsInner>> CreateOrUpdateBuildFileAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Builds.CreateOrUpdateBuildFileRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(BuildFilesListResultsInner)   },{"400", typeof(CreateBuild400Response)   },{"401", typeof(ListBuilds401Response)   },{"403", typeof(ListBuilds403Response)   },{"404", typeof(ListBuilds404Response)   },{"429", typeof(ListBuilds429Response)   },{"500", typeof(ListBuilds500Response)   },{"503", typeof(CreateOrUpdateBuildFile503Response)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("PUT",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<BuildFilesListResultsInner>(response, statusCodeToTypeMap);
            return new Response<BuildFilesListResultsInner>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// Delete a single build.
        /// </summary>
        /// <param name="request">Request object for DeleteBuild.</param>
        /// <param name="operationConfiguration">Configuration for DeleteBuild.</param>
        /// <returns>Task for a Response object containing status code, headers.</returns>
        /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response> DeleteBuildAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Builds.DeleteBuildRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"204",  null },{"401", typeof(ListBuilds401Response)   },{"403", typeof(ListBuilds403Response)   },{"409", typeof(ConflictError)   },{"429", typeof(ListBuilds429Response)   },{"500", typeof(ListBuilds500Response)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("DELETE",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            ResponseHandler.HandleAsyncResponse(response, statusCodeToTypeMap);
            return new Response(response);
        }


        /// <summary>
        /// Async Operation.
        /// Delete a build file by path for a given build.
        /// </summary>
        /// <param name="request">Request object for DeleteBuildFileByPath.</param>
        /// <param name="operationConfiguration">Configuration for DeleteBuildFileByPath.</param>
        /// <returns>Task for a Response object containing status code, headers.</returns>
        /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response> DeleteBuildFileByPathAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Builds.DeleteBuildFileByPathRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"204",  null },{"400", typeof(CreateBuild400Response)   },{"401", typeof(ListBuilds401Response)   },{"403", typeof(ListBuilds403Response)   },{"404", typeof(ListBuilds404Response)   },{"409", typeof(ConflictError)   },{"429", typeof(ListBuilds429Response)   },{"500", typeof(ListBuilds500Response)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("DELETE",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            ResponseHandler.HandleAsyncResponse(response, statusCodeToTypeMap);
            return new Response(response);
        }


        /// <summary>
        /// Async Operation.
        /// Get a single build.
        /// </summary>
        /// <param name="request">Request object for GetBuild.</param>
        /// <param name="operationConfiguration">Configuration for GetBuild.</param>
        /// <returns>Task for a Response object containing status code, headers, and CreateBuild200Response object.</returns>
        /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<CreateBuild200Response>> GetBuildAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Builds.GetBuildRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(CreateBuild200Response)   },{"401", typeof(ListBuilds401Response)   },{"403", typeof(ListBuilds403Response)   },{"404", typeof(ListBuilds404Response)   },{"429", typeof(ListBuilds429Response)   },{"500", typeof(ListBuilds500Response)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("GET",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<CreateBuild200Response>(response, statusCodeToTypeMap);
            return new Response<CreateBuild200Response>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// Get a list of build files for a given build.
        /// </summary>
        /// <param name="request">Request object for GetBuildFiles.</param>
        /// <param name="operationConfiguration">Configuration for GetBuildFiles.</param>
        /// <returns>Task for a Response object containing status code, headers, and BuildFilesList object.</returns>
        /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<BuildFilesList>> GetBuildFilesAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Builds.GetBuildFilesRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(BuildFilesList)   },{"400", typeof(CreateBuild400Response)   },{"401", typeof(ListBuilds401Response)   },{"403", typeof(ListBuilds403Response)   },{"404", typeof(ListBuilds404Response)   },{"409", typeof(ConflictError)   },{"429", typeof(ListBuilds429Response)   },{"500", typeof(ListBuilds500Response)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("GET",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<BuildFilesList>(response, statusCodeToTypeMap);
            return new Response<BuildFilesList>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// Get a list of installs for a single build.
        /// </summary>
        /// <param name="request">Request object for GetBuildInstalls.</param>
        /// <param name="operationConfiguration">Configuration for GetBuildInstalls.</param>
        /// <returns>Task for a Response object containing status code, headers, and List&lt;BuildListInner1&gt; object.</returns>
        /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<List<BuildListInner1>>> GetBuildInstallsAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Builds.GetBuildInstallsRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(List<BuildListInner1>)   },{"401", typeof(ListBuilds401Response)   },{"403", typeof(ListBuilds403Response)   },{"404", typeof(ListBuilds404Response)   },{"429", typeof(ListBuilds429Response)   },{"500", typeof(ListBuilds500Response)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("GET",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<List<BuildListInner1>>(response, statusCodeToTypeMap);
            return new Response<List<BuildListInner1>>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// Get a list of builds.
        /// </summary>
        /// <param name="request">Request object for ListBuilds.</param>
        /// <param name="operationConfiguration">Configuration for ListBuilds.</param>
        /// <returns>Task for a Response object containing status code, headers, and List&lt;BuildListInner&gt; object.</returns>
        /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<List<BuildListInner>>> ListBuildsAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Builds.ListBuildsRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(List<BuildListInner>)   },{"401", typeof(ListBuilds401Response)   },{"403", typeof(ListBuilds403Response)   },{"404", typeof(ListBuilds404Response)   },{"429", typeof(ListBuilds429Response)   },{"500", typeof(ListBuilds500Response)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("GET",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<List<BuildListInner>>(response, statusCodeToTypeMap);
            return new Response<List<BuildListInner>>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// Update a single build.
        /// </summary>
        /// <param name="request">Request object for UpdateBuild.</param>
        /// <param name="operationConfiguration">Configuration for UpdateBuild.</param>
        /// <returns>Task for a Response object containing status code, headers, and CreateBuild200Response object.</returns>
        /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<CreateBuild200Response>> UpdateBuildAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Builds.Builds.UpdateBuildRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(CreateBuild200Response)   },{"400", typeof(CreateBuild400Response)   },{"401", typeof(ListBuilds401Response)   },{"403", typeof(ListBuilds403Response)   },{"404", typeof(ListBuilds404Response)   },{"429", typeof(ListBuilds429Response)   },{"500", typeof(ListBuilds500Response)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("PATCH",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<CreateBuild200Response>(response, statusCodeToTypeMap);
            return new Response<CreateBuild200Response>(response, handledResponse);
        }

    }
}