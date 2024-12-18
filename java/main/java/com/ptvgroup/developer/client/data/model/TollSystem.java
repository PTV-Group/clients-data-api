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
import com.ptvgroup.developer.client.data.model.TariffVersion;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import com.fasterxml.jackson.annotation.JsonPropertyOrder;


import com.ptvgroup.developer.client.data.ApiClient;
/**
 * Contains information about the toll system such as the name, operator and especially the different tariff versions that are currently available.
 */
@JsonPropertyOrder({
  TollSystem.JSON_PROPERTY_NAME,
  TollSystem.JSON_PROPERTY_OPERATOR,
  TollSystem.JSON_PROPERTY_TARIFF_VERSIONS
})
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2024-11-18T14:13:44.232763015Z[Etc/UTC]", comments = "Generator version: 7.8.0")
public class TollSystem {
  public static final String JSON_PROPERTY_NAME = "name";
  private String name;

  public static final String JSON_PROPERTY_OPERATOR = "operator";
  private String operator;

  public static final String JSON_PROPERTY_TARIFF_VERSIONS = "tariffVersions";
  private List<TariffVersion> tariffVersions = new ArrayList<>();

  public TollSystem() { 
  }

  public TollSystem name(String name) {
    this.name = name;
    return this;
  }

  /**
   * The name of the toll system.
   * @return name
   */
  @javax.annotation.Nonnull
  @JsonProperty(JSON_PROPERTY_NAME)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public String getName() {
    return name;
  }


  @JsonProperty(JSON_PROPERTY_NAME)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setName(String name) {
    this.name = name;
  }


  public TollSystem operator(String operator) {
    this.operator = operator;
    return this;
  }

  /**
   * The operator of the toll system.
   * @return operator
   */
  @javax.annotation.Nonnull
  @JsonProperty(JSON_PROPERTY_OPERATOR)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public String getOperator() {
    return operator;
  }


  @JsonProperty(JSON_PROPERTY_OPERATOR)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setOperator(String operator) {
    this.operator = operator;
  }


  public TollSystem tariffVersions(List<TariffVersion> tariffVersions) {
    this.tariffVersions = tariffVersions;
    return this;
  }

  public TollSystem addTariffVersionsItem(TariffVersion tariffVersionsItem) {
    if (this.tariffVersions == null) {
      this.tariffVersions = new ArrayList<>();
    }
    this.tariffVersions.add(tariffVersionsItem);
    return this;
  }

  /**
   * The tariff versions.
   * @return tariffVersions
   */
  @javax.annotation.Nonnull
  @JsonProperty(JSON_PROPERTY_TARIFF_VERSIONS)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public List<TariffVersion> getTariffVersions() {
    return tariffVersions;
  }


  @JsonProperty(JSON_PROPERTY_TARIFF_VERSIONS)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setTariffVersions(List<TariffVersion> tariffVersions) {
    this.tariffVersions = tariffVersions;
  }


  /**
   * Return true if this TollSystem object is equal to o.
   */
  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    TollSystem tollSystem = (TollSystem) o;
    return Objects.equals(this.name, tollSystem.name) &&
        Objects.equals(this.operator, tollSystem.operator) &&
        Objects.equals(this.tariffVersions, tollSystem.tariffVersions);
  }

  @Override
  public int hashCode() {
    return Objects.hash(name, operator, tariffVersions);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class TollSystem {\n");
    sb.append("    name: ").append(toIndentedString(name)).append("\n");
    sb.append("    operator: ").append(toIndentedString(operator)).append("\n");
    sb.append("    tariffVersions: ").append(toIndentedString(tariffVersions)).append("\n");
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

    // add `name` to the URL query string
    if (getName() != null) {
      joiner.add(String.format("%sname%s=%s", prefix, suffix, URLEncoder.encode(ApiClient.valueToString(getName()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    // add `operator` to the URL query string
    if (getOperator() != null) {
      joiner.add(String.format("%soperator%s=%s", prefix, suffix, URLEncoder.encode(ApiClient.valueToString(getOperator()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    // add `tariffVersions` to the URL query string
    if (getTariffVersions() != null) {
      for (int i = 0; i < getTariffVersions().size(); i++) {
        if (getTariffVersions().get(i) != null) {
          joiner.add(getTariffVersions().get(i).toUrlQueryString(String.format("%stariffVersions%s%s", prefix, suffix,
          "".equals(suffix) ? "" : String.format("%s%d%s", containerPrefix, i, containerSuffix))));
        }
      }
    }

    return joiner.toString();
  }
}

