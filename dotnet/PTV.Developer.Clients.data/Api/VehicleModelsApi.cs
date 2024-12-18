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
    public interface IVehicleModelsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// A list of **VehicleModel** objects. Only vehicle models matching all filters are returned. In case that no vehicle model is found an empty list is returned. In case no filters are applied, all available vehicle models are returned.  This method is in a preview state, the API is stable, feature changes could be introduced in future.
        /// </remarks>
        /// <exception cref="PTV.Developer.Clients.data.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identification">String which must be contained in the vehicle model or the vehicle variant. See **commercial** in the response. (optional)</param>
        /// <param name="vehicleTypes">A comma-separated list of vehicle types. See **vehicleType** in the response. The following vehicle types are supported.  Tractor-like vehicle types: * &#x60;TRUCK&#x60; - Truck. Total permitted weight &gt; 7.5t. * &#x60;LCV&#x60; - Light Commercial Vehicle. Total permitted weight &lt; 7.5t. * &#x60;SCV&#x60; - Small Commercial Vehicle. Total permitted weight &lt; 3.5t.  Trailer-like vehicle types: * &#x60;TRAILER&#x60; - Trailer * &#x60;SEMI_TRAILER&#x60; - Semi-trailer * &#x60;BODY&#x60; - Body  This list can be extended at any time. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>VehicleModels</returns>
        VehicleModels GetVehicleModels(string? identification = default(string?), List<string>? vehicleTypes = default(List<string>?), int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// A list of **VehicleModel** objects. Only vehicle models matching all filters are returned. In case that no vehicle model is found an empty list is returned. In case no filters are applied, all available vehicle models are returned.  This method is in a preview state, the API is stable, feature changes could be introduced in future.
        /// </remarks>
        /// <exception cref="PTV.Developer.Clients.data.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identification">String which must be contained in the vehicle model or the vehicle variant. See **commercial** in the response. (optional)</param>
        /// <param name="vehicleTypes">A comma-separated list of vehicle types. See **vehicleType** in the response. The following vehicle types are supported.  Tractor-like vehicle types: * &#x60;TRUCK&#x60; - Truck. Total permitted weight &gt; 7.5t. * &#x60;LCV&#x60; - Light Commercial Vehicle. Total permitted weight &lt; 7.5t. * &#x60;SCV&#x60; - Small Commercial Vehicle. Total permitted weight &lt; 3.5t.  Trailer-like vehicle types: * &#x60;TRAILER&#x60; - Trailer * &#x60;SEMI_TRAILER&#x60; - Semi-trailer * &#x60;BODY&#x60; - Body  This list can be extended at any time. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of VehicleModels</returns>
        ApiResponse<VehicleModels> GetVehicleModelsWithHttpInfo(string? identification = default(string?), List<string>? vehicleTypes = default(List<string>?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IVehicleModelsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// A list of **VehicleModel** objects. Only vehicle models matching all filters are returned. In case that no vehicle model is found an empty list is returned. In case no filters are applied, all available vehicle models are returned.  This method is in a preview state, the API is stable, feature changes could be introduced in future.
        /// </remarks>
        /// <exception cref="PTV.Developer.Clients.data.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identification">String which must be contained in the vehicle model or the vehicle variant. See **commercial** in the response. (optional)</param>
        /// <param name="vehicleTypes">A comma-separated list of vehicle types. See **vehicleType** in the response. The following vehicle types are supported.  Tractor-like vehicle types: * &#x60;TRUCK&#x60; - Truck. Total permitted weight &gt; 7.5t. * &#x60;LCV&#x60; - Light Commercial Vehicle. Total permitted weight &lt; 7.5t. * &#x60;SCV&#x60; - Small Commercial Vehicle. Total permitted weight &lt; 3.5t.  Trailer-like vehicle types: * &#x60;TRAILER&#x60; - Trailer * &#x60;SEMI_TRAILER&#x60; - Semi-trailer * &#x60;BODY&#x60; - Body  This list can be extended at any time. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VehicleModels</returns>
        System.Threading.Tasks.Task<VehicleModels> GetVehicleModelsAsync(string? identification = default(string?), List<string>? vehicleTypes = default(List<string>?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// A list of **VehicleModel** objects. Only vehicle models matching all filters are returned. In case that no vehicle model is found an empty list is returned. In case no filters are applied, all available vehicle models are returned.  This method is in a preview state, the API is stable, feature changes could be introduced in future.
        /// </remarks>
        /// <exception cref="PTV.Developer.Clients.data.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identification">String which must be contained in the vehicle model or the vehicle variant. See **commercial** in the response. (optional)</param>
        /// <param name="vehicleTypes">A comma-separated list of vehicle types. See **vehicleType** in the response. The following vehicle types are supported.  Tractor-like vehicle types: * &#x60;TRUCK&#x60; - Truck. Total permitted weight &gt; 7.5t. * &#x60;LCV&#x60; - Light Commercial Vehicle. Total permitted weight &lt; 7.5t. * &#x60;SCV&#x60; - Small Commercial Vehicle. Total permitted weight &lt; 3.5t.  Trailer-like vehicle types: * &#x60;TRAILER&#x60; - Trailer * &#x60;SEMI_TRAILER&#x60; - Semi-trailer * &#x60;BODY&#x60; - Body  This list can be extended at any time. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VehicleModels)</returns>
        System.Threading.Tasks.Task<ApiResponse<VehicleModels>> GetVehicleModelsWithHttpInfoAsync(string? identification = default(string?), List<string>? vehicleTypes = default(List<string>?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IVehicleModelsApi : IVehicleModelsApiSync, IVehicleModelsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class VehicleModelsApi : IVehicleModelsApi
    {
        private PTV.Developer.Clients.data.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleModelsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VehicleModelsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleModelsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VehicleModelsApi(string basePath)
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
        /// Initializes a new instance of the <see cref="VehicleModelsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public VehicleModelsApi(PTV.Developer.Clients.data.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="VehicleModelsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public VehicleModelsApi(PTV.Developer.Clients.data.Client.ISynchronousClient client, PTV.Developer.Clients.data.Client.IAsynchronousClient asyncClient, PTV.Developer.Clients.data.Client.IReadableConfiguration configuration)
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
        ///  A list of **VehicleModel** objects. Only vehicle models matching all filters are returned. In case that no vehicle model is found an empty list is returned. In case no filters are applied, all available vehicle models are returned.  This method is in a preview state, the API is stable, feature changes could be introduced in future.
        /// </summary>
        /// <exception cref="PTV.Developer.Clients.data.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identification">String which must be contained in the vehicle model or the vehicle variant. See **commercial** in the response. (optional)</param>
        /// <param name="vehicleTypes">A comma-separated list of vehicle types. See **vehicleType** in the response. The following vehicle types are supported.  Tractor-like vehicle types: * &#x60;TRUCK&#x60; - Truck. Total permitted weight &gt; 7.5t. * &#x60;LCV&#x60; - Light Commercial Vehicle. Total permitted weight &lt; 7.5t. * &#x60;SCV&#x60; - Small Commercial Vehicle. Total permitted weight &lt; 3.5t.  Trailer-like vehicle types: * &#x60;TRAILER&#x60; - Trailer * &#x60;SEMI_TRAILER&#x60; - Semi-trailer * &#x60;BODY&#x60; - Body  This list can be extended at any time. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>VehicleModels</returns>
        public VehicleModels GetVehicleModels(string? identification = default(string?), List<string>? vehicleTypes = default(List<string>?), int operationIndex = 0)
        {
            PTV.Developer.Clients.data.Client.ApiResponse<VehicleModels> localVarResponse = GetVehicleModelsWithHttpInfo(identification, vehicleTypes);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  A list of **VehicleModel** objects. Only vehicle models matching all filters are returned. In case that no vehicle model is found an empty list is returned. In case no filters are applied, all available vehicle models are returned.  This method is in a preview state, the API is stable, feature changes could be introduced in future.
        /// </summary>
        /// <exception cref="PTV.Developer.Clients.data.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identification">String which must be contained in the vehicle model or the vehicle variant. See **commercial** in the response. (optional)</param>
        /// <param name="vehicleTypes">A comma-separated list of vehicle types. See **vehicleType** in the response. The following vehicle types are supported.  Tractor-like vehicle types: * &#x60;TRUCK&#x60; - Truck. Total permitted weight &gt; 7.5t. * &#x60;LCV&#x60; - Light Commercial Vehicle. Total permitted weight &lt; 7.5t. * &#x60;SCV&#x60; - Small Commercial Vehicle. Total permitted weight &lt; 3.5t.  Trailer-like vehicle types: * &#x60;TRAILER&#x60; - Trailer * &#x60;SEMI_TRAILER&#x60; - Semi-trailer * &#x60;BODY&#x60; - Body  This list can be extended at any time. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of VehicleModels</returns>
        public PTV.Developer.Clients.data.Client.ApiResponse<VehicleModels> GetVehicleModelsWithHttpInfo(string? identification = default(string?), List<string>? vehicleTypes = default(List<string>?), int operationIndex = 0)
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

            if (identification != null)
            {
                localVarRequestOptions.QueryParameters.Add(PTV.Developer.Clients.data.Client.ClientUtils.ParameterToMultiMap("", "identification", identification));
            }
            if (vehicleTypes != null)
            {
                localVarRequestOptions.QueryParameters.Add(PTV.Developer.Clients.data.Client.ClientUtils.ParameterToMultiMap("csv", "vehicleTypes", vehicleTypes));
            }

            localVarRequestOptions.Operation = "VehicleModelsApi.GetVehicleModels";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (apiKeyAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apiKey")))
            {
                localVarRequestOptions.HeaderParameters.Add("apiKey", this.Configuration.GetApiKeyWithPrefix("apiKey"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<VehicleModels>("/vehicle-models", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetVehicleModels", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  A list of **VehicleModel** objects. Only vehicle models matching all filters are returned. In case that no vehicle model is found an empty list is returned. In case no filters are applied, all available vehicle models are returned.  This method is in a preview state, the API is stable, feature changes could be introduced in future.
        /// </summary>
        /// <exception cref="PTV.Developer.Clients.data.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identification">String which must be contained in the vehicle model or the vehicle variant. See **commercial** in the response. (optional)</param>
        /// <param name="vehicleTypes">A comma-separated list of vehicle types. See **vehicleType** in the response. The following vehicle types are supported.  Tractor-like vehicle types: * &#x60;TRUCK&#x60; - Truck. Total permitted weight &gt; 7.5t. * &#x60;LCV&#x60; - Light Commercial Vehicle. Total permitted weight &lt; 7.5t. * &#x60;SCV&#x60; - Small Commercial Vehicle. Total permitted weight &lt; 3.5t.  Trailer-like vehicle types: * &#x60;TRAILER&#x60; - Trailer * &#x60;SEMI_TRAILER&#x60; - Semi-trailer * &#x60;BODY&#x60; - Body  This list can be extended at any time. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VehicleModels</returns>
        public async System.Threading.Tasks.Task<VehicleModels> GetVehicleModelsAsync(string? identification = default(string?), List<string>? vehicleTypes = default(List<string>?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            PTV.Developer.Clients.data.Client.ApiResponse<VehicleModels> localVarResponse = await GetVehicleModelsWithHttpInfoAsync(identification, vehicleTypes, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  A list of **VehicleModel** objects. Only vehicle models matching all filters are returned. In case that no vehicle model is found an empty list is returned. In case no filters are applied, all available vehicle models are returned.  This method is in a preview state, the API is stable, feature changes could be introduced in future.
        /// </summary>
        /// <exception cref="PTV.Developer.Clients.data.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="identification">String which must be contained in the vehicle model or the vehicle variant. See **commercial** in the response. (optional)</param>
        /// <param name="vehicleTypes">A comma-separated list of vehicle types. See **vehicleType** in the response. The following vehicle types are supported.  Tractor-like vehicle types: * &#x60;TRUCK&#x60; - Truck. Total permitted weight &gt; 7.5t. * &#x60;LCV&#x60; - Light Commercial Vehicle. Total permitted weight &lt; 7.5t. * &#x60;SCV&#x60; - Small Commercial Vehicle. Total permitted weight &lt; 3.5t.  Trailer-like vehicle types: * &#x60;TRAILER&#x60; - Trailer * &#x60;SEMI_TRAILER&#x60; - Semi-trailer * &#x60;BODY&#x60; - Body  This list can be extended at any time. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VehicleModels)</returns>
        public async System.Threading.Tasks.Task<PTV.Developer.Clients.data.Client.ApiResponse<VehicleModels>> GetVehicleModelsWithHttpInfoAsync(string? identification = default(string?), List<string>? vehicleTypes = default(List<string>?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
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

            if (identification != null)
            {
                localVarRequestOptions.QueryParameters.Add(PTV.Developer.Clients.data.Client.ClientUtils.ParameterToMultiMap("", "identification", identification));
            }
            if (vehicleTypes != null)
            {
                localVarRequestOptions.QueryParameters.Add(PTV.Developer.Clients.data.Client.ClientUtils.ParameterToMultiMap("csv", "vehicleTypes", vehicleTypes));
            }

            localVarRequestOptions.Operation = "VehicleModelsApi.GetVehicleModels";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (apiKeyAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apiKey")))
            {
                localVarRequestOptions.HeaderParameters.Add("apiKey", this.Configuration.GetApiKeyWithPrefix("apiKey"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<VehicleModels>("/vehicle-models", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetVehicleModels", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
