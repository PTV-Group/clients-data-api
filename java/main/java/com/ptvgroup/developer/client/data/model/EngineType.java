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
import io.swagger.annotations.ApiModel;
import com.fasterxml.jackson.annotation.JsonPropertyOrder;


import com.fasterxml.jackson.annotation.JsonCreator;
import com.fasterxml.jackson.annotation.JsonValue;

/**
 * The engine type of the vehicle.  Relevant for &#x60;toll&#x60;, &#x60;emissions&#x60;. 
 */
public enum EngineType {
  
  COMBUSTION("COMBUSTION"),
  
  ELECTRIC("ELECTRIC"),
  
  HYBRID("HYBRID");

  private String value;

  EngineType(String value) {
    this.value = value;
  }

  @JsonValue
  public String getValue() {
    return value;
  }

  @Override
  public String toString() {
    return String.valueOf(value);
  }

  @JsonCreator
  public static EngineType fromValue(String value) {
    for (EngineType b : EngineType.values()) {
      if (b.value.equals(value)) {
        return b;
      }
    }
    return null;
  }
}

