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
    /// The electricity type of the vehicle.  Supported for **engineType** _ELECTRIC_ or _HYBRID_. Relevant for &#x60;emissions&#x60;. 
    /// </summary>
    /// <value>The electricity type of the vehicle.  Supported for **engineType** _ELECTRIC_ or _HYBRID_. Relevant for &#x60;emissions&#x60;. </value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ElectricityType
    {
        /// <summary>
        /// Enum BATTERY for value: BATTERY
        /// </summary>
        [EnumMember(Value = "BATTERY")]
        BATTERY = 1,

        /// <summary>
        /// Enum HYDROGEN_FUEL_CELL for value: HYDROGEN_FUEL_CELL
        /// </summary>
        [EnumMember(Value = "HYDROGEN_FUEL_CELL")]
        HYDROGEN_FUEL_CELL = 2,

        /// <summary>
        /// Enum NONE for value: NONE
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE = 3
    }

}
