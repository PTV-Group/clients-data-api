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
    /// The tariff version.
    /// </summary>
    [DataContract(Name = "TariffVersion")]
    public partial class TariffVersion : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TariffVersion" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TariffVersion() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TariffVersion" /> class.
        /// </summary>
        /// <param name="varVersion">The version. (required).</param>
        /// <param name="description">The description of the tariff version. Only present if major changes are introduced such as introducing new vehicle classes or adding or removing toll roads..</param>
        /// <param name="validFrom">The date at which this tariff version becomes valid formatted according to [RFC 3339](https://tools.ietf.org/html/rfc3339). (required).</param>
        public TariffVersion(string varVersion = default(string), string description = default(string), DateOnly validFrom = default(DateOnly))
        {
            // to ensure "varVersion" is required (not null)
            if (varVersion == null)
            {
                throw new ArgumentNullException("varVersion is a required property for TariffVersion and cannot be null");
            }
            this.VarVersion = varVersion;
            // to ensure "validFrom" is required (not null)
            if (validFrom == null)
            {
                throw new ArgumentNullException("validFrom is a required property for TariffVersion and cannot be null");
            }
            this.ValidFrom = validFrom;
            this.Description = description;
        }

        /// <summary>
        /// The version.
        /// </summary>
        /// <value>The version.</value>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public string VarVersion { get; set; }

        /// <summary>
        /// The description of the tariff version. Only present if major changes are introduced such as introducing new vehicle classes or adding or removing toll roads.
        /// </summary>
        /// <value>The description of the tariff version. Only present if major changes are introduced such as introducing new vehicle classes or adding or removing toll roads.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The date at which this tariff version becomes valid formatted according to [RFC 3339](https://tools.ietf.org/html/rfc3339).
        /// </summary>
        /// <value>The date at which this tariff version becomes valid formatted according to [RFC 3339](https://tools.ietf.org/html/rfc3339).</value>
        [DataMember(Name = "validFrom", IsRequired = true, EmitDefaultValue = true)]
        public DateOnly ValidFrom { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TariffVersion {\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ValidFrom: ").Append(ValidFrom).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
