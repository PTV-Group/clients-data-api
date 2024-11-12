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
import com.ptvgroup.developer.client.data.model.Continent;
import com.ptvgroup.developer.client.data.model.MapFeatures;
import java.util.Arrays;
import com.fasterxml.jackson.annotation.JsonPropertyOrder;


import com.ptvgroup.developer.client.data.ApiClient;
/**
 * Base type for a geographical unit. Depending on how the data are built up a country can have subdivisions, e.g. a state in the US, or not. 
 */
@JsonPropertyOrder({
  GeographicalUnit.JSON_PROPERTY_CODE,
  GeographicalUnit.JSON_PROPERTY_COUNTRY,
  GeographicalUnit.JSON_PROPERTY_STATE,
  GeographicalUnit.JSON_PROPERTY_CONTINENT,
  GeographicalUnit.JSON_PROPERTY_FEATURES
})
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2024-11-12T07:34:48.896153411Z[Etc/UTC]", comments = "Generator version: 7.8.0")
public class GeographicalUnit {
  public static final String JSON_PROPERTY_CODE = "code";
  private String code;

  public static final String JSON_PROPERTY_COUNTRY = "country";
  private String country;

  public static final String JSON_PROPERTY_STATE = "state";
  private String state;

  public static final String JSON_PROPERTY_CONTINENT = "continent";
  private Continent continent;

  public static final String JSON_PROPERTY_FEATURES = "features";
  private MapFeatures features;

  public GeographicalUnit() { 
  }

  public GeographicalUnit code(String code) {
    this.code = code;
    return this;
  }

  /**
   * The code of the geographical unit represented by its code according to [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) or [ISO 3166-2](https://en.wikipedia.org/wiki/ISO_3166-2) if referring to a subdivision.
   * @return code
   */
  @javax.annotation.Nonnull
  @JsonProperty(JSON_PROPERTY_CODE)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public String getCode() {
    return code;
  }


  @JsonProperty(JSON_PROPERTY_CODE)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setCode(String code) {
    this.code = code;
  }


  public GeographicalUnit country(String country) {
    this.country = country;
    return this;
  }

  /**
   * The name of the country this geographical unit represents or belongs to.
   * @return country
   */
  @javax.annotation.Nonnull
  @JsonProperty(JSON_PROPERTY_COUNTRY)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public String getCountry() {
    return country;
  }


  @JsonProperty(JSON_PROPERTY_COUNTRY)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setCountry(String country) {
    this.country = country;
  }


  public GeographicalUnit state(String state) {
    this.state = state;
    return this;
  }

  /**
   * The name of the state this geographical unit represents. Not present if it represents a country.
   * @return state
   */
  @javax.annotation.Nullable
  @JsonProperty(JSON_PROPERTY_STATE)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public String getState() {
    return state;
  }


  @JsonProperty(JSON_PROPERTY_STATE)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setState(String state) {
    this.state = state;
  }


  public GeographicalUnit continent(Continent continent) {
    this.continent = continent;
    return this;
  }

  /**
   * Get continent
   * @return continent
   */
  @javax.annotation.Nonnull
  @JsonProperty(JSON_PROPERTY_CONTINENT)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public Continent getContinent() {
    return continent;
  }


  @JsonProperty(JSON_PROPERTY_CONTINENT)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setContinent(Continent continent) {
    this.continent = continent;
  }


  public GeographicalUnit features(MapFeatures features) {
    this.features = features;
    return this;
  }

  /**
   * Get features
   * @return features
   */
  @javax.annotation.Nonnull
  @JsonProperty(JSON_PROPERTY_FEATURES)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public MapFeatures getFeatures() {
    return features;
  }


  @JsonProperty(JSON_PROPERTY_FEATURES)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setFeatures(MapFeatures features) {
    this.features = features;
  }


  /**
   * Return true if this GeographicalUnit object is equal to o.
   */
  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    GeographicalUnit geographicalUnit = (GeographicalUnit) o;
    return Objects.equals(this.code, geographicalUnit.code) &&
        Objects.equals(this.country, geographicalUnit.country) &&
        Objects.equals(this.state, geographicalUnit.state) &&
        Objects.equals(this.continent, geographicalUnit.continent) &&
        Objects.equals(this.features, geographicalUnit.features);
  }

  @Override
  public int hashCode() {
    return Objects.hash(code, country, state, continent, features);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class GeographicalUnit {\n");
    sb.append("    code: ").append(toIndentedString(code)).append("\n");
    sb.append("    country: ").append(toIndentedString(country)).append("\n");
    sb.append("    state: ").append(toIndentedString(state)).append("\n");
    sb.append("    continent: ").append(toIndentedString(continent)).append("\n");
    sb.append("    features: ").append(toIndentedString(features)).append("\n");
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

    // add `code` to the URL query string
    if (getCode() != null) {
      joiner.add(String.format("%scode%s=%s", prefix, suffix, URLEncoder.encode(ApiClient.valueToString(getCode()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    // add `country` to the URL query string
    if (getCountry() != null) {
      joiner.add(String.format("%scountry%s=%s", prefix, suffix, URLEncoder.encode(ApiClient.valueToString(getCountry()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    // add `state` to the URL query string
    if (getState() != null) {
      joiner.add(String.format("%sstate%s=%s", prefix, suffix, URLEncoder.encode(ApiClient.valueToString(getState()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    // add `continent` to the URL query string
    if (getContinent() != null) {
      joiner.add(String.format("%scontinent%s=%s", prefix, suffix, URLEncoder.encode(ApiClient.valueToString(getContinent()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    // add `features` to the URL query string
    if (getFeatures() != null) {
      joiner.add(getFeatures().toUrlQueryString(prefix + "features" + suffix));
    }

    return joiner.toString();
  }
}

