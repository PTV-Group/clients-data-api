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
import com.ptvgroup.developer.client.data.model.GeographicalUnit;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import com.fasterxml.jackson.annotation.JsonPropertyOrder;


/**
 * MapInformationResponse
 */
@JsonPropertyOrder({
  MapInformationResponse.JSON_PROPERTY_GEOGRAPHICAL_UNITS
})
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2024-01-11T15:04:25.045174Z[Etc/UTC]")
public class MapInformationResponse {
  public static final String JSON_PROPERTY_GEOGRAPHICAL_UNITS = "geographicalUnits";
  private List<GeographicalUnit> geographicalUnits = new ArrayList<>();

  public MapInformationResponse() { 
  }

  public MapInformationResponse geographicalUnits(List<GeographicalUnit> geographicalUnits) {
    this.geographicalUnits = geographicalUnits;
    return this;
  }

  public MapInformationResponse addGeographicalUnitsItem(GeographicalUnit geographicalUnitsItem) {
    if (this.geographicalUnits == null) {
      this.geographicalUnits = new ArrayList<>();
    }
    this.geographicalUnits.add(geographicalUnitsItem);
    return this;
  }

   /**
   * Lists the available data and their features for each geographical unit, usually a country or a state, sorted by their ISO 3166 code.
   * @return geographicalUnits
  **/
  @javax.annotation.Nonnull
  @JsonProperty(JSON_PROPERTY_GEOGRAPHICAL_UNITS)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)

  public List<GeographicalUnit> getGeographicalUnits() {
    return geographicalUnits;
  }


  @JsonProperty(JSON_PROPERTY_GEOGRAPHICAL_UNITS)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setGeographicalUnits(List<GeographicalUnit> geographicalUnits) {
    this.geographicalUnits = geographicalUnits;
  }


  /**
   * Return true if this MapInformationResponse object is equal to o.
   */
  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    MapInformationResponse mapInformationResponse = (MapInformationResponse) o;
    return Objects.equals(this.geographicalUnits, mapInformationResponse.geographicalUnits);
  }

  @Override
  public int hashCode() {
    return Objects.hash(geographicalUnits);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class MapInformationResponse {\n");
    sb.append("    geographicalUnits: ").append(toIndentedString(geographicalUnits)).append("\n");
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

    // add `geographicalUnits` to the URL query string
    if (getGeographicalUnits() != null) {
      for (int i = 0; i < getGeographicalUnits().size(); i++) {
        if (getGeographicalUnits().get(i) != null) {
          joiner.add(getGeographicalUnits().get(i).toUrlQueryString(String.format("%sgeographicalUnits%s%s", prefix, suffix,
          "".equals(suffix) ? "" : String.format("%s%d%s", containerPrefix, i, containerSuffix))));
        }
      }
    }

    return joiner.toString();
  }
}

