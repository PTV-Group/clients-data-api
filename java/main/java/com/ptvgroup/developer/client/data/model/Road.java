/*
 * Data
 * With the Data service you can obtain additional data such as vehicle profiles.
 *
 * The version of the OpenAPI document: 1.13
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
import java.util.Arrays;
import com.fasterxml.jackson.annotation.JsonPropertyOrder;


import com.ptvgroup.developer.client.data.ApiClient;
/**
 * Road
 */
@JsonPropertyOrder({
  Road.JSON_PROPERTY_POLYLINE
})
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2024-11-18T14:13:44.232763015Z[Etc/UTC]", comments = "Generator version: 7.8.0")
public class Road {
  public static final String JSON_PROPERTY_POLYLINE = "polyline";
  private String polyline;

  public Road() { 
  }

  public Road polyline(String polyline) {
    this.polyline = polyline;
    return this;
  }

  /**
   * The polyline of the road in the format specified by **polylineFormat**.
   * @return polyline
   */
  @javax.annotation.Nullable
  @JsonProperty(JSON_PROPERTY_POLYLINE)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public String getPolyline() {
    return polyline;
  }


  @JsonProperty(JSON_PROPERTY_POLYLINE)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setPolyline(String polyline) {
    this.polyline = polyline;
  }


  /**
   * Return true if this Road object is equal to o.
   */
  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Road road = (Road) o;
    return Objects.equals(this.polyline, road.polyline);
  }

  @Override
  public int hashCode() {
    return Objects.hash(polyline);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Road {\n");
    sb.append("    polyline: ").append(toIndentedString(polyline)).append("\n");
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

    // add `polyline` to the URL query string
    if (getPolyline() != null) {
      joiner.add(String.format("%spolyline%s=%s", prefix, suffix, URLEncoder.encode(ApiClient.valueToString(getPolyline()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    return joiner.toString();
  }
}

