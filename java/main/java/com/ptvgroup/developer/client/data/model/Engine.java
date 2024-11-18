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
import com.ptvgroup.developer.client.data.model.EmissionStandard;
import com.ptvgroup.developer.client.data.model.EngineType;
import java.util.Arrays;
import com.fasterxml.jackson.annotation.JsonPropertyOrder;


import com.ptvgroup.developer.client.data.ApiClient;
/**
 * Physical and legal properties of the engine of a vehicle. It is null for an unpowered vehicle.
 */
@JsonPropertyOrder({
  Engine.JSON_PROPERTY_ENGINE_TYPE,
  Engine.JSON_PROPERTY_MAXIMUM_SPEED,
  Engine.JSON_PROPERTY_ECO_SPEED,
  Engine.JSON_PROPERTY_EMISSION_STANDARD,
  Engine.JSON_PROPERTY_POWER,
  Engine.JSON_PROPERTY_OFFICIAL_RANGE
})
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2024-11-18T14:13:44.232763015Z[Etc/UTC]", comments = "Generator version: 7.8.0")
public class Engine {
  public static final String JSON_PROPERTY_ENGINE_TYPE = "engineType";
  private EngineType engineType;

  public static final String JSON_PROPERTY_MAXIMUM_SPEED = "maximumSpeed";
  private Integer maximumSpeed;

  public static final String JSON_PROPERTY_ECO_SPEED = "ecoSpeed";
  private Integer ecoSpeed;

  public static final String JSON_PROPERTY_EMISSION_STANDARD = "emissionStandard";
  private EmissionStandard emissionStandard;

  public static final String JSON_PROPERTY_POWER = "power";
  private Integer power;

  public static final String JSON_PROPERTY_OFFICIAL_RANGE = "officialRange";
  private Integer officialRange;

  public Engine() { 
  }

  public Engine engineType(EngineType engineType) {
    this.engineType = engineType;
    return this;
  }

  /**
   * Get engineType
   * @return engineType
   */
  @javax.annotation.Nonnull
  @JsonProperty(JSON_PROPERTY_ENGINE_TYPE)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public EngineType getEngineType() {
    return engineType;
  }


  @JsonProperty(JSON_PROPERTY_ENGINE_TYPE)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setEngineType(EngineType engineType) {
    this.engineType = engineType;
  }


  public Engine maximumSpeed(Integer maximumSpeed) {
    this.maximumSpeed = maximumSpeed;
    return this;
  }

  /**
   * Maximum travel speed [km/h].  Relevant for &#x60;range calculation&#x60;. 
   * @return maximumSpeed
   */
  @javax.annotation.Nonnull
  @JsonProperty(JSON_PROPERTY_MAXIMUM_SPEED)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public Integer getMaximumSpeed() {
    return maximumSpeed;
  }


  @JsonProperty(JSON_PROPERTY_MAXIMUM_SPEED)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setMaximumSpeed(Integer maximumSpeed) {
    this.maximumSpeed = maximumSpeed;
  }


  public Engine ecoSpeed(Integer ecoSpeed) {
    this.ecoSpeed = ecoSpeed;
    return this;
  }

  /**
   * Recommended, reduced speed to ensure high efficiency [km/h].  Relevant for &#x60;range calculation&#x60;. 
   * @return ecoSpeed
   */
  @javax.annotation.Nonnull
  @JsonProperty(JSON_PROPERTY_ECO_SPEED)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public Integer getEcoSpeed() {
    return ecoSpeed;
  }


  @JsonProperty(JSON_PROPERTY_ECO_SPEED)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setEcoSpeed(Integer ecoSpeed) {
    this.ecoSpeed = ecoSpeed;
  }


  public Engine emissionStandard(EmissionStandard emissionStandard) {
    this.emissionStandard = emissionStandard;
    return this;
  }

  /**
   * Get emissionStandard
   * @return emissionStandard
   */
  @javax.annotation.Nonnull
  @JsonProperty(JSON_PROPERTY_EMISSION_STANDARD)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public EmissionStandard getEmissionStandard() {
    return emissionStandard;
  }


  @JsonProperty(JSON_PROPERTY_EMISSION_STANDARD)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setEmissionStandard(EmissionStandard emissionStandard) {
    this.emissionStandard = emissionStandard;
  }


  public Engine power(Integer power) {
    this.power = power;
    return this;
  }

  /**
   * The maximum available power of the vehicle [kW].
   * @return power
   */
  @javax.annotation.Nullable
  @JsonProperty(JSON_PROPERTY_POWER)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public Integer getPower() {
    return power;
  }


  @JsonProperty(JSON_PROPERTY_POWER)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setPower(Integer power) {
    this.power = power;
  }


  public Engine officialRange(Integer officialRange) {
    this.officialRange = officialRange;
    return this;
  }

  /**
   * The manufacturer given official range of the vehicle with this drive train [km].
   * @return officialRange
   */
  @javax.annotation.Nullable
  @JsonProperty(JSON_PROPERTY_OFFICIAL_RANGE)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public Integer getOfficialRange() {
    return officialRange;
  }


  @JsonProperty(JSON_PROPERTY_OFFICIAL_RANGE)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setOfficialRange(Integer officialRange) {
    this.officialRange = officialRange;
  }


  /**
   * Return true if this Engine object is equal to o.
   */
  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Engine engine = (Engine) o;
    return Objects.equals(this.engineType, engine.engineType) &&
        Objects.equals(this.maximumSpeed, engine.maximumSpeed) &&
        Objects.equals(this.ecoSpeed, engine.ecoSpeed) &&
        Objects.equals(this.emissionStandard, engine.emissionStandard) &&
        Objects.equals(this.power, engine.power) &&
        Objects.equals(this.officialRange, engine.officialRange);
  }

  @Override
  public int hashCode() {
    return Objects.hash(engineType, maximumSpeed, ecoSpeed, emissionStandard, power, officialRange);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Engine {\n");
    sb.append("    engineType: ").append(toIndentedString(engineType)).append("\n");
    sb.append("    maximumSpeed: ").append(toIndentedString(maximumSpeed)).append("\n");
    sb.append("    ecoSpeed: ").append(toIndentedString(ecoSpeed)).append("\n");
    sb.append("    emissionStandard: ").append(toIndentedString(emissionStandard)).append("\n");
    sb.append("    power: ").append(toIndentedString(power)).append("\n");
    sb.append("    officialRange: ").append(toIndentedString(officialRange)).append("\n");
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

    // add `engineType` to the URL query string
    if (getEngineType() != null) {
      joiner.add(String.format("%sengineType%s=%s", prefix, suffix, URLEncoder.encode(ApiClient.valueToString(getEngineType()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    // add `maximumSpeed` to the URL query string
    if (getMaximumSpeed() != null) {
      joiner.add(String.format("%smaximumSpeed%s=%s", prefix, suffix, URLEncoder.encode(ApiClient.valueToString(getMaximumSpeed()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    // add `ecoSpeed` to the URL query string
    if (getEcoSpeed() != null) {
      joiner.add(String.format("%secoSpeed%s=%s", prefix, suffix, URLEncoder.encode(ApiClient.valueToString(getEcoSpeed()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    // add `emissionStandard` to the URL query string
    if (getEmissionStandard() != null) {
      joiner.add(String.format("%semissionStandard%s=%s", prefix, suffix, URLEncoder.encode(ApiClient.valueToString(getEmissionStandard()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    // add `power` to the URL query string
    if (getPower() != null) {
      joiner.add(String.format("%spower%s=%s", prefix, suffix, URLEncoder.encode(ApiClient.valueToString(getPower()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    // add `officialRange` to the URL query string
    if (getOfficialRange() != null) {
      joiner.add(String.format("%sofficialRange%s=%s", prefix, suffix, URLEncoder.encode(ApiClient.valueToString(getOfficialRange()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    return joiner.toString();
  }
}

