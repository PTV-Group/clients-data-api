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
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import com.fasterxml.jackson.annotation.JsonPropertyOrder;


/**
 * Road
 */
@JsonPropertyOrder({
  Road.JSON_PROPERTY_POLYLINE
})
@javax.annotation.processing.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2023-10-30T06:51:07.244706Z[Etc/UTC]")
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
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "The polyline of the road in the format specified by **polylineFormat**.")
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

}

