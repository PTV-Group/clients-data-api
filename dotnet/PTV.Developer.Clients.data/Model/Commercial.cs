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
    /// Properties of a vehicle from a commercial point of view.
    /// </summary>
    [DataContract(Name = "Commercial")]
    public partial class Commercial : IEquatable<Commercial>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Commercial" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Commercial() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Commercial" /> class.
        /// </summary>
        /// <param name="manufacturer">The producer of the vehicle. (required).</param>
        /// <param name="model">The model of the vehicle. (required).</param>
        /// <param name="variant">The model variant of the vehicle..</param>
        /// <param name="launchYear">The year the vehicle was launched on the market..</param>
        public Commercial(string manufacturer = default(string), string model = default(string), string variant = default(string), int launchYear = default(int))
        {
            // to ensure "manufacturer" is required (not null)
            if (manufacturer == null)
            {
                throw new ArgumentNullException("manufacturer is a required property for Commercial and cannot be null");
            }
            this.Manufacturer = manufacturer;
            // to ensure "model" is required (not null)
            if (model == null)
            {
                throw new ArgumentNullException("model is a required property for Commercial and cannot be null");
            }
            this.Model = model;
            this.Variant = variant;
            this.LaunchYear = launchYear;
        }

        /// <summary>
        /// The producer of the vehicle.
        /// </summary>
        /// <value>The producer of the vehicle.</value>
        /// <example>FunnyTrucks Inc.</example>
        [DataMember(Name = "manufacturer", IsRequired = true, EmitDefaultValue = true)]
        public string Manufacturer { get; set; }

        /// <summary>
        /// The model of the vehicle.
        /// </summary>
        /// <value>The model of the vehicle.</value>
        /// <example>FT1</example>
        [DataMember(Name = "model", IsRequired = true, EmitDefaultValue = true)]
        public string Model { get; set; }

        /// <summary>
        /// The model variant of the vehicle.
        /// </summary>
        /// <value>The model variant of the vehicle.</value>
        [DataMember(Name = "variant", EmitDefaultValue = false)]
        public string Variant { get; set; }

        /// <summary>
        /// The year the vehicle was launched on the market.
        /// </summary>
        /// <value>The year the vehicle was launched on the market.</value>
        /// <example>2020</example>
        [DataMember(Name = "launchYear", EmitDefaultValue = false)]
        public int LaunchYear { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Commercial {\n");
            sb.Append("  Manufacturer: ").Append(Manufacturer).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  Variant: ").Append(Variant).Append("\n");
            sb.Append("  LaunchYear: ").Append(LaunchYear).Append("\n");
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
            return this.Equals(input as Commercial);
        }

        /// <summary>
        /// Returns true if Commercial instances are equal
        /// </summary>
        /// <param name="input">Instance of Commercial to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Commercial input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Manufacturer == input.Manufacturer ||
                    (this.Manufacturer != null &&
                    this.Manufacturer.Equals(input.Manufacturer))
                ) && 
                (
                    this.Model == input.Model ||
                    (this.Model != null &&
                    this.Model.Equals(input.Model))
                ) && 
                (
                    this.Variant == input.Variant ||
                    (this.Variant != null &&
                    this.Variant.Equals(input.Variant))
                ) && 
                (
                    this.LaunchYear == input.LaunchYear ||
                    this.LaunchYear.Equals(input.LaunchYear)
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
                if (this.Manufacturer != null)
                {
                    hashCode = (hashCode * 59) + this.Manufacturer.GetHashCode();
                }
                if (this.Model != null)
                {
                    hashCode = (hashCode * 59) + this.Model.GetHashCode();
                }
                if (this.Variant != null)
                {
                    hashCode = (hashCode * 59) + this.Variant.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LaunchYear.GetHashCode();
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
            // LaunchYear (int) minimum
            if (this.LaunchYear < (int)1900)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LaunchYear, must be a value greater than or equal to 1900.", new [] { "LaunchYear" });
            }

            yield break;
        }
    }

}