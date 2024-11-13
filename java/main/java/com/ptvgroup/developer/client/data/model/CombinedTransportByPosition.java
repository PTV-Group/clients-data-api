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
import java.util.Arrays;
import com.fasterxml.jackson.annotation.JsonPropertyOrder;


import com.ptvgroup.developer.client.data.ApiClient;
/**
 * The position around which to scan for combined transports in the map data. This parameter is mutually exclusive with **text**.
 */
@JsonPropertyOrder({
  CombinedTransportByPosition.JSON_PROPERTY_LATITUDE,
  CombinedTransportByPosition.JSON_PROPERTY_LONGITUDE,
  CombinedTransportByPosition.JSON_PROPERTY_RADIUS
})
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2024-11-13T09:18:43.600692627Z[Etc/UTC]", comments = "Generator version: 7.8.0")
public class CombinedTransportByPosition {
  public static final String JSON_PROPERTY_LATITUDE = "latitude";
  private Double latitude;

  public static final String JSON_PROPERTY_LONGITUDE = "longitude";
  private Double longitude;

  public static final String JSON_PROPERTY_RADIUS = "radius";
  private Integer radius = 5000;

  public CombinedTransportByPosition() { 
  }

  public CombinedTransportByPosition latitude(Double latitude) {
    this.latitude = latitude;
    return this;
  }

  /**
   * The latitude value in degrees (WGS84/EPSG:4326) from south to north.
   * minimum: -90
   * maximum: 90
   * @return latitude
   */
  @javax.annotation.Nonnull
  @JsonProperty(JSON_PROPERTY_LATITUDE)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public Double getLatitude() {
    return latitude;
  }


  @JsonProperty(JSON_PROPERTY_LATITUDE)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setLatitude(Double latitude) {
    this.latitude = latitude;
  }


  public CombinedTransportByPosition longitude(Double longitude) {
    this.longitude = longitude;
    return this;
  }

  /**
   * The longitude value in degrees (WGS84/EPSG:4326) from west to east.
   * minimum: -180
   * maximum: 180
   * @return longitude
   */
  @javax.annotation.Nonnull
  @JsonProperty(JSON_PROPERTY_LONGITUDE)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public Double getLongitude() {
    return longitude;
  }


  @JsonProperty(JSON_PROPERTY_LONGITUDE)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setLongitude(Double longitude) {
    this.longitude = longitude;
  }


  public CombinedTransportByPosition radius(Integer radius) {
    this.radius = radius;
    return this;
  }

  /**
   * The circle defined by the given point and this radius [m] in which to scan for combined transports.
   * minimum: 1
   * @return radius
   */
  @javax.annotation.Nullable
  @JsonProperty(JSON_PROPERTY_RADIUS)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public Integer getRadius() {
    return radius;
  }


  @JsonProperty(JSON_PROPERTY_RADIUS)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setRadius(Integer radius) {
    this.radius = radius;
  }


  /**
   * Return true if this CombinedTransportByPosition object is equal to o.
   */
  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    CombinedTransportByPosition combinedTransportByPosition = (CombinedTransportByPosition) o;
    return Objects.equals(this.latitude, combinedTransportByPosition.latitude) &&
        Objects.equals(this.longitude, combinedTransportByPosition.longitude) &&
        Objects.equals(this.radius, combinedTransportByPosition.radius);
  }

  @Override
  public int hashCode() {
    return Objects.hash(latitude, longitude, radius);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class CombinedTransportByPosition {\n");
    sb.append("    latitude: ").append(toIndentedString(latitude)).append("\n");
    sb.append("    longitude: ").append(toIndentedString(longitude)).append("\n");
    sb.append("    radius: ").append(toIndentedString(radius)).append("\n");
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

    // add `latitude` to the URL query string
    if (getLatitude() != null) {
      joiner.add(String.format("%slatitude%s=%s", prefix, suffix, URLEncoder.encode(ApiClient.valueToString(getLatitude()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    // add `longitude` to the URL query string
    if (getLongitude() != null) {
      joiner.add(String.format("%slongitude%s=%s", prefix, suffix, URLEncoder.encode(ApiClient.valueToString(getLongitude()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    // add `radius` to the URL query string
    if (getRadius() != null) {
      joiner.add(String.format("%sradius%s=%s", prefix, suffix, URLEncoder.encode(ApiClient.valueToString(getRadius()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    return joiner.toString();
  }
}

