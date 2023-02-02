/*
 * Data
 *
 * With the Data service you can obtain additional data such as vehicle profiles.
 *
 * The version of the OpenAPI document: 1.3
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
    /// Defines LowEmissionZoneTypes
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum LowEmissionZoneTypes
    {
        /// <summary>
        /// Enum DE_GREEN for value: DE_GREEN
        /// </summary>
        [EnumMember(Value = "DE_GREEN")]
        DE_GREEN = 1,

        /// <summary>
        /// Enum DE_YELLOW for value: DE_YELLOW
        /// </summary>
        [EnumMember(Value = "DE_YELLOW")]
        DE_YELLOW = 2,

        /// <summary>
        /// Enum DE_RED for value: DE_RED
        /// </summary>
        [EnumMember(Value = "DE_RED")]
        DE_RED = 3,

        /// <summary>
        /// Enum DE_NONE for value: DE_NONE
        /// </summary>
        [EnumMember(Value = "DE_NONE")]
        DE_NONE = 4

    }

}