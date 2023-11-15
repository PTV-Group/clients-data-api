/*
 * Data
 * With the Data service you can obtain additional data such as vehicle profiles.
 *
 * The version of the OpenAPI document: 1.6
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package com.ptvgroup.developer.client.data.model;

import java.net.URLEncoder;
import java.nio.charset.StandardCharsets;
import java.util.StringJoiner;
import java.util.Objects;
import java.util.Map;
import java.util.HashMap;
import com.fasterxml.jackson.annotation.JsonInclude;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonCreator;
import com.fasterxml.jackson.annotation.JsonTypeName;
import com.fasterxml.jackson.annotation.JsonValue;
import com.ptvgroup.developer.client.data.model.CausingError;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import com.fasterxml.jackson.annotation.JsonPropertyOrder;


/**
 * ErrorResponse
 */
@JsonPropertyOrder({
  ErrorResponse.JSON_PROPERTY_DESCRIPTION,
  ErrorResponse.JSON_PROPERTY_ERROR_CODE,
  ErrorResponse.JSON_PROPERTY_TRACE_ID,
  ErrorResponse.JSON_PROPERTY_ERROR_ID,
  ErrorResponse.JSON_PROPERTY_CAUSES,
  ErrorResponse.JSON_PROPERTY_DETAILS
})
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2023-11-15T14:24:16.580606Z[Etc/UTC]")
public class ErrorResponse {
  public static final String JSON_PROPERTY_DESCRIPTION = "description";
  private String description;

  public static final String JSON_PROPERTY_ERROR_CODE = "errorCode";
  private String errorCode;

  public static final String JSON_PROPERTY_TRACE_ID = "traceId";
  private String traceId;

  public static final String JSON_PROPERTY_ERROR_ID = "errorId";
  private String errorId;

  public static final String JSON_PROPERTY_CAUSES = "causes";
  private List<CausingError> causes;

  public static final String JSON_PROPERTY_DETAILS = "details";
  private Map<String, Object> details = new HashMap<>();

  public ErrorResponse() { 
  }

  public ErrorResponse description(String description) {
    this.description = description;
    return this;
  }

   /**
   * A human readable message that describes the error.
   * @return description
  **/
  @javax.annotation.Nonnull
  @JsonProperty(JSON_PROPERTY_DESCRIPTION)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)

  public String getDescription() {
    return description;
  }


  @JsonProperty(JSON_PROPERTY_DESCRIPTION)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setDescription(String description) {
    this.description = description;
  }


  public ErrorResponse errorCode(String errorCode) {
    this.errorCode = errorCode;
    return this;
  }

   /**
   * A constant string that can be used to identify this error class programmatically. An errorCode can have **details** to provide information in additional properties which are described with the code they apply to. They are of type string unless otherwise specified. Note that additional errorCodes as well as the **details** of existing errorCodes may be added at any time. Furthermore, the **description** may change at any time.  **HTTP status code: 400** * &#x60;GENERAL_VALIDATION_ERROR&#x60; - The validation of the request failed. Details can be found in **causes**. * &#x60;GENERAL_PARSING_ERROR&#x60; - The JSON syntax is invalid. * &#x60;ROADATTRIBUTES_ERROR&#x60; - Processing the custom road attributes scenario failed. Details can be found in **causes**.  **HTTP status code: 401** * &#x60;GENERAL_UNAUTHENTICATED&#x60; - Invalid or missing authentication credentials.   * &#x60;message&#x60; - An additional error message.  **HTTP status code: 403** * &#x60;GENERAL_FORBIDDEN&#x60; - Insufficient access rights. * &#x60;GENERAL_QUOTA_EXCEEDED&#x60; - The transaction limit is exceeded.   * &#x60;message&#x60; - An additional error message. * &#x60;ROADATTRIBUTES_RESTRICTION_EXCEEDED&#x60; - A product-specific restriction is exceeded.  **HTTP status code: 404** * &#x60;GENERAL_RESOURCE_NOT_FOUND&#x60; - A requested resource does not exist.   * &#x60;message&#x60; - An additional error message.  **HTTP status code: 429** * &#x60;GENERAL_RATE_LIMIT_EXCEEDED&#x60; - The rate limit is exceeded.  **HTTP status code: 500** * &#x60;GENERAL_INTERNAL_SERVER_ERROR&#x60; - The request could not be processed due to an internal error.   * &#x60;message&#x60; - An additional error message.   * &#x60;hint&#x60; - A hint how to solve the problem.  **HTTP status code: 503** * &#x60;GENERAL_SERVICE_UNAVAILABLE&#x60; - The service is temporarily unavailable.  **HTTP status code: 4xx-5xx** * &#x60;GENERAL_INTERNAL_GATEWAY_ERROR&#x60; - The request could not be processed due to an internal gateway error.   * &#x60;hint&#x60; - A hint how to solve the problem.
   * @return errorCode
  **/
  @javax.annotation.Nonnull
  @JsonProperty(JSON_PROPERTY_ERROR_CODE)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)

  public String getErrorCode() {
    return errorCode;
  }


  @JsonProperty(JSON_PROPERTY_ERROR_CODE)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setErrorCode(String errorCode) {
    this.errorCode = errorCode;
  }


  public ErrorResponse traceId(String traceId) {
    this.traceId = traceId;
    return this;
  }

   /**
   * A unique identifier of the corresponding trace forest. It can be used to trace errors by the support.
   * @return traceId
  **/
  @javax.annotation.Nonnull
  @JsonProperty(JSON_PROPERTY_TRACE_ID)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)

  public String getTraceId() {
    return traceId;
  }


  @JsonProperty(JSON_PROPERTY_TRACE_ID)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setTraceId(String traceId) {
    this.traceId = traceId;
  }


  public ErrorResponse errorId(String errorId) {
    this.errorId = errorId;
    return this;
  }

   /**
   * A unique identifier specific to this error instance. It can be used to trace errors by the support.
   * @return errorId
  **/
  @javax.annotation.Nullable
  @JsonProperty(JSON_PROPERTY_ERROR_ID)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)

  public String getErrorId() {
    return errorId;
  }


  @JsonProperty(JSON_PROPERTY_ERROR_ID)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setErrorId(String errorId) {
    this.errorId = errorId;
  }


  public ErrorResponse causes(List<CausingError> causes) {
    this.causes = causes;
    return this;
  }

  public ErrorResponse addCausesItem(CausingError causesItem) {
    if (this.causes == null) {
      this.causes = new ArrayList<>();
    }
    this.causes.add(causesItem);
    return this;
  }

   /**
   * A list of affected parameters and/or properties that caused this error.
   * @return causes
  **/
  @javax.annotation.Nullable
  @JsonProperty(JSON_PROPERTY_CAUSES)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)

  public List<CausingError> getCauses() {
    return causes;
  }


  @JsonProperty(JSON_PROPERTY_CAUSES)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setCauses(List<CausingError> causes) {
    this.causes = causes;
  }


  public ErrorResponse details(Map<String, Object> details) {
    this.details = details;
    return this;
  }

  public ErrorResponse putDetailsItem(String key, Object detailsItem) {
    if (this.details == null) {
      this.details = new HashMap<>();
    }
    this.details.put(key, detailsItem);
    return this;
  }

   /**
   * Additional properties specific to this error class.
   * @return details
  **/
  @javax.annotation.Nullable
  @JsonProperty(JSON_PROPERTY_DETAILS)
  @JsonInclude(content = JsonInclude.Include.ALWAYS, value = JsonInclude.Include.USE_DEFAULTS)

  public Map<String, Object> getDetails() {
    return details;
  }


  @JsonProperty(JSON_PROPERTY_DETAILS)
  @JsonInclude(content = JsonInclude.Include.ALWAYS, value = JsonInclude.Include.USE_DEFAULTS)
  public void setDetails(Map<String, Object> details) {
    this.details = details;
  }


  /**
   * Return true if this ErrorResponse object is equal to o.
   */
  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ErrorResponse errorResponse = (ErrorResponse) o;
    return Objects.equals(this.description, errorResponse.description) &&
        Objects.equals(this.errorCode, errorResponse.errorCode) &&
        Objects.equals(this.traceId, errorResponse.traceId) &&
        Objects.equals(this.errorId, errorResponse.errorId) &&
        Objects.equals(this.causes, errorResponse.causes) &&
        Objects.equals(this.details, errorResponse.details);
  }

  @Override
  public int hashCode() {
    return Objects.hash(description, errorCode, traceId, errorId, causes, details);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ErrorResponse {\n");
    sb.append("    description: ").append(toIndentedString(description)).append("\n");
    sb.append("    errorCode: ").append(toIndentedString(errorCode)).append("\n");
    sb.append("    traceId: ").append(toIndentedString(traceId)).append("\n");
    sb.append("    errorId: ").append(toIndentedString(errorId)).append("\n");
    sb.append("    causes: ").append(toIndentedString(causes)).append("\n");
    sb.append("    details: ").append(toIndentedString(details)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

  /**
   * Convert the instance into URL query string.
   *
   * @return URL query string
   */
  public String toUrlQueryString() {
    return toUrlQueryString(null);
  }

  /**
   * Convert the instance into URL query string.
   *
   * @param prefix prefix of the query string
   * @return URL query string
   */
  public String toUrlQueryString(String prefix) {
    String suffix = "";
    String containerSuffix = "";
    String containerPrefix = "";
    if (prefix == null) {
      // style=form, explode=true, e.g. /pet?name=cat&type=manx
      prefix = "";
    } else {
      // deepObject style e.g. /pet?id[name]=cat&id[type]=manx
      prefix = prefix + "[";
      suffix = "]";
      containerSuffix = "]";
      containerPrefix = "[";
    }

    StringJoiner joiner = new StringJoiner("&");

    // add `description` to the URL query string
    if (getDescription() != null) {
      joiner.add(String.format("%sdescription%s=%s", prefix, suffix, URLEncoder.encode(String.valueOf(getDescription()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    // add `errorCode` to the URL query string
    if (getErrorCode() != null) {
      joiner.add(String.format("%serrorCode%s=%s", prefix, suffix, URLEncoder.encode(String.valueOf(getErrorCode()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    // add `traceId` to the URL query string
    if (getTraceId() != null) {
      joiner.add(String.format("%straceId%s=%s", prefix, suffix, URLEncoder.encode(String.valueOf(getTraceId()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    // add `errorId` to the URL query string
    if (getErrorId() != null) {
      joiner.add(String.format("%serrorId%s=%s", prefix, suffix, URLEncoder.encode(String.valueOf(getErrorId()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    // add `causes` to the URL query string
    if (getCauses() != null) {
      for (int i = 0; i < getCauses().size(); i++) {
        if (getCauses().get(i) != null) {
          joiner.add(getCauses().get(i).toUrlQueryString(String.format("%scauses%s%s", prefix, suffix,
          "".equals(suffix) ? "" : String.format("%s%d%s", containerPrefix, i, containerSuffix))));
        }
      }
    }

    // add `details` to the URL query string
    if (getDetails() != null) {
      for (String _key : getDetails().keySet()) {
        joiner.add(String.format("%sdetails%s%s=%s", prefix, suffix,
            "".equals(suffix) ? "" : String.format("%s%d%s", containerPrefix, _key, containerSuffix),
            getDetails().get(_key), URLEncoder.encode(String.valueOf(getDetails().get(_key)), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
      }
    }

    return joiner.toString();
  }
}

