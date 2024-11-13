/*
 * Data
 * With the Data service you can obtain additional data such as vehicle profiles.
 *
 * The version of the OpenAPI document: 1.12
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
import com.ptvgroup.developer.client.data.model.ApiChangeType;
import java.time.OffsetDateTime;
import java.util.Arrays;
import com.fasterxml.jackson.annotation.JsonPropertyOrder;


import com.ptvgroup.developer.client.data.ApiClient;
/**
 * ApiChange
 */
@JsonPropertyOrder({
  ApiChange.JSON_PROPERTY_TYPE,
  ApiChange.JSON_PROPERTY_DATE,
  ApiChange.JSON_PROPERTY_DESCRIPTION,
  ApiChange.JSON_PROPERTY_API,
  ApiChange.JSON_PROPERTY_VERSION,
  ApiChange.JSON_PROPERTY_LINK
})
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2024-11-13T09:18:43.600692627Z[Etc/UTC]", comments = "Generator version: 7.8.0")
public class ApiChange {
  public static final String JSON_PROPERTY_TYPE = "type";
  private ApiChangeType type;

  public static final String JSON_PROPERTY_DATE = "date";
  private OffsetDateTime date;

  public static final String JSON_PROPERTY_DESCRIPTION = "description";
  private String description;

  public static final String JSON_PROPERTY_API = "api";
  private String api;

  public static final String JSON_PROPERTY_VERSION = "version";
  private String version;

  public static final String JSON_PROPERTY_LINK = "link";
  private String link;

  public ApiChange() { 
  }

  public ApiChange type(ApiChangeType type) {
    this.type = type;
    return this;
  }

  /**
   * Get type
   * @return type
   */
  @javax.annotation.Nonnull
  @JsonProperty(JSON_PROPERTY_TYPE)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public ApiChangeType getType() {
    return type;
  }


  @JsonProperty(JSON_PROPERTY_TYPE)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setType(ApiChangeType type) {
    this.type = type;
  }


  public ApiChange date(OffsetDateTime date) {
    this.date = date;
    return this;
  }

  /**
   * The date this API change took effect. Formatted according to [RFC 3339](https://tools.ietf.org/html/rfc3339).
   * @return date
   */
  @javax.annotation.Nonnull
  @JsonProperty(JSON_PROPERTY_DATE)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public OffsetDateTime getDate() {
    return date;
  }


  @JsonProperty(JSON_PROPERTY_DATE)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setDate(OffsetDateTime date) {
    this.date = date;
  }


  public ApiChange description(String description) {
    this.description = description;
    return this;
  }

  /**
   * The API change description.
   * @return description
   */
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


  public ApiChange api(String api) {
    this.api = api;
    return this;
  }

  /**
   * The API the API change refers to.
   * @return api
   */
  @javax.annotation.Nullable
  @JsonProperty(JSON_PROPERTY_API)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public String getApi() {
    return api;
  }


  @JsonProperty(JSON_PROPERTY_API)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setApi(String api) {
    this.api = api;
  }


  public ApiChange version(String version) {
    this.version = version;
    return this;
  }

  /**
   * The version of the API the API change refers to.
   * @return version
   */
  @javax.annotation.Nullable
  @JsonProperty(JSON_PROPERTY_VERSION)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public String getVersion() {
    return version;
  }


  @JsonProperty(JSON_PROPERTY_VERSION)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setVersion(String version) {
    this.version = version;
  }


  public ApiChange link(String link) {
    this.link = link;
    return this;
  }

  /**
   * A link to a website with further information.
   * @return link
   */
  @javax.annotation.Nullable
  @JsonProperty(JSON_PROPERTY_LINK)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public String getLink() {
    return link;
  }


  @JsonProperty(JSON_PROPERTY_LINK)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setLink(String link) {
    this.link = link;
  }


  /**
   * Return true if this ApiChange object is equal to o.
   */
  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ApiChange apiChange = (ApiChange) o;
    return Objects.equals(this.type, apiChange.type) &&
        Objects.equals(this.date, apiChange.date) &&
        Objects.equals(this.description, apiChange.description) &&
        Objects.equals(this.api, apiChange.api) &&
        Objects.equals(this.version, apiChange.version) &&
        Objects.equals(this.link, apiChange.link);
  }

  @Override
  public int hashCode() {
    return Objects.hash(type, date, description, api, version, link);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ApiChange {\n");
    sb.append("    type: ").append(toIndentedString(type)).append("\n");
    sb.append("    date: ").append(toIndentedString(date)).append("\n");
    sb.append("    description: ").append(toIndentedString(description)).append("\n");
    sb.append("    api: ").append(toIndentedString(api)).append("\n");
    sb.append("    version: ").append(toIndentedString(version)).append("\n");
    sb.append("    link: ").append(toIndentedString(link)).append("\n");
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

    // add `type` to the URL query string
    if (getType() != null) {
      joiner.add(String.format("%stype%s=%s", prefix, suffix, URLEncoder.encode(ApiClient.valueToString(getType()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    // add `date` to the URL query string
    if (getDate() != null) {
      joiner.add(String.format("%sdate%s=%s", prefix, suffix, URLEncoder.encode(ApiClient.valueToString(getDate()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    // add `description` to the URL query string
    if (getDescription() != null) {
      joiner.add(String.format("%sdescription%s=%s", prefix, suffix, URLEncoder.encode(ApiClient.valueToString(getDescription()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    // add `api` to the URL query string
    if (getApi() != null) {
      joiner.add(String.format("%sapi%s=%s", prefix, suffix, URLEncoder.encode(ApiClient.valueToString(getApi()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    // add `version` to the URL query string
    if (getVersion() != null) {
      joiner.add(String.format("%sversion%s=%s", prefix, suffix, URLEncoder.encode(ApiClient.valueToString(getVersion()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    // add `link` to the URL query string
    if (getLink() != null) {
      joiner.add(String.format("%slink%s=%s", prefix, suffix, URLEncoder.encode(ApiClient.valueToString(getLink()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    return joiner.toString();
  }
}

