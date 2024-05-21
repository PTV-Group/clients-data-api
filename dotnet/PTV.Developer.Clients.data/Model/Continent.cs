/*
 * Data
 *
 * With the Data service you can obtain additional data such as vehicle profiles.
 *
 * The version of the OpenAPI document: 1.10
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
    /// The continent the geographical unit belongs to.
    /// </summary>
    /// <value>The continent the geographical unit belongs to.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Continent
    {
        /// <summary>
        /// Enum EUROPE for value: EUROPE
        /// </summary>
        [EnumMember(Value = "EUROPE")]
        EUROPE = 1,

        /// <summary>
        /// Enum NORTH_AMERICA for value: NORTH_AMERICA
        /// </summary>
        [EnumMember(Value = "NORTH_AMERICA")]
        NORTH_AMERICA = 2,

        /// <summary>
        /// Enum SOUTH_AMERICA for value: SOUTH_AMERICA
        /// </summary>
        [EnumMember(Value = "SOUTH_AMERICA")]
        SOUTH_AMERICA = 3,

        /// <summary>
        /// Enum AFRICA for value: AFRICA
        /// </summary>
        [EnumMember(Value = "AFRICA")]
        AFRICA = 4,

        /// <summary>
        /// Enum ASIA for value: ASIA
        /// </summary>
        [EnumMember(Value = "ASIA")]
        ASIA = 5,

        /// <summary>
        /// Enum AUSTRALIA_OCEANIA for value: AUSTRALIA_OCEANIA
        /// </summary>
        [EnumMember(Value = "AUSTRALIA_OCEANIA")]
        AUSTRALIA_OCEANIA = 6
    }

}
