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
import com.ptvgroup.developer.client.data.model.TollSystem;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import com.fasterxml.jackson.annotation.JsonPropertyOrder;


import com.ptvgroup.developer.client.data.ApiClient;
/**
 * The toll features contained by this geographical unit. 
 */
@JsonPropertyOrder({
  TollFeatures.JSON_PROPERTY_TOLL_SYSTEMS
})
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2024-11-18T14:13:44.232763015Z[Etc/UTC]", comments = "Generator version: 7.8.0")
public class TollFeatures {
  public static final String JSON_PROPERTY_TOLL_SYSTEMS = "tollSystems";
  private List<TollSystem> tollSystems = new ArrayList<>();

  public TollFeatures() { 
  }

  public TollFeatures tollSystems(List<TollSystem> tollSystems) {
    this.tollSystems = tollSystems;
    return this;
  }

  public TollFeatures addTollSystemsItem(TollSystem tollSystemsItem) {
    if (this.tollSystems == null) {
      this.tollSystems = new ArrayList<>();
    }
    this.tollSystems.add(tollSystemsItem);
    return this;
  }

  /**
   * The list of toll systems contained by this geographical unit.
   * @return tollSystems
   */
  @javax.annotation.Nonnull
  @JsonProperty(JSON_PROPERTY_TOLL_SYSTEMS)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public List<TollSystem> getTollSystems() {
    return tollSystems;
  }


  @JsonProperty(JSON_PROPERTY_TOLL_SYSTEMS)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setTollSystems(List<TollSystem> tollSystems) {
    this.tollSystems = tollSystems;
  }


  /**
   * Return true if this TollFeatures object is equal to o.
   */
  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    TollFeatures tollFeatures = (TollFeatures) o;
    return Objects.equals(this.tollSystems, tollFeatures.tollSystems);
  }

  @Override
  public int hashCode() {
    return Objects.hash(tollSystems);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class TollFeatures {\n");
    sb.append("    tollSystems: ").append(toIndentedString(tollSystems)).append("\n");
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

    // add `tollSystems` to the URL query string
    if (getTollSystems() != null) {
      for (int i = 0; i < getTollSystems().size(); i++) {
        if (getTollSystems().get(i) != null) {
          joiner.add(getTollSystems().get(i).toUrlQueryString(String.format("%stollSystems%s%s", prefix, suffix,
          "".equals(suffix) ? "" : String.format("%s%d%s", containerPrefix, i, containerSuffix))));
        }
      }
    }

    return joiner.toString();
  }
}

