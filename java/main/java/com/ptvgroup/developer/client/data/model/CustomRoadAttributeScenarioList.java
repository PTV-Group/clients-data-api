/*
 * Data
 * With the Data service you can obtain additional data such as vehicle profiles.
 *
 * The version of the OpenAPI document: 1.7
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
import com.ptvgroup.developer.client.data.model.CustomRoadAttributeScenario;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import com.fasterxml.jackson.annotation.JsonPropertyOrder;


/**
 * A list of custom road attribute scenarios.
 */
@JsonPropertyOrder({
  CustomRoadAttributeScenarioList.JSON_PROPERTY_CUSTOM_ROAD_ATTRIBUTE_SCENARIOS
})
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2024-01-11T15:04:25.045174Z[Etc/UTC]")
public class CustomRoadAttributeScenarioList {
  public static final String JSON_PROPERTY_CUSTOM_ROAD_ATTRIBUTE_SCENARIOS = "customRoadAttributeScenarios";
  private List<CustomRoadAttributeScenario> customRoadAttributeScenarios;

  public CustomRoadAttributeScenarioList() { 
  }

  public CustomRoadAttributeScenarioList customRoadAttributeScenarios(List<CustomRoadAttributeScenario> customRoadAttributeScenarios) {
    this.customRoadAttributeScenarios = customRoadAttributeScenarios;
    return this;
  }

  public CustomRoadAttributeScenarioList addCustomRoadAttributeScenariosItem(CustomRoadAttributeScenario customRoadAttributeScenariosItem) {
    if (this.customRoadAttributeScenarios == null) {
      this.customRoadAttributeScenarios = new ArrayList<>();
    }
    this.customRoadAttributeScenarios.add(customRoadAttributeScenariosItem);
    return this;
  }

   /**
   * Get customRoadAttributeScenarios
   * @return customRoadAttributeScenarios
  **/
  @javax.annotation.Nullable
  @JsonProperty(JSON_PROPERTY_CUSTOM_ROAD_ATTRIBUTE_SCENARIOS)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)

  public List<CustomRoadAttributeScenario> getCustomRoadAttributeScenarios() {
    return customRoadAttributeScenarios;
  }


  @JsonProperty(JSON_PROPERTY_CUSTOM_ROAD_ATTRIBUTE_SCENARIOS)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setCustomRoadAttributeScenarios(List<CustomRoadAttributeScenario> customRoadAttributeScenarios) {
    this.customRoadAttributeScenarios = customRoadAttributeScenarios;
  }


  /**
   * Return true if this CustomRoadAttributeScenarioList object is equal to o.
   */
  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    CustomRoadAttributeScenarioList customRoadAttributeScenarioList = (CustomRoadAttributeScenarioList) o;
    return Objects.equals(this.customRoadAttributeScenarios, customRoadAttributeScenarioList.customRoadAttributeScenarios);
  }

  @Override
  public int hashCode() {
    return Objects.hash(customRoadAttributeScenarios);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class CustomRoadAttributeScenarioList {\n");
    sb.append("    customRoadAttributeScenarios: ").append(toIndentedString(customRoadAttributeScenarios)).append("\n");
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

    // add `customRoadAttributeScenarios` to the URL query string
    if (getCustomRoadAttributeScenarios() != null) {
      for (int i = 0; i < getCustomRoadAttributeScenarios().size(); i++) {
        if (getCustomRoadAttributeScenarios().get(i) != null) {
          joiner.add(getCustomRoadAttributeScenarios().get(i).toUrlQueryString(String.format("%scustomRoadAttributeScenarios%s%s", prefix, suffix,
          "".equals(suffix) ? "" : String.format("%s%d%s", containerPrefix, i, containerSuffix))));
        }
      }
    }

    return joiner.toString();
  }
}

