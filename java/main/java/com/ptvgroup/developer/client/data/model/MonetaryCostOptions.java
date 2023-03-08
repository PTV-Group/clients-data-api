/*
 * Data
 * With the Data service you can obtain additional data such as vehicle profiles.
 *
 * The version of the OpenAPI document: 1.3
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
 * MonetaryCostOptions
 */
@JsonPropertyOrder({
  MonetaryCostOptions.JSON_PROPERTY_COST_PER_KILOMETER,
  MonetaryCostOptions.JSON_PROPERTY_WORKING_COST_PER_HOUR
})
@javax.annotation.processing.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2023-03-08T07:22:40.201306Z[Etc/UTC]")
public class MonetaryCostOptions {
  public static final String JSON_PROPERTY_COST_PER_KILOMETER = "costPerKilometer";
  private Double costPerKilometer;

  public static final String JSON_PROPERTY_WORKING_COST_PER_HOUR = "workingCostPerHour";
  private Double workingCostPerHour;

  public MonetaryCostOptions() { 
  }

  public MonetaryCostOptions costPerKilometer(Double costPerKilometer) {
    this.costPerKilometer = costPerKilometer;
    return this;
  }

   /**
   * Specifies the cost per kilometer. The default value of a profile is used as an example and can change at any time.
   * minimum: 0
   * @return costPerKilometer
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "Specifies the cost per kilometer. The default value of a profile is used as an example and can change at any time.")
  @JsonProperty(JSON_PROPERTY_COST_PER_KILOMETER)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)

  public Double getCostPerKilometer() {
    return costPerKilometer;
  }


  @JsonProperty(JSON_PROPERTY_COST_PER_KILOMETER)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setCostPerKilometer(Double costPerKilometer) {
    this.costPerKilometer = costPerKilometer;
  }


  public MonetaryCostOptions workingCostPerHour(Double workingCostPerHour) {
    this.workingCostPerHour = workingCostPerHour;
    return this;
  }

   /**
   * Specifies the cost per hour. It is not applied to service, break or rest periods. The default value of a profile is used as an example and can change at any time.
   * minimum: 0
   * @return workingCostPerHour
  **/
  @javax.annotation.Nonnull
  @ApiModelProperty(required = true, value = "Specifies the cost per hour. It is not applied to service, break or rest periods. The default value of a profile is used as an example and can change at any time.")
  @JsonProperty(JSON_PROPERTY_WORKING_COST_PER_HOUR)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)

  public Double getWorkingCostPerHour() {
    return workingCostPerHour;
  }


  @JsonProperty(JSON_PROPERTY_WORKING_COST_PER_HOUR)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setWorkingCostPerHour(Double workingCostPerHour) {
    this.workingCostPerHour = workingCostPerHour;
  }


  /**
   * Return true if this MonetaryCostOptions object is equal to o.
   */
  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    MonetaryCostOptions monetaryCostOptions = (MonetaryCostOptions) o;
    return Objects.equals(this.costPerKilometer, monetaryCostOptions.costPerKilometer) &&
        Objects.equals(this.workingCostPerHour, monetaryCostOptions.workingCostPerHour);
  }

  @Override
  public int hashCode() {
    return Objects.hash(costPerKilometer, workingCostPerHour);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class MonetaryCostOptions {\n");
    sb.append("    costPerKilometer: ").append(toIndentedString(costPerKilometer)).append("\n");
    sb.append("    workingCostPerHour: ").append(toIndentedString(workingCostPerHour)).append("\n");
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

