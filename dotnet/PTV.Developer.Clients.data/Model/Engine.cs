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
    /// Physical and legal properties of the engine of a vehicle. It is null for an unpowered vehicle.
    /// </summary>
    [DataContract(Name = "Engine")]
    public partial class Engine : IEquatable<Engine>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets EngineType
        /// </summary>
        [DataMember(Name = "engineType", IsRequired = true, EmitDefaultValue = true)]
        public EngineType EngineType { get; set; }

        /// <summary>
        /// Gets or Sets EmissionStandard
        /// </summary>
        [DataMember(Name = "emissionStandard", IsRequired = true, EmitDefaultValue = true)]
        public EmissionStandard EmissionStandard { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Engine" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Engine() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Engine" /> class.
        /// </summary>
        /// <param name="engineType">engineType (required).</param>
        /// <param name="maximumSpeed">Maximum travel speed [km/h].  Relevant for &#x60;range calculation&#x60;.  (required).</param>
        /// <param name="ecoSpeed">Recommended, reduced speed to ensure high efficiency [km/h].  Relevant for &#x60;range calculation&#x60;.  (required).</param>
        /// <param name="emissionStandard">emissionStandard (required).</param>
        /// <param name="power">The maximum available power of the vehicle [kW]..</param>
        /// <param name="officialRange">The manufacturer given official range of the vehicle with this drive train [km]..</param>
        public Engine(EngineType engineType = default(EngineType), int maximumSpeed = default(int), int ecoSpeed = default(int), EmissionStandard emissionStandard = default(EmissionStandard), int power = default(int), int officialRange = default(int))
        {
            this.EngineType = engineType;
            this.MaximumSpeed = maximumSpeed;
            this.EcoSpeed = ecoSpeed;
            this.EmissionStandard = emissionStandard;
            this.Power = power;
            this.OfficialRange = officialRange;
        }

        /// <summary>
        /// Maximum travel speed [km/h].  Relevant for &#x60;range calculation&#x60;. 
        /// </summary>
        /// <value>Maximum travel speed [km/h].  Relevant for &#x60;range calculation&#x60;. </value>
        [DataMember(Name = "maximumSpeed", IsRequired = true, EmitDefaultValue = true)]
        public int MaximumSpeed { get; set; }

        /// <summary>
        /// Recommended, reduced speed to ensure high efficiency [km/h].  Relevant for &#x60;range calculation&#x60;. 
        /// </summary>
        /// <value>Recommended, reduced speed to ensure high efficiency [km/h].  Relevant for &#x60;range calculation&#x60;. </value>
        [DataMember(Name = "ecoSpeed", IsRequired = true, EmitDefaultValue = true)]
        public int EcoSpeed { get; set; }

        /// <summary>
        /// The maximum available power of the vehicle [kW].
        /// </summary>
        /// <value>The maximum available power of the vehicle [kW].</value>
        [DataMember(Name = "power", EmitDefaultValue = false)]
        public int Power { get; set; }

        /// <summary>
        /// The manufacturer given official range of the vehicle with this drive train [km].
        /// </summary>
        /// <value>The manufacturer given official range of the vehicle with this drive train [km].</value>
        [DataMember(Name = "officialRange", EmitDefaultValue = false)]
        public int OfficialRange { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Engine {\n");
            sb.Append("  EngineType: ").Append(EngineType).Append("\n");
            sb.Append("  MaximumSpeed: ").Append(MaximumSpeed).Append("\n");
            sb.Append("  EcoSpeed: ").Append(EcoSpeed).Append("\n");
            sb.Append("  EmissionStandard: ").Append(EmissionStandard).Append("\n");
            sb.Append("  Power: ").Append(Power).Append("\n");
            sb.Append("  OfficialRange: ").Append(OfficialRange).Append("\n");
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
            return this.Equals(input as Engine);
        }

        /// <summary>
        /// Returns true if Engine instances are equal
        /// </summary>
        /// <param name="input">Instance of Engine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Engine input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EngineType == input.EngineType ||
                    this.EngineType.Equals(input.EngineType)
                ) && 
                (
                    this.MaximumSpeed == input.MaximumSpeed ||
                    this.MaximumSpeed.Equals(input.MaximumSpeed)
                ) && 
                (
                    this.EcoSpeed == input.EcoSpeed ||
                    this.EcoSpeed.Equals(input.EcoSpeed)
                ) && 
                (
                    this.EmissionStandard == input.EmissionStandard ||
                    this.EmissionStandard.Equals(input.EmissionStandard)
                ) && 
                (
                    this.Power == input.Power ||
                    this.Power.Equals(input.Power)
                ) && 
                (
                    this.OfficialRange == input.OfficialRange ||
                    this.OfficialRange.Equals(input.OfficialRange)
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
                hashCode = (hashCode * 59) + this.EngineType.GetHashCode();
                hashCode = (hashCode * 59) + this.MaximumSpeed.GetHashCode();
                hashCode = (hashCode * 59) + this.EcoSpeed.GetHashCode();
                hashCode = (hashCode * 59) + this.EmissionStandard.GetHashCode();
                hashCode = (hashCode * 59) + this.Power.GetHashCode();
                hashCode = (hashCode * 59) + this.OfficialRange.GetHashCode();
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
