/*
 * Data
 *
 * With the Data service you can obtain additional data such as vehicle profiles.
 *
 * The version of the OpenAPI document: 1.13
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using PTV.Developer.Clients.data.Client;
using PTV.Developer.Clients.data.Model;

namespace PTV.Developer.Clients.data.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAPIChangesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get all API changes for PTV Developer.
        /// </remarks>
        /// <exception cref="PTV.Developer.Clients.data.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiChanges</returns>
        ApiChanges GetApiChanges(int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get all API changes for PTV Developer.
        /// </remarks>
        /// <exception cref="PTV.Developer.Clients.data.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApiChanges</returns>
        ApiResponse<ApiChanges> GetApiChangesWithHttpInfo(int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAPIChangesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get all API changes for PTV Developer.
        /// </remarks>
        /// <exception cref="PTV.Developer.Clients.data.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiChanges</returns>
        System.Threading.Tasks.Task<ApiChanges> GetApiChangesAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get all API changes for PTV Developer.
        /// </remarks>
        /// <exception cref="PTV.Developer.Clients.data.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApiChanges)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiChanges>> GetApiChangesWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAPIChangesApi : IAPIChangesApiSync, IAPIChangesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class APIChangesApi : IAPIChangesApi
    {
        private PTV.Developer.Clients.data.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="APIChangesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public APIChangesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIChangesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public APIChangesApi(string basePath)
        {
            this.Configuration = PTV.Developer.Clients.data.Client.Configuration.MergeConfigurations(
                PTV.Developer.Clients.data.Client.GlobalConfiguration.Instance,
                new PTV.Developer.Clients.data.Client.Configuration { BasePath = basePath }
            );
            this.Client = new PTV.Developer.Clients.data.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new PTV.Developer.Clients.data.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = PTV.Developer.Clients.data.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIChangesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public APIChangesApi(PTV.Developer.Clients.data.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = PTV.Developer.Clients.data.Client.Configuration.MergeConfigurations(
                PTV.Developer.Clients.data.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new PTV.Developer.Clients.data.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new PTV.Developer.Clients.data.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = PTV.Developer.Clients.data.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APIChangesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public APIChangesApi(PTV.Developer.Clients.data.Client.ISynchronousClient client, PTV.Developer.Clients.data.Client.IAsynchronousClient asyncClient, PTV.Developer.Clients.data.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = PTV.Developer.Clients.data.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public PTV.Developer.Clients.data.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public PTV.Developer.Clients.data.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public PTV.Developer.Clients.data.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public PTV.Developer.Clients.data.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        ///  Get all API changes for PTV Developer.
        /// </summary>
        /// <exception cref="PTV.Developer.Clients.data.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiChanges</returns>
        public ApiChanges GetApiChanges(int operationIndex = 0)
        {
            PTV.Developer.Clients.data.Client.ApiResponse<ApiChanges> localVarResponse = GetApiChangesWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Get all API changes for PTV Developer.
        /// </summary>
        /// <exception cref="PTV.Developer.Clients.data.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApiChanges</returns>
        public PTV.Developer.Clients.data.Client.ApiResponse<ApiChanges> GetApiChangesWithHttpInfo(int operationIndex = 0)
        {
            PTV.Developer.Clients.data.Client.RequestOptions localVarRequestOptions = new PTV.Developer.Clients.data.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = PTV.Developer.Clients.data.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = PTV.Developer.Clients.data.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "APIChangesApi.GetApiChanges";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (apiKeyAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apiKey")))
            {
                localVarRequestOptions.HeaderParameters.Add("apiKey", this.Configuration.GetApiKeyWithPrefix("apiKey"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<ApiChanges>("/api-changes", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetApiChanges", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Get all API changes for PTV Developer.
        /// </summary>
        /// <exception cref="PTV.Developer.Clients.data.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiChanges</returns>
        public async System.Threading.Tasks.Task<ApiChanges> GetApiChangesAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            PTV.Developer.Clients.data.Client.ApiResponse<ApiChanges> localVarResponse = await GetApiChangesWithHttpInfoAsync(operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Get all API changes for PTV Developer.
        /// </summary>
        /// <exception cref="PTV.Developer.Clients.data.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApiChanges)</returns>
        public async System.Threading.Tasks.Task<PTV.Developer.Clients.data.Client.ApiResponse<ApiChanges>> GetApiChangesWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {

            PTV.Developer.Clients.data.Client.RequestOptions localVarRequestOptions = new PTV.Developer.Clients.data.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = PTV.Developer.Clients.data.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = PTV.Developer.Clients.data.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "APIChangesApi.GetApiChanges";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (apiKeyAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apiKey")))
            {
                localVarRequestOptions.HeaderParameters.Add("apiKey", this.Configuration.GetApiKeyWithPrefix("apiKey"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<ApiChanges>("/api-changes", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetApiChanges", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
