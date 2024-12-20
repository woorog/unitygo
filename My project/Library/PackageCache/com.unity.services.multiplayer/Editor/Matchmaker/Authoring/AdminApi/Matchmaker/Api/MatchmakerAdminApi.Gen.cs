#if UNITY_EDITOR || ENABLE_RUNTIME_ADMIN_APIS
//-----------------------------------------------------------------------------
// <auto-generated>
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Threading;
using Unity.Services.Multiplayer.Editor.Matchmaker.Authoring.AdminApi.Matchmaker.Model;
using Unity.Services.Multiplayer.Editor.Matchmaker.Authoring.AdminApi.Shared;
using Unity.Services.Multiplayer.Editor.Shared.Clients;

namespace Unity.Services.Multiplayer.Editor.Matchmaker.Authoring.AdminApi.Matchmaker.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    interface IMatchmakerAdminApi : IApiAccessor
    {
        /// <summary>
        /// Get Matchmaker environment configuration
        /// </summary>
        /// <param name="upid">Unity Project ID identifying which project this request is intended for.</param>
        /// <param name="env">The target deployment environment.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>The operation</returns>
        ApiOperation<EnvironmentConfig> GetEnvironmentConfig(string upid, string env, CancellationToken cancellationToken = default);

        /// <summary>
        /// Upsert Matchmaker environment configuration
        /// </summary>
        /// <param name="upid">Unity Project ID identifying which project this request is intended for.</param>
        /// <param name="env">The target deployment environment.</param>
        /// <param name="dryRun"> (optional)</param>
        /// <param name="environmentConfig"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>The operation</returns>
        ApiOperation UpdateEnvironmentConfig(string upid, string env, bool? dryRun = default(bool?), EnvironmentConfig environmentConfig = default(EnvironmentConfig), CancellationToken cancellationToken = default);

        /// <summary>
        /// Get Matchmaker restrictions
        /// </summary>
        /// <param name="upid">Unity Project ID identifying which project this request is intended for.</param>
        /// <param name="env">The target deployment environment.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>The operation</returns>
        ApiOperation<Restrictions> GetRestrictions(string upid, string env, CancellationToken cancellationToken = default);

        /// <summary>
        /// List queue config
        /// </summary>
        /// <param name="upid">Unity Project ID identifying which project this request is intended for.</param>
        /// <param name="env">The target deployment environment.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>The operation</returns>
        ApiOperation<List<QueueConfig>> ListQueues(string upid, string env, CancellationToken cancellationToken = default);

        /// <summary>
        /// Upsert a Matchmaker Queue
        /// </summary>
        /// <param name="upid">Unity Project ID identifying which project this request is intended for.</param>
        /// <param name="env">The target deployment environment.</param>
        /// <param name="queueName"></param>
        /// <param name="dryRun"> (optional)</param>
        /// <param name="queueConfig"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>The operation</returns>
        ApiOperation UpsertQueueConfig(string upid, string env, string queueName, bool? dryRun = default(bool?), QueueConfig queueConfig = default(QueueConfig), CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes a Matchmaker Queue
        /// </summary>
        /// <param name="upid">Unity Project ID identifying which project this request is intended for.</param>
        /// <param name="env">The target deployment environment.</param>
        /// <param name="queueName"></param>
        /// <param name="dryRun"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>The operation</returns>
        ApiOperation DeleteQueue(string upid, string env, string queueName, bool? dryRun = default(bool?), CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    partial class MatchmakerAdminApi : IMatchmakerAdminApi
    {
        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public IApiClient Client { get; }

        /// <summary>
        /// Gets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IApiConfiguration Configuration { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MatchmakerAdminApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="apiClient">The client interface for synchronous API access.</param>
        public MatchmakerAdminApi(IApiClient apiClient)
        {
            if (apiClient == null) throw new ArgumentNullException("apiClient");

            Client = apiClient;
            var path = CloudEnvironmentConfigProvider.IsStaging() ? "https://staging.services.unity.com" : "https://services.api.unity.com";
            Configuration = new ApiConfiguration()
            {
                BasePath = path
            };
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MatchmakerAdminApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="apiClient">The client interface for synchronous API access.</param>
        /// <param name="apiConfiguration">The configuration object.</param>
        public MatchmakerAdminApi(IApiClient apiClient, IApiConfiguration apiConfiguration)
        {
            if (apiClient == null) throw new ArgumentNullException("apiClient");
            if (apiConfiguration == null) throw new ArgumentNullException("apiConfiguration");

            this.Client = apiClient;
            this.Configuration = apiConfiguration;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <returns>The base path</returns>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Get Matchmaker environment configuration Get the Matchmaker&#39;s environment configuration. This configuration is for the whole environment.
        /// </summary>
        /// <param name="upid">Unity Project ID identifying which project this request is intended for.</param>
        /// <param name="env">The target deployment environment.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>The operation</returns>
        public ApiOperation<EnvironmentConfig> GetEnvironmentConfig(string upid, string env, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'upid' is set
            if (upid == null)
            {
                return new ApiOperation<EnvironmentConfig>(new ApiResponse<EnvironmentConfig>()
                {
                    StatusCode = -1,
                    ErrorText = "Missing required parameter 'upid' when calling MatchmakerAdminApi.GetEnvironmentConfig",
                    ErrorType = ApiErrorType.InvalidParameters
                });
            }

            // verify the required parameter 'env' is set
            if (env == null)
            {
                return new ApiOperation<EnvironmentConfig>(new ApiResponse<EnvironmentConfig>()
                {
                    StatusCode = -1,
                    ErrorText = "Missing required parameter 'env' when calling MatchmakerAdminApi.GetEnvironmentConfig",
                    ErrorType = ApiErrorType.InvalidParameters
                });
            }

            ApiRequestOptions localRequestOptions = new ApiRequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "application/problem+json"
            };

            var localContentType = ApiUtils.SelectHeaderContentType(_contentTypes);
            if (localContentType != null)
            {
                localRequestOptions.HeaderParameters.Add("Content-Type", localContentType);
            }

            var localAccept = ApiUtils.SelectHeaderAccept(_accepts);
            if (localAccept != null)
            {
                localRequestOptions.HeaderParameters.Add("Accept", localAccept);
            }

            localRequestOptions.PathParameters.Add("upid", ApiUtils.ParameterToString(Configuration, upid)); // path parameter
            localRequestOptions.PathParameters.Add("env", ApiUtils.ParameterToString(Configuration, env)); // path parameter

            localRequestOptions.Operation = "MatchmakerAdminApi.GetEnvironmentConfig";

            // authentication (ServiceAccount) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ApiUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            return this.Client.Get<EnvironmentConfig>("/matchmaker/v3/projects/{upid}/environments/{env}/config", localRequestOptions, this.Configuration, cancellationToken);
        }

        /// <summary>
        /// Upsert Matchmaker environment configuration Create or update the Matchmaker configuration. This configuration is for the whole environment.
        /// </summary>
        /// <param name="upid">Unity Project ID identifying which project this request is intended for.</param>
        /// <param name="env">The target deployment environment.</param>
        /// <param name="dryRun"> (optional)</param>
        /// <param name="environmentConfig"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>The operation</returns>
        public ApiOperation UpdateEnvironmentConfig(string upid, string env, bool? dryRun = default(bool?), EnvironmentConfig environmentConfig = default(EnvironmentConfig), CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'upid' is set
            if (upid == null)
            {
                return new ApiOperation(new ApiResponse()
                {
                    StatusCode = -1,
                    ErrorText = "Missing required parameter 'upid' when calling MatchmakerAdminApi.UpdateEnvironmentConfig",
                    ErrorType = ApiErrorType.InvalidParameters
                });
            }

            // verify the required parameter 'env' is set
            if (env == null)
            {
                return new ApiOperation(new ApiResponse()
                {
                    StatusCode = -1,
                    ErrorText = "Missing required parameter 'env' when calling MatchmakerAdminApi.UpdateEnvironmentConfig",
                    ErrorType = ApiErrorType.InvalidParameters
                });
            }

            ApiRequestOptions localRequestOptions = new ApiRequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/problem+json"
            };

            var localContentType = ApiUtils.SelectHeaderContentType(_contentTypes);
            if (localContentType != null)
            {
                localRequestOptions.HeaderParameters.Add("Content-Type", localContentType);
            }

            var localAccept = ApiUtils.SelectHeaderAccept(_accepts);
            if (localAccept != null)
            {
                localRequestOptions.HeaderParameters.Add("Accept", localAccept);
            }

            localRequestOptions.PathParameters.Add("upid", ApiUtils.ParameterToString(Configuration, upid)); // path parameter
            localRequestOptions.PathParameters.Add("env", ApiUtils.ParameterToString(Configuration, env)); // path parameter
            if (dryRun != null)
            {
                localRequestOptions.QueryParameters.Add(ApiUtils.ParameterToMultiMap(Configuration, "", "dryRun", dryRun));
            }
            localRequestOptions.Data = environmentConfig;

            localRequestOptions.Operation = "MatchmakerAdminApi.UpdateEnvironmentConfig";

            // authentication (ServiceAccount) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ApiUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            return this.Client.Put("/matchmaker/v3/projects/{upid}/environments/{env}/config", localRequestOptions, this.Configuration, cancellationToken);
        }

        /// <summary>
        /// Get Matchmaker restrictions Get the Matchmaker configuration restrictions. Those restrictions are for the whole environment.
        /// </summary>
        /// <param name="upid">Unity Project ID identifying which project this request is intended for.</param>
        /// <param name="env">The target deployment environment.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>The operation</returns>
        public ApiOperation<Restrictions> GetRestrictions(string upid, string env, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'upid' is set
            if (upid == null)
            {
                return new ApiOperation<Restrictions>(new ApiResponse<Restrictions>()
                {
                    StatusCode = -1,
                    ErrorText = "Missing required parameter 'upid' when calling MatchmakerAdminApi.GetRestrictions",
                    ErrorType = ApiErrorType.InvalidParameters
                });
            }

            // verify the required parameter 'env' is set
            if (env == null)
            {
                return new ApiOperation<Restrictions>(new ApiResponse<Restrictions>()
                {
                    StatusCode = -1,
                    ErrorText = "Missing required parameter 'env' when calling MatchmakerAdminApi.GetRestrictions",
                    ErrorType = ApiErrorType.InvalidParameters
                });
            }

            ApiRequestOptions localRequestOptions = new ApiRequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "application/problem+json"
            };

            var localContentType = ApiUtils.SelectHeaderContentType(_contentTypes);
            if (localContentType != null)
            {
                localRequestOptions.HeaderParameters.Add("Content-Type", localContentType);
            }

            var localAccept = ApiUtils.SelectHeaderAccept(_accepts);
            if (localAccept != null)
            {
                localRequestOptions.HeaderParameters.Add("Accept", localAccept);
            }

            localRequestOptions.PathParameters.Add("upid", ApiUtils.ParameterToString(Configuration, upid)); // path parameter
            localRequestOptions.PathParameters.Add("env", ApiUtils.ParameterToString(Configuration, env)); // path parameter

            localRequestOptions.Operation = "MatchmakerAdminApi.GetRestrictions";

            // authentication (ServiceAccount) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ApiUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            return this.Client.Get<Restrictions>("/matchmaker/v3/projects/{upid}/environments/{env}/restrictions", localRequestOptions, this.Configuration, cancellationToken);
        }

        /// <summary>
        /// List queue config Get all Matchmaker Queue configurations.
        /// </summary>
        /// <param name="upid">Unity Project ID identifying which project this request is intended for.</param>
        /// <param name="env">The target deployment environment.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>The operation</returns>
        public ApiOperation<List<QueueConfig>> ListQueues(string upid, string env, CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'upid' is set
            if (upid == null)
            {
                return new ApiOperation<List<QueueConfig>>(new ApiResponse<List<QueueConfig>>()
                {
                    StatusCode = -1,
                    ErrorText = "Missing required parameter 'upid' when calling MatchmakerAdminApi.ListQueues",
                    ErrorType = ApiErrorType.InvalidParameters
                });
            }

            // verify the required parameter 'env' is set
            if (env == null)
            {
                return new ApiOperation<List<QueueConfig>>(new ApiResponse<List<QueueConfig>>()
                {
                    StatusCode = -1,
                    ErrorText = "Missing required parameter 'env' when calling MatchmakerAdminApi.ListQueues",
                    ErrorType = ApiErrorType.InvalidParameters
                });
            }

            ApiRequestOptions localRequestOptions = new ApiRequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "application/problem+json"
            };

            var localContentType = ApiUtils.SelectHeaderContentType(_contentTypes);
            if (localContentType != null)
            {
                localRequestOptions.HeaderParameters.Add("Content-Type", localContentType);
            }

            var localAccept = ApiUtils.SelectHeaderAccept(_accepts);
            if (localAccept != null)
            {
                localRequestOptions.HeaderParameters.Add("Accept", localAccept);
            }

            localRequestOptions.PathParameters.Add("upid", ApiUtils.ParameterToString(Configuration, upid)); // path parameter
            localRequestOptions.PathParameters.Add("env", ApiUtils.ParameterToString(Configuration, env)); // path parameter

            localRequestOptions.Operation = "MatchmakerAdminApi.ListQueues";

            // authentication (ServiceAccount) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ApiUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            return this.Client.Get<List<QueueConfig>>("/matchmaker/v3/projects/{upid}/environments/{env}/queues", localRequestOptions, this.Configuration, cancellationToken);
        }

        /// <summary>
        /// Upsert a Matchmaker Queue Create or update a single Matchmaker Queue configuration.
        /// </summary>
        /// <param name="upid">Unity Project ID identifying which project this request is intended for.</param>
        /// <param name="env">The target deployment environment.</param>
        /// <param name="queueName"></param>
        /// <param name="dryRun"> (optional)</param>
        /// <param name="queueConfig"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>The operation</returns>
        public ApiOperation UpsertQueueConfig(string upid, string env, string queueName, bool? dryRun = default(bool?), QueueConfig queueConfig = default(QueueConfig), CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'upid' is set
            if (upid == null)
            {
                return new ApiOperation(new ApiResponse()
                {
                    StatusCode = -1,
                    ErrorText = "Missing required parameter 'upid' when calling MatchmakerAdminApi.UpsertQueueConfig",
                    ErrorType = ApiErrorType.InvalidParameters
                });
            }

            // verify the required parameter 'env' is set
            if (env == null)
            {
                return new ApiOperation(new ApiResponse()
                {
                    StatusCode = -1,
                    ErrorText = "Missing required parameter 'env' when calling MatchmakerAdminApi.UpsertQueueConfig",
                    ErrorType = ApiErrorType.InvalidParameters
                });
            }

            // verify the required parameter 'queueName' is set
            if (queueName == null)
            {
                return new ApiOperation(new ApiResponse()
                {
                    StatusCode = -1,
                    ErrorText = "Missing required parameter 'queueName' when calling MatchmakerAdminApi.UpsertQueueConfig",
                    ErrorType = ApiErrorType.InvalidParameters
                });
            }

            ApiRequestOptions localRequestOptions = new ApiRequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/problem+json"
            };

            var localContentType = ApiUtils.SelectHeaderContentType(_contentTypes);
            if (localContentType != null)
            {
                localRequestOptions.HeaderParameters.Add("Content-Type", localContentType);
            }

            var localAccept = ApiUtils.SelectHeaderAccept(_accepts);
            if (localAccept != null)
            {
                localRequestOptions.HeaderParameters.Add("Accept", localAccept);
            }

            localRequestOptions.PathParameters.Add("upid", ApiUtils.ParameterToString(Configuration, upid)); // path parameter
            localRequestOptions.PathParameters.Add("env", ApiUtils.ParameterToString(Configuration, env)); // path parameter
            localRequestOptions.PathParameters.Add("queueName", ApiUtils.ParameterToString(Configuration, queueName)); // path parameter
            if (dryRun != null)
            {
                localRequestOptions.QueryParameters.Add(ApiUtils.ParameterToMultiMap(Configuration, "", "dryRun", dryRun));
            }
            localRequestOptions.Data = queueConfig;

            localRequestOptions.Operation = "MatchmakerAdminApi.UpsertQueueConfig";

            // authentication (ServiceAccount) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ApiUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            return this.Client.Put("/matchmaker/v3/projects/{upid}/environments/{env}/queues/{queueName}", localRequestOptions, this.Configuration, cancellationToken);
        }

        /// <summary>
        /// Deletes a Matchmaker Queue Delete a Matchmaker Queue configuration.
        /// </summary>
        /// <param name="upid">Unity Project ID identifying which project this request is intended for.</param>
        /// <param name="env">The target deployment environment.</param>
        /// <param name="queueName"></param>
        /// <param name="dryRun"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>The operation</returns>
        public ApiOperation DeleteQueue(string upid, string env, string queueName, bool? dryRun = default(bool?), CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'upid' is set
            if (upid == null)
            {
                return new ApiOperation(new ApiResponse()
                {
                    StatusCode = -1,
                    ErrorText = "Missing required parameter 'upid' when calling MatchmakerAdminApi.DeleteQueue",
                    ErrorType = ApiErrorType.InvalidParameters
                });
            }

            // verify the required parameter 'env' is set
            if (env == null)
            {
                return new ApiOperation(new ApiResponse()
                {
                    StatusCode = -1,
                    ErrorText = "Missing required parameter 'env' when calling MatchmakerAdminApi.DeleteQueue",
                    ErrorType = ApiErrorType.InvalidParameters
                });
            }

            // verify the required parameter 'queueName' is set
            if (queueName == null)
            {
                return new ApiOperation(new ApiResponse()
                {
                    StatusCode = -1,
                    ErrorText = "Missing required parameter 'queueName' when calling MatchmakerAdminApi.DeleteQueue",
                    ErrorType = ApiErrorType.InvalidParameters
                });
            }

            ApiRequestOptions localRequestOptions = new ApiRequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/problem+json"
            };

            var localContentType = ApiUtils.SelectHeaderContentType(_contentTypes);
            if (localContentType != null)
            {
                localRequestOptions.HeaderParameters.Add("Content-Type", localContentType);
            }

            var localAccept = ApiUtils.SelectHeaderAccept(_accepts);
            if (localAccept != null)
            {
                localRequestOptions.HeaderParameters.Add("Accept", localAccept);
            }

            localRequestOptions.PathParameters.Add("upid", ApiUtils.ParameterToString(Configuration, upid)); // path parameter
            localRequestOptions.PathParameters.Add("env", ApiUtils.ParameterToString(Configuration, env)); // path parameter
            localRequestOptions.PathParameters.Add("queueName", ApiUtils.ParameterToString(Configuration, queueName)); // path parameter
            if (dryRun != null)
            {
                localRequestOptions.QueryParameters.Add(ApiUtils.ParameterToMultiMap(Configuration, "", "dryRun", dryRun));
            }

            localRequestOptions.Operation = "MatchmakerAdminApi.DeleteQueue";

            // authentication (ServiceAccount) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password) && !localRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localRequestOptions.HeaderParameters.Add("Authorization", "Basic " + ApiUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            return this.Client.Delete("/matchmaker/v3/projects/{upid}/environments/{env}/queues/{queueName}", localRequestOptions, this.Configuration, cancellationToken);
        }
    }
}
#endif