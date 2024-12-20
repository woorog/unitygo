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
using Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Models;
using Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http;
using Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Permissions;

namespace Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Apis.Permissions
{
    /// <summary>
    /// Interface for the PermissionsApiClient
    /// </summary>
    internal interface IPermissionsApiClient
    {
            /// <summary>
            /// Async Operation.
            /// Create a permission.
            /// </summary>
            /// <param name="request">Request object for CreatePermissionByBucket.</param>
            /// <param name="operationConfiguration">Configuration for CreatePermissionByBucket.</param>
            /// <returns>Task for a Response object containing status code, headers, and GetAllByBucket200ResponseInner object.</returns>
            /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<GetAllByBucket200ResponseInner>> CreatePermissionByBucketAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Permissions.CreatePermissionByBucketRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Create a permission.
            /// </summary>
            /// <param name="request">Request object for CreatePermissionByBucketEnv.</param>
            /// <param name="operationConfiguration">Configuration for CreatePermissionByBucketEnv.</param>
            /// <returns>Task for a Response object containing status code, headers, and GetAllByBucket200ResponseInner object.</returns>
            /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<GetAllByBucket200ResponseInner>> CreatePermissionByBucketEnvAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Permissions.CreatePermissionByBucketEnvRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// delete a permission.
            /// </summary>
            /// <param name="request">Request object for DeletePermissionByBucket.</param>
            /// <param name="operationConfiguration">Configuration for DeletePermissionByBucket.</param>
            /// <returns>Task for a Response object containing status code, headers.</returns>
            /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response> DeletePermissionByBucketAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Permissions.DeletePermissionByBucketRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// delete a permission.
            /// </summary>
            /// <param name="request">Request object for DeletePermissionByBucketEnv.</param>
            /// <param name="operationConfiguration">Configuration for DeletePermissionByBucketEnv.</param>
            /// <returns>Task for a Response object containing status code, headers.</returns>
            /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response> DeletePermissionByBucketEnvAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Permissions.DeletePermissionByBucketEnvRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Get permissions for bucket.
            /// </summary>
            /// <param name="request">Request object for GetAllByBucket.</param>
            /// <param name="operationConfiguration">Configuration for GetAllByBucket.</param>
            /// <returns>Task for a Response object containing status code, headers, and List&lt;GetAllByBucket200ResponseInner&gt; object.</returns>
            /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<List<GetAllByBucket200ResponseInner>>> GetAllByBucketAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Permissions.GetAllByBucketRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Get permissions for bucket.
            /// </summary>
            /// <param name="request">Request object for GetAllByBucketEnv.</param>
            /// <param name="operationConfiguration">Configuration for GetAllByBucketEnv.</param>
            /// <returns>Task for a Response object containing status code, headers, and List&lt;GetAllByBucket200ResponseInner&gt; object.</returns>
            /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<List<GetAllByBucket200ResponseInner>>> GetAllByBucketEnvAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Permissions.GetAllByBucketEnvRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Update a permission.
            /// </summary>
            /// <param name="request">Request object for UpdatePermissionByBucket.</param>
            /// <param name="operationConfiguration">Configuration for UpdatePermissionByBucket.</param>
            /// <returns>Task for a Response object containing status code, headers, and GetAllByBucket200ResponseInner object.</returns>
            /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<GetAllByBucket200ResponseInner>> UpdatePermissionByBucketAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Permissions.UpdatePermissionByBucketRequest request, Configuration operationConfiguration = null);

            /// <summary>
            /// Async Operation.
            /// Update a permission.
            /// </summary>
            /// <param name="request">Request object for UpdatePermissionByBucketEnv.</param>
            /// <param name="operationConfiguration">Configuration for UpdatePermissionByBucketEnv.</param>
            /// <returns>Task for a Response object containing status code, headers, and GetAllByBucket200ResponseInner object.</returns>
            /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
            Task<Response<GetAllByBucket200ResponseInner>> UpdatePermissionByBucketEnvAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Permissions.UpdatePermissionByBucketEnvRequest request, Configuration operationConfiguration = null);

    }

    ///<inheritdoc cref="IPermissionsApiClient"/>
    internal class PermissionsApiClient : BaseApiClient, IPermissionsApiClient
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
        /// PermissionsApiClient Constructor.
        /// </summary>
        /// <param name="httpClient">The HttpClient for PermissionsApiClient.</param>
        /// <param name="configuration"> PermissionsApiClient Configuration object.</param>
        public PermissionsApiClient(IHttpClient httpClient,
            Configuration configuration = null) : base(httpClient)
        {
            // We don't need to worry about the configuration being null at
            // this stage, we will check this in the accessor.
            _configuration = configuration;


        }


        /// <summary>
        /// Async Operation.
        /// Create a permission.
        /// </summary>
        /// <param name="request">Request object for CreatePermissionByBucket.</param>
        /// <param name="operationConfiguration">Configuration for CreatePermissionByBucket.</param>
        /// <returns>Task for a Response object containing status code, headers, and GetAllByBucket200ResponseInner object.</returns>
        /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<GetAllByBucket200ResponseInner>> CreatePermissionByBucketAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Permissions.CreatePermissionByBucketRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(GetAllByBucket200ResponseInner)   },{"400", typeof(GetBucket400Response)   },{"401", typeof(GetBucket401Response)   },{"403", typeof(GetBucket403Response)   },{"404", typeof(GetBucket404Response)   },{"429", typeof(GetBucket429Response)   },{"500", typeof(GetBucket500Response)   },{"503", typeof(GetBucket503Response)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("POST",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<GetAllByBucket200ResponseInner>(response, statusCodeToTypeMap);
            return new Response<GetAllByBucket200ResponseInner>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// Create a permission.
        /// </summary>
        /// <param name="request">Request object for CreatePermissionByBucketEnv.</param>
        /// <param name="operationConfiguration">Configuration for CreatePermissionByBucketEnv.</param>
        /// <returns>Task for a Response object containing status code, headers, and GetAllByBucket200ResponseInner object.</returns>
        /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<GetAllByBucket200ResponseInner>> CreatePermissionByBucketEnvAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Permissions.CreatePermissionByBucketEnvRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(GetAllByBucket200ResponseInner)   },{"400", typeof(GetBucket400Response)   },{"401", typeof(GetBucket401Response)   },{"403", typeof(GetBucket403Response)   },{"404", typeof(GetBucket404Response)   },{"429", typeof(GetBucket429Response)   },{"500", typeof(GetBucket500Response)   },{"503", typeof(GetBucket503Response)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("POST",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<GetAllByBucket200ResponseInner>(response, statusCodeToTypeMap);
            return new Response<GetAllByBucket200ResponseInner>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// delete a permission.
        /// </summary>
        /// <param name="request">Request object for DeletePermissionByBucket.</param>
        /// <param name="operationConfiguration">Configuration for DeletePermissionByBucket.</param>
        /// <returns>Task for a Response object containing status code, headers.</returns>
        /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response> DeletePermissionByBucketAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Permissions.DeletePermissionByBucketRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"204",  null },{"400", typeof(GetBucket400Response)   },{"401", typeof(GetBucket401Response)   },{"403", typeof(GetBucket403Response)   },{"404", typeof(GetBucket404Response)   },{"429", typeof(GetBucket429Response)   },{"500", typeof(GetBucket500Response)   },{"503", typeof(GetBucket503Response)   } };

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
        /// delete a permission.
        /// </summary>
        /// <param name="request">Request object for DeletePermissionByBucketEnv.</param>
        /// <param name="operationConfiguration">Configuration for DeletePermissionByBucketEnv.</param>
        /// <returns>Task for a Response object containing status code, headers.</returns>
        /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response> DeletePermissionByBucketEnvAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Permissions.DeletePermissionByBucketEnvRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"204",  null },{"400", typeof(GetBucket400Response)   },{"401", typeof(GetBucket401Response)   },{"403", typeof(GetBucket403Response)   },{"404", typeof(GetBucket404Response)   },{"429", typeof(GetBucket429Response)   },{"500", typeof(GetBucket500Response)   },{"503", typeof(GetBucket503Response)   } };

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
        /// Get permissions for bucket.
        /// </summary>
        /// <param name="request">Request object for GetAllByBucket.</param>
        /// <param name="operationConfiguration">Configuration for GetAllByBucket.</param>
        /// <returns>Task for a Response object containing status code, headers, and List&lt;GetAllByBucket200ResponseInner&gt; object.</returns>
        /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<List<GetAllByBucket200ResponseInner>>> GetAllByBucketAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Permissions.GetAllByBucketRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(List<GetAllByBucket200ResponseInner>)   },{"400", typeof(GetBucket400Response)   },{"401", typeof(GetBucket401Response)   },{"403", typeof(GetBucket403Response)   },{"404", typeof(GetBucket404Response)   },{"429", typeof(GetBucket429Response)   },{"500", typeof(GetBucket500Response)   },{"503", typeof(GetBucket503Response)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("GET",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<List<GetAllByBucket200ResponseInner>>(response, statusCodeToTypeMap);
            return new Response<List<GetAllByBucket200ResponseInner>>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// Get permissions for bucket.
        /// </summary>
        /// <param name="request">Request object for GetAllByBucketEnv.</param>
        /// <param name="operationConfiguration">Configuration for GetAllByBucketEnv.</param>
        /// <returns>Task for a Response object containing status code, headers, and List&lt;GetAllByBucket200ResponseInner&gt; object.</returns>
        /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<List<GetAllByBucket200ResponseInner>>> GetAllByBucketEnvAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Permissions.GetAllByBucketEnvRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(List<GetAllByBucket200ResponseInner>)   },{"400", typeof(GetBucket400Response)   },{"401", typeof(GetBucket401Response)   },{"403", typeof(GetBucket403Response)   },{"404", typeof(GetBucket404Response)   },{"429", typeof(GetBucket429Response)   },{"500", typeof(GetBucket500Response)   },{"503", typeof(GetBucket503Response)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("GET",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<List<GetAllByBucket200ResponseInner>>(response, statusCodeToTypeMap);
            return new Response<List<GetAllByBucket200ResponseInner>>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// Update a permission.
        /// </summary>
        /// <param name="request">Request object for UpdatePermissionByBucket.</param>
        /// <param name="operationConfiguration">Configuration for UpdatePermissionByBucket.</param>
        /// <returns>Task for a Response object containing status code, headers, and GetAllByBucket200ResponseInner object.</returns>
        /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<GetAllByBucket200ResponseInner>> UpdatePermissionByBucketAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Permissions.UpdatePermissionByBucketRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(GetAllByBucket200ResponseInner)   },{"400", typeof(GetBucket400Response)   },{"401", typeof(GetBucket401Response)   },{"403", typeof(GetBucket403Response)   },{"404", typeof(GetBucket404Response)   },{"429", typeof(GetBucket429Response)   },{"500", typeof(GetBucket500Response)   },{"503", typeof(GetBucket503Response)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("PUT",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<GetAllByBucket200ResponseInner>(response, statusCodeToTypeMap);
            return new Response<GetAllByBucket200ResponseInner>(response, handledResponse);
        }


        /// <summary>
        /// Async Operation.
        /// Update a permission.
        /// </summary>
        /// <param name="request">Request object for UpdatePermissionByBucketEnv.</param>
        /// <param name="operationConfiguration">Configuration for UpdatePermissionByBucketEnv.</param>
        /// <returns>Task for a Response object containing status code, headers, and GetAllByBucket200ResponseInner object.</returns>
        /// <exception cref="Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Http.HttpException">An exception containing the HttpClientResponse with headers, response code, and string of error.</exception>
        public async Task<Response<GetAllByBucket200ResponseInner>> UpdatePermissionByBucketEnvAsync(Unity.Services.Multiplay.Authoring.Editor.AdminApis.Ccd.Permissions.UpdatePermissionByBucketEnvRequest request,
            Configuration operationConfiguration = null)
        {
            var statusCodeToTypeMap = new Dictionary<string, System.Type>() { {"200", typeof(GetAllByBucket200ResponseInner)   },{"400", typeof(GetBucket400Response)   },{"401", typeof(GetBucket401Response)   },{"403", typeof(GetBucket403Response)   },{"404", typeof(GetBucket404Response)   },{"429", typeof(GetBucket429Response)   },{"500", typeof(GetBucket500Response)   },{"503", typeof(GetBucket503Response)   } };

            // Merge the operation/request level configuration with the client level configuration.
            var finalConfiguration = Configuration.MergeConfigurations(operationConfiguration, Configuration);

            var response = await HttpClient.MakeRequestAsync("PUT",
                request.ConstructUrl(finalConfiguration.BasePath),
                request.ConstructBody(),
                request.ConstructHeaders(finalConfiguration),
                finalConfiguration.RequestTimeout ?? _baseTimeout);

            var handledResponse = ResponseHandler.HandleAsyncResponse<GetAllByBucket200ResponseInner>(response, statusCodeToTypeMap);
            return new Response<GetAllByBucket200ResponseInner>(response, handledResponse);
        }

    }
}
