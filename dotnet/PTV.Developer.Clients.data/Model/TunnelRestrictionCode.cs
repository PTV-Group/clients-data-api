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
    /// The tunnel restriction code according to ADR (European Agreement Concerning the International Carriage of Dangerous Goods by Road) depending on the load of the vehicle.  Relevant for &#x60;routing&#x60;. 
    /// </summary>
    /// <value>The tunnel restriction code according to ADR (European Agreement Concerning the International Carriage of Dangerous Goods by Road) depending on the load of the vehicle.  Relevant for &#x60;routing&#x60;. </value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TunnelRestrictionCode
    {
        /// <summary>
        /// Enum NONE for value: NONE
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE = 1,

        /// <summary>
        /// Enum B for value: B
        /// </summary>
        [EnumMember(Value = "B")]
        B = 2,

        /// <summary>
        /// Enum C for value: C
        /// </summary>
        [EnumMember(Value = "C")]
        C = 3,

        /// <summary>
        /// Enum D for value: D
        /// </summary>
        [EnumMember(Value = "D")]
        D = 4,

        /// <summary>
        /// Enum E for value: E
        /// </summary>
        [EnumMember(Value = "E")]
        E = 5
    }

}
