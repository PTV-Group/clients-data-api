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
import com.fasterxml.jackson.annotation.JsonPropertyOrder;


import com.fasterxml.jackson.annotation.JsonCreator;
import com.fasterxml.jackson.annotation.JsonValue;

/**
 * Gets or Sets HazardousMaterials
 */
public enum HazardousMaterials {
  
  HAZARDOUS_TO_WATER("HAZARDOUS_TO_WATER"),
  
  EXPLOSIVE("EXPLOSIVE"),
  
  FLAMMABLE("FLAMMABLE"),
  
  RADIOACTIVE("RADIOACTIVE"),
  
  INHALATION_HAZARD("INHALATION_HAZARD"),
  
  MEDICAL_WASTE("MEDICAL_WASTE"),
  
  OTHER("OTHER"),
  
  NONE("NONE");

  private String value;

  HazardousMaterials(String value) {
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
  public static HazardousMaterials fromValue(String value) {
    for (HazardousMaterials b : HazardousMaterials.values()) {
      if (b.value.equals(value)) {
        return b;
      }
    }
    throw new IllegalArgumentException("Unexpected value '" + value + "'");
  }
}

