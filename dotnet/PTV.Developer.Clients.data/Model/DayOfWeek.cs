/*
 * Data
 *
 * With the Data service you can obtain additional data such as vehicle profiles.
 *
 * The version of the OpenAPI document: 1.6
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = PTV.Developer.Clients.data.Client.OpenAPIDateConverter;

namespace PTV.Developer.Clients.data.Model
{
    /// <summary>
    /// The day of week the schedule interval starts.
    /// </summary>
    /// <value>The day of week the schedule interval starts.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DayOfWeek
    {
        /// <summary>
        /// Enum MONDAY for value: MONDAY
        /// </summary>
        [EnumMember(Value = "MONDAY")]
        MONDAY = 1,

        /// <summary>
        /// Enum TUESDAY for value: TUESDAY
        /// </summary>
        [EnumMember(Value = "TUESDAY")]
        TUESDAY = 2,

        /// <summary>
        /// Enum WEDNESDAY for value: WEDNESDAY
        /// </summary>
        [EnumMember(Value = "WEDNESDAY")]
        WEDNESDAY = 3,

        /// <summary>
        /// Enum THURSDAY for value: THURSDAY
        /// </summary>
        [EnumMember(Value = "THURSDAY")]
        THURSDAY = 4,

        /// <summary>
        /// Enum FRIDAY for value: FRIDAY
        /// </summary>
        [EnumMember(Value = "FRIDAY")]
        FRIDAY = 5,

        /// <summary>
        /// Enum SATURDAY for value: SATURDAY
        /// </summary>
        [EnumMember(Value = "SATURDAY")]
        SATURDAY = 6,

        /// <summary>
        /// Enum SUNDAY for value: SUNDAY
        /// </summary>
        [EnumMember(Value = "SUNDAY")]
        SUNDAY = 7

    }

}
