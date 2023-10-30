/*
 * Data
 * With the Data service you can obtain additional data such as vehicle profiles.
 *
 * The version of the OpenAPI document: 1.6
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package com.ptvgroup.developer.client.data.model;

import java.util.Objects;
import java.util.Arrays;
import java.util.Map;
import java.util.HashMap;
import com.fasterxml.jackson.annotation.JsonInclude;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonCreator;
import com.fasterxml.jackson.annotation.JsonTypeName;
import com.fasterxml.jackson.annotation.JsonValue;
import com.ptvgroup.developer.client.data.model.Road;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.ArrayList;
import java.util.List;
import com.fasterxml.jackson.annotation.JsonPropertyOrder;


/**
 * The roads selected by the input.
 */
@ApiModel(description = "The roads selected by the input.")
@JsonPropertyOrder({
  RoadsResponse.JSON_PROPERTY_ROADS
})
@javax.annotation.processing.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2023-10-30T06:51:07.244706Z[Etc/UTC]")
public class RoadsResponse {
  public static final String JSON_PROPERTY_ROADS = "roads";
  private List<Road> roads = null;

  public RoadsResponse() { 
  }

  public RoadsResponse roads(List<Road> roads) {
    this.roads = roads;
    return this;
  }

  public RoadsResponse addRoadsItem(Road roadsItem) {
    if (this.roads == null) {
      this.roads = new ArrayList<>();
    }
    this.roads.add(roadsItem);
    return this;
  }

   /**
   * The list of selected roads according to the criteria specified in the request.
   * @return roads
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "The list of selected roads according to the criteria specified in the request.")
  @JsonProperty(JSON_PROPERTY_ROADS)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)

  public List<Road> getRoads() {
    return roads;
  }


  @JsonProperty(JSON_PROPERTY_ROADS)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setRoads(List<Road> roads) {
    this.roads = roads;
  }


  /**
   * Return true if this RoadsResponse object is equal to o.
   */
  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    RoadsResponse roadsResponse = (RoadsResponse) o;
    return Objects.equals(this.roads, roadsResponse.roads);
  }

  @Override
  public int hashCode() {
    return Objects.hash(roads);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class RoadsResponse {\n");
    sb.append("    roads: ").append(toIndentedString(roads)).append("\n");
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

}

