/*
 * Data
 *
 * With the Data service you can obtain additional data such as vehicle profiles.
 *
 * The version of the OpenAPI document: 1.6
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
    /// PredefinedVehicleProfile
    /// </summary>
    [DataContract(Name = "PredefinedVehicleProfile")]
    public partial class PredefinedVehicleProfile : IEquatable<PredefinedVehicleProfile>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        [DataMember(Name = "region", IsRequired = true, EmitDefaultValue = true)]
        public RegionType Region { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PredefinedVehicleProfile" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PredefinedVehicleProfile() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PredefinedVehicleProfile" /> class.
        /// </summary>
        /// <param name="name">The name of the predefined profile. (required).</param>
        /// <param name="description">The description of the predefined profile. (required).</param>
        /// <param name="region">region (required).</param>
        /// <param name="vehicle">vehicle.</param>
        /// <param name="currency">The default currency for the predefined vehicle according to [ISO 4217](https://en.wikipedia.org/wiki/ISO_4217). (required).</param>
        /// <param name="monetaryCostOptions">monetaryCostOptions.</param>
        public PredefinedVehicleProfile(string name = default(string), string description = default(string), RegionType region = default(RegionType), Vehicle vehicle = default(Vehicle), string currency = default(string), MonetaryCostOptions monetaryCostOptions = default(MonetaryCostOptions))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for PredefinedVehicleProfile and cannot be null");
            }
            this.Name = name;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for PredefinedVehicleProfile and cannot be null");
            }
            this.Description = description;
            this.Region = region;
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new ArgumentNullException("currency is a required property for PredefinedVehicleProfile and cannot be null");
            }
            this.Currency = currency;
            this.Vehicle = vehicle;
            this.MonetaryCostOptions = monetaryCostOptions;
        }

        /// <summary>
        /// The name of the predefined profile.
        /// </summary>
        /// <value>The name of the predefined profile.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The description of the predefined profile.
        /// </summary>
        /// <value>The description of the predefined profile.</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Vehicle
        /// </summary>
        [DataMember(Name = "vehicle", EmitDefaultValue = false)]
        public Vehicle Vehicle { get; set; }

        /// <summary>
        /// The default currency for the predefined vehicle according to [ISO 4217](https://en.wikipedia.org/wiki/ISO_4217).
        /// </summary>
        /// <value>The default currency for the predefined vehicle according to [ISO 4217](https://en.wikipedia.org/wiki/ISO_4217).</value>
        [DataMember(Name = "currency", IsRequired = true, EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets MonetaryCostOptions
        /// </summary>
        [DataMember(Name = "monetaryCostOptions", EmitDefaultValue = false)]
        public MonetaryCostOptions MonetaryCostOptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PredefinedVehicleProfile {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  Vehicle: ").Append(Vehicle).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  MonetaryCostOptions: ").Append(MonetaryCostOptions).Append("\n");
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
            return this.Equals(input as PredefinedVehicleProfile);
        }

        /// <summary>
        /// Returns true if PredefinedVehicleProfile instances are equal
        /// </summary>
        /// <param name="input">Instance of PredefinedVehicleProfile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PredefinedVehicleProfile input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Region == input.Region ||
                    this.Region.Equals(input.Region)
                ) && 
                (
                    this.Vehicle == input.Vehicle ||
                    (this.Vehicle != null &&
                    this.Vehicle.Equals(input.Vehicle))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.MonetaryCostOptions == input.MonetaryCostOptions ||
                    (this.MonetaryCostOptions != null &&
                    this.MonetaryCostOptions.Equals(input.MonetaryCostOptions))
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
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Region.GetHashCode();
                if (this.Vehicle != null)
                {
                    hashCode = (hashCode * 59) + this.Vehicle.GetHashCode();
                }
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                if (this.MonetaryCostOptions != null)
                {
                    hashCode = (hashCode * 59) + this.MonetaryCostOptions.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 50.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            yield break;
        }
    }

}
