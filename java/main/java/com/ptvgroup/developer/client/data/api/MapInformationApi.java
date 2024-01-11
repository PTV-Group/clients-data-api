/*
 * Data
 * With the Data service you can obtain additional data such as vehicle profiles.
 *
 * The version of the OpenAPI document: 1.7
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

import com.ptvgroup.developer.client.data.model.ErrorResponse;
import com.ptvgroup.developer.client.data.model.MapInformationResponse;

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

@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2024-01-11T15:04:25.045174Z[Etc/UTC]")
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
   * Gets information about the map. See [here](./concepts/map-information) for more information.  This method is in an experimental state and may change at any time.
   * @return MapInformationResponse
   * @throws ApiException if fails to make API call
   */
  public MapInformationResponse getMapInformation() throws ApiException {
    ApiResponse<MapInformationResponse> localVarResponse = getMapInformationWithHttpInfo();
    return localVarResponse.getData();
  }

  /**
   * 
   * Gets information about the map. See [here](./concepts/map-information) for more information.  This method is in an experimental state and may change at any time.
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
