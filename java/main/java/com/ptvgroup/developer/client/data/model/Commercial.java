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
 * Properties of a vehicle from a commercial point of view.
 */
@JsonPropertyOrder({
  Commercial.JSON_PROPERTY_MANUFACTURER,
  Commercial.JSON_PROPERTY_MODEL,
  Commercial.JSON_PROPERTY_VARIANT,
  Commercial.JSON_PROPERTY_LAUNCH_YEAR
})
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2024-08-13T15:20:53.585799088Z[Etc/UTC]", comments = "Generator version: 7.7.0")
public class Commercial {
  public static final String JSON_PROPERTY_MANUFACTURER = "manufacturer";
  private String manufacturer;

  public static final String JSON_PROPERTY_MODEL = "model";
  private String model;

  public static final String JSON_PROPERTY_VARIANT = "variant";
  private String variant;

  public static final String JSON_PROPERTY_LAUNCH_YEAR = "launchYear";
  private Integer launchYear;

  public Commercial() { 
  }

  public Commercial manufacturer(String manufacturer) {
    this.manufacturer = manufacturer;
    return this;
  }

  /**
   * The producer of the vehicle.
   * @return manufacturer
   */
  @javax.annotation.Nonnull
  @JsonProperty(JSON_PROPERTY_MANUFACTURER)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public String getManufacturer() {
    return manufacturer;
  }


  @JsonProperty(JSON_PROPERTY_MANUFACTURER)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setManufacturer(String manufacturer) {
    this.manufacturer = manufacturer;
  }


  public Commercial model(String model) {
    this.model = model;
    return this;
  }

  /**
   * The model of the vehicle.
   * @return model
   */
  @javax.annotation.Nonnull
  @JsonProperty(JSON_PROPERTY_MODEL)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public String getModel() {
    return model;
  }


  @JsonProperty(JSON_PROPERTY_MODEL)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setModel(String model) {
    this.model = model;
  }


  public Commercial variant(String variant) {
    this.variant = variant;
    return this;
  }

  /**
   * The model variant of the vehicle.
   * @return variant
   */
  @javax.annotation.Nullable
  @JsonProperty(JSON_PROPERTY_VARIANT)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public String getVariant() {
    return variant;
  }


  @JsonProperty(JSON_PROPERTY_VARIANT)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setVariant(String variant) {
    this.variant = variant;
  }


  public Commercial launchYear(Integer launchYear) {
    this.launchYear = launchYear;
    return this;
  }

  /**
   * The year the vehicle was launched on the market.
   * minimum: 1900
   * @return launchYear
   */
  @javax.annotation.Nullable
  @JsonProperty(JSON_PROPERTY_LAUNCH_YEAR)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public Integer getLaunchYear() {
    return launchYear;
  }


  @JsonProperty(JSON_PROPERTY_LAUNCH_YEAR)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setLaunchYear(Integer launchYear) {
    this.launchYear = launchYear;
  }


  /**
   * Return true if this Commercial object is equal to o.
   */
  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Commercial commercial = (Commercial) o;
    return Objects.equals(this.manufacturer, commercial.manufacturer) &&
        Objects.equals(this.model, commercial.model) &&
        Objects.equals(this.variant, commercial.variant) &&
        Objects.equals(this.launchYear, commercial.launchYear);
  }

  @Override
  public int hashCode() {
    return Objects.hash(manufacturer, model, variant, launchYear);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Commercial {\n");
    sb.append("    manufacturer: ").append(toIndentedString(manufacturer)).append("\n");
    sb.append("    model: ").append(toIndentedString(model)).append("\n");
    sb.append("    variant: ").append(toIndentedString(variant)).append("\n");
    sb.append("    launchYear: ").append(toIndentedString(launchYear)).append("\n");
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

    // add `manufacturer` to the URL query string
    if (getManufacturer() != null) {
      joiner.add(String.format("%smanufacturer%s=%s", prefix, suffix, URLEncoder.encode(ApiClient.valueToString(getManufacturer()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    // add `model` to the URL query string
    if (getModel() != null) {
      joiner.add(String.format("%smodel%s=%s", prefix, suffix, URLEncoder.encode(ApiClient.valueToString(getModel()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    // add `variant` to the URL query string
    if (getVariant() != null) {
      joiner.add(String.format("%svariant%s=%s", prefix, suffix, URLEncoder.encode(ApiClient.valueToString(getVariant()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    // add `launchYear` to the URL query string
    if (getLaunchYear() != null) {
      joiner.add(String.format("%slaunchYear%s=%s", prefix, suffix, URLEncoder.encode(ApiClient.valueToString(getLaunchYear()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    return joiner.toString();
  }
}

