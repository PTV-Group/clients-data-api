/*
 * Data
 *
 * With the Data service you can obtain additional data such as vehicle profiles.
 *
 * The version of the OpenAPI document: 1.9
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
    public partial class TollSystem : IEquatable<TollSystem>, IValidatableObject
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
            this.VarOperator = varOperator;
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
        public string VarOperator { get; set; }

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
            sb.Append("  VarOperator: ").Append(VarOperator).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TollSystem);
        }

        /// <summary>
        /// Returns true if TollSystem instances are equal
        /// </summary>
        /// <param name="input">Instance of TollSystem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TollSystem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.VarOperator == input.VarOperator ||
                    (this.VarOperator != null &&
                    this.VarOperator.Equals(input.VarOperator))
                ) && 
                (
                    this.TariffVersions == input.TariffVersions ||
                    this.TariffVersions != null &&
                    input.TariffVersions != null &&
                    this.TariffVersions.SequenceEqual(input.TariffVersions)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.VarOperator != null)
                {
                    hashCode = (hashCode * 59) + this.VarOperator.GetHashCode();
                }
                if (this.TariffVersions != null)
                {
                    hashCode = (hashCode * 59) + this.TariffVersions.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
