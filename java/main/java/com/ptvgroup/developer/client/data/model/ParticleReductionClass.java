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
import com.fasterxml.jackson.annotation.JsonPropertyOrder;


import com.fasterxml.jackson.annotation.JsonCreator;
import com.fasterxml.jackson.annotation.JsonValue;

/**
 * The particle reduction class (Partikelminderungsklasse) according to &#39;Anlage XIV zu &amp;sect; 48 StVZO&#39; (German law).  Supported for **engineType** _COMBUSTION_ and _HYBRID_. Relevant for &#x60;toll&#x60;. 
 */
public enum ParticleReductionClass {
  
  PMK_0("PMK_0"),
  
  PMK_1("PMK_1"),
  
  PMK_2("PMK_2"),
  
  PMK_3("PMK_3"),
  
  PMK_4("PMK_4"),
  
  NONE("NONE");

  private String value;

  ParticleReductionClass(String value) {
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
  public static ParticleReductionClass fromValue(String value) {
    for (ParticleReductionClass b : ParticleReductionClass.values()) {
      if (b.value.equals(value)) {
        return b;
      }
    }
    throw new IllegalArgumentException("Unexpected value '" + value + "'");
  }

  /**
   * Convert the instance into URL query string.
   *
   * @param prefix prefix of the query string
   * @return URL query string
   */
  public String toUrlQueryString(String prefix) {
    if (prefix == null) {
      prefix = "";
    }

    return String.format("%s=%s", prefix, this.toString());
  }

}

