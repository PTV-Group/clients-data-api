/*
 * Data
 *
 * With the Data service you can obtain additional data such as vehicle profiles.
 *
 * The version of the OpenAPI document: 1.12
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
    /// The type of the API change.
    /// </summary>
    /// <value>The type of the API change.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ApiChangeType
    {
        /// <summary>
        /// Enum FEATURE for value: FEATURE
        /// </summary>
        [EnumMember(Value = "FEATURE")]
        FEATURE = 1,

        /// <summary>
        /// Enum IMPROVEMENT for value: IMPROVEMENT
        /// </summary>
        [EnumMember(Value = "IMPROVEMENT")]
        IMPROVEMENT = 2,

        /// <summary>
        /// Enum BUGFIX for value: BUGFIX
        /// </summary>
        [EnumMember(Value = "BUGFIX")]
        BUGFIX = 3,

        /// <summary>
        /// Enum DISCONTINUATION for value: DISCONTINUATION
        /// </summary>
        [EnumMember(Value = "DISCONTINUATION")]
        DISCONTINUATION = 4,

        /// <summary>
        /// Enum ANNOUNCEMENT for value: ANNOUNCEMENT
        /// </summary>
        [EnumMember(Value = "ANNOUNCEMENT")]
        ANNOUNCEMENT = 5
    }

}