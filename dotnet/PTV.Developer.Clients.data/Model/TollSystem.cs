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
    /// Contains information about the toll system such as the name, operator and especially the different tariff versions that are currently available.
    /// </summary>
    [DataContract(Name = "TollSystem")]
    public partial class TollSystem : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TollSystem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TollSystem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TollSystem" /> class.
        /// </summary>
        /// <param name="name">The name of the toll system. (required).</param>
        /// <param name="varOperator">The operator of the toll system. (required).</param>
        /// <param name="tariffVersions">The tariff versions. (required).</param>
        public TollSystem(string name = default(string), string varOperator = default(string), List<TariffVersion> tariffVersions = default(List<TariffVersion>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for TollSystem and cannot be null");
            }
            this.Name = name;
            // to ensure "varOperator" is required (not null)
            if (varOperator == null)
            {
                throw new ArgumentNullException("varOperator is a required property for TollSystem and cannot be null");
            }
            this.Operator = varOperator;
            // to ensure "tariffVersions" is required (not null)
            if (tariffVersions == null)
            {
                throw new ArgumentNullException("tariffVersions is a required property for TollSystem and cannot be null");
            }
            this.TariffVersions = tariffVersions;
        }

        /// <summary>
        /// The name of the toll system.
        /// </summary>
        /// <value>The name of the toll system.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The operator of the toll system.
        /// </summary>
        /// <value>The operator of the toll system.</value>
        [DataMember(Name = "operator", IsRequired = true, EmitDefaultValue = true)]
        public string Operator { get; set; }

        /// <summary>
        /// The tariff versions.
        /// </summary>
        /// <value>The tariff versions.</value>
        [DataMember(Name = "tariffVersions", IsRequired = true, EmitDefaultValue = true)]
        public List<TariffVersion> TariffVersions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TollSystem {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  TariffVersions: ").Append(TariffVersions).Append("\n");
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
