/*
 * Data
 *
 * With the Data service you can obtain additional data such as vehicle profiles.
 *
 * The version of the OpenAPI document: 1.13
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
    /// The region in this profile is designed for. It represents the characteristics of its region. See the [profiles concept](./concepts/profiles) for details. 
    /// </summary>
    /// <value>The region in this profile is designed for. It represents the characteristics of its region. See the [profiles concept](./concepts/profiles) for details. </value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RegionType
    {
        /// <summary>
        /// Enum EUROPE for value: EUROPE
        /// </summary>
        [EnumMember(Value = "EUROPE")]
        EUROPE = 1,

        /// <summary>
        /// Enum AMERICA for value: AMERICA
        /// </summary>
        [EnumMember(Value = "AMERICA")]
        AMERICA = 2,

        /// <summary>
        /// Enum AUSTRALIA for value: AUSTRALIA
        /// </summary>
        [EnumMember(Value = "AUSTRALIA")]
        AUSTRALIA = 3,

        /// <summary>
        /// Enum IMEA for value: IMEA
        /// </summary>
        [EnumMember(Value = "IMEA")]
        IMEA = 4,

        /// <summary>
        /// Enum WORLD for value: WORLD
        /// </summary>
        [EnumMember(Value = "WORLD")]
        WORLD = 5
    }

}
