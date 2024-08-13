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
 * The attributes assigned to each of the selected roads.
 */
@JsonPropertyOrder({
  RoadAttributes.JSON_PROPERTY_PROHIBITED,
  RoadAttributes.JSON_PROPERTY_RELATIVE_SPEED
})
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2024-08-13T15:20:53.585799088Z[Etc/UTC]", comments = "Generator version: 7.7.0")
public class RoadAttributes {
  public static final String JSON_PROPERTY_PROHIBITED = "prohibited";
  private Boolean prohibited;

  public static final String JSON_PROPERTY_RELATIVE_SPEED = "relativeSpeed";
  private Integer relativeSpeed;

  public RoadAttributes() { 
  }

  public RoadAttributes prohibited(Boolean prohibited) {
    this.prohibited = prohibited;
    return this;
  }

  /**
   * The road is prohibited, it will not be used in route calculation. Setting this value to false does not have a meaning.
   * @return prohibited
   */
  @javax.annotation.Nullable
  @JsonProperty(JSON_PROPERTY_PROHIBITED)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public Boolean getProhibited() {
    return prohibited;
  }


  @JsonProperty(JSON_PROPERTY_PROHIBITED)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setProhibited(Boolean prohibited) {
    this.prohibited = prohibited;
  }


  public RoadAttributes relativeSpeed(Integer relativeSpeed) {
    this.relativeSpeed = relativeSpeed;
    return this;
  }

  /**
   * The driving speed on this road is set relative to this value [%]. This is useful when, for example, dense traffic is known or expected due to public events or because lanes are closed. Settings this value to 70 means that the driving speed is 70% of the originally assumed driving speed.
   * minimum: 1
   * maximum: 99
   * @return relativeSpeed
   */
  @javax.annotation.Nullable
  @JsonProperty(JSON_PROPERTY_RELATIVE_SPEED)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public Integer getRelativeSpeed() {
    return relativeSpeed;
  }


  @JsonProperty(JSON_PROPERTY_RELATIVE_SPEED)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setRelativeSpeed(Integer relativeSpeed) {
    this.relativeSpeed = relativeSpeed;
  }


  /**
   * Return true if this RoadAttributes object is equal to o.
   */
  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    RoadAttributes roadAttributes = (RoadAttributes) o;
    return Objects.equals(this.prohibited, roadAttributes.prohibited) &&
        Objects.equals(this.relativeSpeed, roadAttributes.relativeSpeed);
  }

  @Override
  public int hashCode() {
    return Objects.hash(prohibited, relativeSpeed);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class RoadAttributes {\n");
    sb.append("    prohibited: ").append(toIndentedString(prohibited)).append("\n");
    sb.append("    relativeSpeed: ").append(toIndentedString(relativeSpeed)).append("\n");
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

    // add `prohibited` to the URL query string
    if (getProhibited() != null) {
      joiner.add(String.format("%sprohibited%s=%s", prefix, suffix, URLEncoder.encode(ApiClient.valueToString(getProhibited()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    // add `relativeSpeed` to the URL query string
    if (getRelativeSpeed() != null) {
      joiner.add(String.format("%srelativeSpeed%s=%s", prefix, suffix, URLEncoder.encode(ApiClient.valueToString(getRelativeSpeed()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    return joiner.toString();
  }
}

