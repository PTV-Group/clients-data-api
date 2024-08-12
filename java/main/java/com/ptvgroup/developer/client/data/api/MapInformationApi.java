/*
 * Data
 * With the Data service you can obtain additional data such as vehicle profiles.
 *
 * The version of the OpenAPI document: 1.11
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

package com.ptvgroup.developer.client.data.api;

import com.ptvgroup.developer.client.data.ApiClient;
import com.ptvgroup.developer.client.data.ApiException;
import com.ptvgroup.developer.client.data.ApiResponse;
import com.ptvgroup.developer.client.data.Pair;

import com.ptvgroup.developer.client.data.model.CombinedTransportByPosition;
import com.ptvgroup.developer.client.data.model.CombinedTransportByText;
import com.ptvgroup.developer.client.data.model.CombinedTransportsResponse;
import com.ptvgroup.developer.client.data.model.ErrorResponse;
import com.ptvgroup.developer.client.data.model.MapInformationResponse;
import com.ptvgroup.developer.client.data.model.PolylineFormat;

import com.fasterxml.jackson.core.type.TypeReference;
import com.fasterxml.jackson.databind.ObjectMapper;

import java.io.InputStream;
import java.io.ByteArrayInputStream;
import java.io.ByteArrayOutputStream;
import java.io.File;
import java.io.IOException;
import java.io.OutputStream;
import java.net.http.HttpRequest;
import java.nio.channels.Channels;
import java.nio.channels.Pipe;
import java.net.URI;
import java.net.http.HttpClient;
import java.net.http.HttpRequest;
import java.net.http.HttpResponse;
import java.time.Duration;

import java.util.ArrayList;
import java.util.StringJoiner;
import java.util.List;
import java.util.Map;
import java.util.Set;
import java.util.function.Consumer;

@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2024-08-12T08:25:08.031010947Z[Etc/UTC]", comments = "Generator version: 7.7.0")
public class MapInformationApi {
  private final HttpClient memberVarHttpClient;
  private final ObjectMapper memberVarObjectMapper;
  private final String memberVarBaseUri;
  private final Consumer<HttpRequest.Builder> memberVarInterceptor;
  private final Duration memberVarReadTimeout;
  private final Consumer<HttpResponse<InputStream>> memberVarResponseInterceptor;
  private final Consumer<HttpResponse<String>> memberVarAsyncResponseInterceptor;

  public MapInformationApi() {
    this(new ApiClient());
  }

  public MapInformationApi(ApiClient apiClient) {
    memberVarHttpClient = apiClient.getHttpClient();
    memberVarObjectMapper = apiClient.getObjectMapper();
    memberVarBaseUri = apiClient.getBaseUri();
    memberVarInterceptor = apiClient.getRequestInterceptor();
    memberVarReadTimeout = apiClient.getReadTimeout();
    memberVarResponseInterceptor = apiClient.getResponseInterceptor();
    memberVarAsyncResponseInterceptor = apiClient.getAsyncResponseInterceptor();
  }

  protected ApiException getApiException(String operationId, HttpResponse<InputStream> response) throws IOException {
    String body = response.body() == null ? null : new String(response.body().readAllBytes());
    String message = formatExceptionMessage(operationId, response.statusCode(), body);
    return new ApiException(response.statusCode(), message, response.headers(), body);
  }

  private String formatExceptionMessage(String operationId, int statusCode, String body) {
    if (body == null || body.isEmpty()) {
      body = "[no body]";
    }
    return operationId + " call failed with: " + statusCode + " - " + body;
  }

  /**
   * 
   * Get combined transports from a (click) point on a map or matching a given text input.  A request will be rejected if  * it covers more than 5000 combined transports or * if neither the parameter **position** nor the parameter **text** is specified.
   * @param position  (optional)
   * @param text  (optional)
   * @param polylineFormat  (optional, default to GEO_JSON)
   * @return CombinedTransportsResponse
   * @throws ApiException if fails to make API call
   */
  public CombinedTransportsResponse getCombinedTransports(CombinedTransportByPosition position, CombinedTransportByText text, PolylineFormat polylineFormat) throws ApiException {
    ApiResponse<CombinedTransportsResponse> localVarResponse = getCombinedTransportsWithHttpInfo(position, text, polylineFormat);
    return localVarResponse.getData();
  }

  /**
   * 
   * Get combined transports from a (click) point on a map or matching a given text input.  A request will be rejected if  * it covers more than 5000 combined transports or * if neither the parameter **position** nor the parameter **text** is specified.
   * @param position  (optional)
   * @param text  (optional)
   * @param polylineFormat  (optional, default to GEO_JSON)
   * @return ApiResponse&lt;CombinedTransportsResponse&gt;
   * @throws ApiException if fails to make API call
   */
  public ApiResponse<CombinedTransportsResponse> getCombinedTransportsWithHttpInfo(CombinedTransportByPosition position, CombinedTransportByText text, PolylineFormat polylineFormat) throws ApiException {
    HttpRequest.Builder localVarRequestBuilder = getCombinedTransportsRequestBuilder(position, text, polylineFormat);
    try {
      HttpResponse<InputStream> localVarResponse = memberVarHttpClient.send(
          localVarRequestBuilder.build(),
          HttpResponse.BodyHandlers.ofInputStream());
      if (memberVarResponseInterceptor != null) {
        memberVarResponseInterceptor.accept(localVarResponse);
      }
      try {
        if (localVarResponse.statusCode()/ 100 != 2) {
          throw getApiException("getCombinedTransports", localVarResponse);
        }
        return new ApiResponse<CombinedTransportsResponse>(
          localVarResponse.statusCode(),
          localVarResponse.headers().map(),
          localVarResponse.body() == null ? null : memberVarObjectMapper.readValue(localVarResponse.body(), new TypeReference<CombinedTransportsResponse>() {}) // closes the InputStream
        );
      } finally {
      }
    } catch (IOException e) {
      throw new ApiException(e);
    }
    catch (InterruptedException e) {
      Thread.currentThread().interrupt();
      throw new ApiException(e);
    }
  }

  private HttpRequest.Builder getCombinedTransportsRequestBuilder(CombinedTransportByPosition position, CombinedTransportByText text, PolylineFormat polylineFormat) throws ApiException {

    HttpRequest.Builder localVarRequestBuilder = HttpRequest.newBuilder();
		localVarRequestBuilder.header("User-Agent","ptv-generated java client");

    String localVarPath = "/combined-transports";

    List<Pair> localVarQueryParams = new ArrayList<>();
    StringJoiner localVarQueryStringJoiner = new StringJoiner("&");
    String localVarQueryParameterBaseName;
    localVarQueryParameterBaseName = "position";
    if (position != null) {
      String queryString = position.toUrlQueryString("position");
      if (!queryString.isBlank()) {
        localVarQueryStringJoiner.add(queryString);
      }
    }
    localVarQueryParameterBaseName = "text";
    if (text != null) {
      String queryString = text.toUrlQueryString("text");
      if (!queryString.isBlank()) {
        localVarQueryStringJoiner.add(queryString);
      }
    }
    localVarQueryParameterBaseName = "polylineFormat";
    localVarQueryParams.addAll(ApiClient.parameterToPairs("polylineFormat", polylineFormat));

    if (!localVarQueryParams.isEmpty() || localVarQueryStringJoiner.length() != 0) {
      StringJoiner queryJoiner = new StringJoiner("&");
      localVarQueryParams.forEach(p -> queryJoiner.add(p.getName() + '=' + p.getValue()));
      if (localVarQueryStringJoiner.length() != 0) {
        queryJoiner.add(localVarQueryStringJoiner.toString());
      }
      localVarRequestBuilder.uri(URI.create(memberVarBaseUri + localVarPath + '?' + queryJoiner.toString()));
    } else {
      localVarRequestBuilder.uri(URI.create(memberVarBaseUri + localVarPath));
    }

    localVarRequestBuilder.header("Accept", "application/json");

    localVarRequestBuilder.method("GET", HttpRequest.BodyPublishers.noBody());
    if (memberVarReadTimeout != null) {
      localVarRequestBuilder.timeout(memberVarReadTimeout);
    }
    if (memberVarInterceptor != null) {
      memberVarInterceptor.accept(localVarRequestBuilder);
    }
    return localVarRequestBuilder;
  }

  /**
   * 
   * Gets information about the map. See [here](./concepts/map-information) for more information.
   * @return MapInformationResponse
   * @throws ApiException if fails to make API call
   */
  public MapInformationResponse getMapInformation() throws ApiException {
    ApiResponse<MapInformationResponse> localVarResponse = getMapInformationWithHttpInfo();
    return localVarResponse.getData();
  }

  /**
   * 
   * Gets information about the map. See [here](./concepts/map-information) for more information.
   * @return ApiResponse&lt;MapInformationResponse&gt;
   * @throws ApiException if fails to make API call
   */
  public ApiResponse<MapInformationResponse> getMapInformationWithHttpInfo() throws ApiException {
    HttpRequest.Builder localVarRequestBuilder = getMapInformationRequestBuilder();
    try {
      HttpResponse<InputStream> localVarResponse = memberVarHttpClient.send(
          localVarRequestBuilder.build(),
          HttpResponse.BodyHandlers.ofInputStream());
      if (memberVarResponseInterceptor != null) {
        memberVarResponseInterceptor.accept(localVarResponse);
      }
      try {
        if (localVarResponse.statusCode()/ 100 != 2) {
          throw getApiException("getMapInformation", localVarResponse);
        }
        return new ApiResponse<MapInformationResponse>(
          localVarResponse.statusCode(),
          localVarResponse.headers().map(),
          localVarResponse.body() == null ? null : memberVarObjectMapper.readValue(localVarResponse.body(), new TypeReference<MapInformationResponse>() {}) // closes the InputStream
        );
      } finally {
      }
    } catch (IOException e) {
      throw new ApiException(e);
    }
    catch (InterruptedException e) {
      Thread.currentThread().interrupt();
      throw new ApiException(e);
    }
  }

  private HttpRequest.Builder getMapInformationRequestBuilder() throws ApiException {

    HttpRequest.Builder localVarRequestBuilder = HttpRequest.newBuilder();
		localVarRequestBuilder.header("User-Agent","ptv-generated java client");

    String localVarPath = "/map-information";

    localVarRequestBuilder.uri(URI.create(memberVarBaseUri + localVarPath));

    localVarRequestBuilder.header("Accept", "application/json");

    localVarRequestBuilder.method("GET", HttpRequest.BodyPublishers.noBody());
    if (memberVarReadTimeout != null) {
      localVarRequestBuilder.timeout(memberVarReadTimeout);
    }
    if (memberVarInterceptor != null) {
      memberVarInterceptor.accept(localVarRequestBuilder);
    }
    return localVarRequestBuilder;
  }

}
