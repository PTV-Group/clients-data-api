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
 * The direction of the road the attributes apply to.  * &#x60;POLYLINE_DIRECTION&#x60; - Describes the direction from the start node to the end node of the polyline of the road.  * &#x60;REVERSE_POLYLINE_DIRECTION&#x60; - Describes the direction from the end node to the start node of the polyline of the road.  * &#x60;BOTH&#x60; - Describes both directions.  If the selection contains more than one road and the direction is different from _BOTH_, an error will be returned.
 */
public enum RoadDirectionType {
  
  POLYLINE_DIRECTION("POLYLINE_DIRECTION"),
  
  REVERSE_POLYLINE_DIRECTION("REVERSE_POLYLINE_DIRECTION"),
  
  BOTH("BOTH");

  private String value;

  RoadDirectionType(String value) {
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
  public static RoadDirectionType fromValue(String value) {
    for (RoadDirectionType b : RoadDirectionType.values()) {
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

