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
import com.ptvgroup.developer.client.data.model.TimeInterval;
import com.ptvgroup.developer.client.data.model.WeeklyScheduleInterval;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import com.fasterxml.jackson.annotation.JsonPropertyOrder;


import com.ptvgroup.developer.client.data.ApiClient;
/**
 * The periods during which the attributes are valid. If both time intervals and weekly schedule are specified, the attributes are valid only during the weekly schedule within the time intervals. If there is no such period, the attributes are never valid. If not specified, the attributes are always valid.
 */
@JsonPropertyOrder({
  Validity.JSON_PROPERTY_TIME_INTERVALS,
  Validity.JSON_PROPERTY_WEEKLY_SCHEDULE
})
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2024-11-18T14:13:44.232763015Z[Etc/UTC]", comments = "Generator version: 7.8.0")
public class Validity {
  public static final String JSON_PROPERTY_TIME_INTERVALS = "timeIntervals";
  private List<TimeInterval> timeIntervals = new ArrayList<>();

  public static final String JSON_PROPERTY_WEEKLY_SCHEDULE = "weeklySchedule";
  private List<WeeklyScheduleInterval> weeklySchedule = new ArrayList<>();

  public Validity() { 
  }

  public Validity timeIntervals(List<TimeInterval> timeIntervals) {
    this.timeIntervals = timeIntervals;
    return this;
  }

  public Validity addTimeIntervalsItem(TimeInterval timeIntervalsItem) {
    if (this.timeIntervals == null) {
      this.timeIntervals = new ArrayList<>();
    }
    this.timeIntervals.add(timeIntervalsItem);
    return this;
  }

  /**
   * If the attributes are valid during specific periods, specify concrete time intervals. Each time interval has an explicit start and end date. Overlapping intervals will be merged.
   * @return timeIntervals
   */
  @javax.annotation.Nullable
  @JsonProperty(JSON_PROPERTY_TIME_INTERVALS)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public List<TimeInterval> getTimeIntervals() {
    return timeIntervals;
  }


  @JsonProperty(JSON_PROPERTY_TIME_INTERVALS)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setTimeIntervals(List<TimeInterval> timeIntervals) {
    this.timeIntervals = timeIntervals;
  }


  public Validity weeklySchedule(List<WeeklyScheduleInterval> weeklySchedule) {
    this.weeklySchedule = weeklySchedule;
    return this;
  }

  public Validity addWeeklyScheduleItem(WeeklyScheduleInterval weeklyScheduleItem) {
    if (this.weeklySchedule == null) {
      this.weeklySchedule = new ArrayList<>();
    }
    this.weeklySchedule.add(weeklyScheduleItem);
    return this;
  }

  /**
   * If the attributes are valid in a regular manner, i.e. at specific times and/or days of week, specify a weekly schedule. Each interval is specified by the starting point in time and the duration. The starting points of the intervals must be in local time and in ascending order. Overlapping intervals will be merged. The total duration of all intervals must not exceed one week (168 hours).
   * @return weeklySchedule
   */
  @javax.annotation.Nullable
  @JsonProperty(JSON_PROPERTY_WEEKLY_SCHEDULE)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public List<WeeklyScheduleInterval> getWeeklySchedule() {
    return weeklySchedule;
  }


  @JsonProperty(JSON_PROPERTY_WEEKLY_SCHEDULE)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  public void setWeeklySchedule(List<WeeklyScheduleInterval> weeklySchedule) {
    this.weeklySchedule = weeklySchedule;
  }


  /**
   * Return true if this Validity object is equal to o.
   */
  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Validity validity = (Validity) o;
    return Objects.equals(this.timeIntervals, validity.timeIntervals) &&
        Objects.equals(this.weeklySchedule, validity.weeklySchedule);
  }

  @Override
  public int hashCode() {
    return Objects.hash(timeIntervals, weeklySchedule);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Validity {\n");
    sb.append("    timeIntervals: ").append(toIndentedString(timeIntervals)).append("\n");
    sb.append("    weeklySchedule: ").append(toIndentedString(weeklySchedule)).append("\n");
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

    // add `timeIntervals` to the URL query string
    if (getTimeIntervals() != null) {
      for (int i = 0; i < getTimeIntervals().size(); i++) {
        if (getTimeIntervals().get(i) != null) {
          joiner.add(getTimeIntervals().get(i).toUrlQueryString(String.format("%stimeIntervals%s%s", prefix, suffix,
          "".equals(suffix) ? "" : String.format("%s%d%s", containerPrefix, i, containerSuffix))));
        }
      }
    }

    // add `weeklySchedule` to the URL query string
    if (getWeeklySchedule() != null) {
      for (int i = 0; i < getWeeklySchedule().size(); i++) {
        if (getWeeklySchedule().get(i) != null) {
          joiner.add(getWeeklySchedule().get(i).toUrlQueryString(String.format("%sweeklySchedule%s%s", prefix, suffix,
          "".equals(suffix) ? "" : String.format("%s%d%s", containerPrefix, i, containerSuffix))));
        }
      }
    }

    return joiner.toString();
  }
}

