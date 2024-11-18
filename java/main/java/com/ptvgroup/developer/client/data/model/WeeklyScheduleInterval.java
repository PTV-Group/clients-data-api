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
import com.ptvgroup.developer.client.data.model.DayOfWeek;
import java.util.Arrays;
import com.fasterxml.jackson.annotation.JsonPropertyOrder;


import com.ptvgroup.developer.client.data.ApiClient;
/**
 * WeeklyScheduleInterval
 */
@JsonPropertyOrder({
  WeeklyScheduleInterval.JSON_PROPERTY_DAY_OF_WEEK,
  WeeklyScheduleInterval.JSON_PROPERTY_HOUR,
  WeeklyScheduleInterval.JSON_PROPERTY_MINUTE,
  WeeklyScheduleInterval.JSON_PROPERTY_DURATION
})
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2024-11-18T14:13:44.232763015Z[Etc/UTC]", comments = "Generator version: 7.8.0")
public class WeeklyScheduleInterval {
  public static final String JSON_PROPERTY_DAY_OF_WEEK = "dayOfWeek";
  private DayOfWeek dayOfWeek;

  public static final String JSON_PROPERTY_HOUR = "hour";
  private Integer hour;

  public static final String JSON_PROPERTY_MINUTE = "minute";
  private Integer minute;

  public static final String JSON_PROPERTY_DURATION = "duration";
  private Integer duration;

  public WeeklyScheduleInterval() { 
  }

  public WeeklyScheduleInterval dayOfWeek(DayOfWeek dayOfWeek) {
    this.dayOfWeek = dayOfWeek;
    return this;
  }

  /**
   * Get dayOfWeek
   * @return dayOfWeek
   */
  @javax.annotation.Nonnull
  @JsonProperty(JSON_PROPERTY_DAY_OF_WEEK)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public DayOfWeek getDayOfWeek() {
    return dayOfWeek;
  }


  @JsonProperty(JSON_PROPERTY_DAY_OF_WEEK)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setDayOfWeek(DayOfWeek dayOfWeek) {
    this.dayOfWeek = dayOfWeek;
  }


  public WeeklyScheduleInterval hour(Integer hour) {
    this.hour = hour;
    return this;
  }

  /**
   * The hour the schedule interval starts.
   * minimum: 0
   * maximum: 23
   * @return hour
   */
  @javax.annotation.Nonnull
  @JsonProperty(JSON_PROPERTY_HOUR)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public Integer getHour() {
    return hour;
  }


  @JsonProperty(JSON_PROPERTY_HOUR)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setHour(Integer hour) {
    this.hour = hour;
  }


  public WeeklyScheduleInterval minute(Integer minute) {
    this.minute = minute;
    return this;
  }

  /**
   * The minutes of hours the schedule interval starts.
   * minimum: 0
   * maximum: 59
   * @return minute
   */
  @javax.annotation.Nonnull
  @JsonProperty(JSON_PROPERTY_MINUTE)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public Integer getMinute() {
    return minute;
  }


  @JsonProperty(JSON_PROPERTY_MINUTE)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setMinute(Integer minute) {
    this.minute = minute;
  }


  public WeeklyScheduleInterval duration(Integer duration) {
    this.duration = duration;
    return this;
  }

  /**
   * The duration of the schedule interval in [min].
   * minimum: 1
   * maximum: 10080
   * @return duration
   */
  @javax.annotation.Nonnull
  @JsonProperty(JSON_PROPERTY_DURATION)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public Integer getDuration() {
    return duration;
  }


  @JsonProperty(JSON_PROPERTY_DURATION)
  @JsonInclude(value = JsonInclude.Include.ALWAYS)
  public void setDuration(Integer duration) {
    this.duration = duration;
  }


  /**
   * Return true if this WeeklyScheduleInterval object is equal to o.
   */
  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    WeeklyScheduleInterval weeklyScheduleInterval = (WeeklyScheduleInterval) o;
    return Objects.equals(this.dayOfWeek, weeklyScheduleInterval.dayOfWeek) &&
        Objects.equals(this.hour, weeklyScheduleInterval.hour) &&
        Objects.equals(this.minute, weeklyScheduleInterval.minute) &&
        Objects.equals(this.duration, weeklyScheduleInterval.duration);
  }

  @Override
  public int hashCode() {
    return Objects.hash(dayOfWeek, hour, minute, duration);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class WeeklyScheduleInterval {\n");
    sb.append("    dayOfWeek: ").append(toIndentedString(dayOfWeek)).append("\n");
    sb.append("    hour: ").append(toIndentedString(hour)).append("\n");
    sb.append("    minute: ").append(toIndentedString(minute)).append("\n");
    sb.append("    duration: ").append(toIndentedString(duration)).append("\n");
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

    // add `dayOfWeek` to the URL query string
    if (getDayOfWeek() != null) {
      joiner.add(String.format("%sdayOfWeek%s=%s", prefix, suffix, URLEncoder.encode(ApiClient.valueToString(getDayOfWeek()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    // add `hour` to the URL query string
    if (getHour() != null) {
      joiner.add(String.format("%shour%s=%s", prefix, suffix, URLEncoder.encode(ApiClient.valueToString(getHour()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    // add `minute` to the URL query string
    if (getMinute() != null) {
      joiner.add(String.format("%sminute%s=%s", prefix, suffix, URLEncoder.encode(ApiClient.valueToString(getMinute()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    // add `duration` to the URL query string
    if (getDuration() != null) {
      joiner.add(String.format("%sduration%s=%s", prefix, suffix, URLEncoder.encode(ApiClient.valueToString(getDuration()), StandardCharsets.UTF_8).replaceAll("\\+", "%20")));
    }

    return joiner.toString();
  }
}

