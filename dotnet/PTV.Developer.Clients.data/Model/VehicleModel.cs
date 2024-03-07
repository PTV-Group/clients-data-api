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
    /// VehicleModel
    /// </summary>
    [DataContract(Name = "VehicleModel")]
    public partial class VehicleModel : IEquatable<VehicleModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VehicleModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleModel" /> class.
        /// </summary>
        /// <param name="predefinedProfile">The predefined profile on which this vehicle model is based. Relevant for calculating routes with this vehicle model in Routing API. (required).</param>
        /// <param name="vehicleType">The type of the vehicle.  The model is able to calculate the consumption of combinations of tractor-like vehicles and trailer-like ones. The following vehicle types are supported.  Tractor-like vehicle types: * &#x60;TRUCK&#x60; - Truck. Total permitted weight &gt; 7.5t. * &#x60;LCV&#x60; - Light Commercial Vehicle. Total permitted weight &lt; 7.5t. * &#x60;SCV&#x60; - Small Commercial Vehicle. Total permitted weight &lt; 3.5t.  Trailer-like vehicle types: * &#x60;TRAILER&#x60; - Trailer * &#x60;SEMI_TRAILER&#x60; - Semi-trailer * &#x60;BODY&#x60; - Body  This list can be extended at any time, clients should handle unknown values properly. Relevant for &#x60;range calculation&#x60;. (required).</param>
        /// <param name="commercial">commercial (required).</param>
        /// <param name="engine">engine.</param>
        /// <param name="battery">battery.</param>
        public VehicleModel(string predefinedProfile = default(string), string vehicleType = default(string), Commercial commercial = default(Commercial), Engine engine = default(Engine), Battery battery = default(Battery))
        {
            // to ensure "predefinedProfile" is required (not null)
            if (predefinedProfile == null)
            {
                throw new ArgumentNullException("predefinedProfile is a required property for VehicleModel and cannot be null");
            }
            this.PredefinedProfile = predefinedProfile;
            // to ensure "vehicleType" is required (not null)
            if (vehicleType == null)
            {
                throw new ArgumentNullException("vehicleType is a required property for VehicleModel and cannot be null");
            }
            this.VehicleType = vehicleType;
            // to ensure "commercial" is required (not null)
            if (commercial == null)
            {
                throw new ArgumentNullException("commercial is a required property for VehicleModel and cannot be null");
            }
            this.Commercial = commercial;
            this.Engine = engine;
            this.Battery = battery;
        }

        /// <summary>
        /// The ID of the vehicle model. It is needed to identify a model-based vehicle in the Routing API.
        /// </summary>
        /// <value>The ID of the vehicle model. It is needed to identify a model-based vehicle in the Routing API.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// The predefined profile on which this vehicle model is based. Relevant for calculating routes with this vehicle model in Routing API.
        /// </summary>
        /// <value>The predefined profile on which this vehicle model is based. Relevant for calculating routes with this vehicle model in Routing API.</value>
        [DataMember(Name = "predefinedProfile", IsRequired = true, EmitDefaultValue = true)]
        public string PredefinedProfile { get; set; }

        /// <summary>
        /// The type of the vehicle.  The model is able to calculate the consumption of combinations of tractor-like vehicles and trailer-like ones. The following vehicle types are supported.  Tractor-like vehicle types: * &#x60;TRUCK&#x60; - Truck. Total permitted weight &gt; 7.5t. * &#x60;LCV&#x60; - Light Commercial Vehicle. Total permitted weight &lt; 7.5t. * &#x60;SCV&#x60; - Small Commercial Vehicle. Total permitted weight &lt; 3.5t.  Trailer-like vehicle types: * &#x60;TRAILER&#x60; - Trailer * &#x60;SEMI_TRAILER&#x60; - Semi-trailer * &#x60;BODY&#x60; - Body  This list can be extended at any time, clients should handle unknown values properly. Relevant for &#x60;range calculation&#x60;.
        /// </summary>
        /// <value>The type of the vehicle.  The model is able to calculate the consumption of combinations of tractor-like vehicles and trailer-like ones. The following vehicle types are supported.  Tractor-like vehicle types: * &#x60;TRUCK&#x60; - Truck. Total permitted weight &gt; 7.5t. * &#x60;LCV&#x60; - Light Commercial Vehicle. Total permitted weight &lt; 7.5t. * &#x60;SCV&#x60; - Small Commercial Vehicle. Total permitted weight &lt; 3.5t.  Trailer-like vehicle types: * &#x60;TRAILER&#x60; - Trailer * &#x60;SEMI_TRAILER&#x60; - Semi-trailer * &#x60;BODY&#x60; - Body  This list can be extended at any time, clients should handle unknown values properly. Relevant for &#x60;range calculation&#x60;.</value>
        [DataMember(Name = "vehicleType", IsRequired = true, EmitDefaultValue = true)]
        public string VehicleType { get; set; }

        /// <summary>
        /// Gets or Sets Commercial
        /// </summary>
        [DataMember(Name = "commercial", IsRequired = true, EmitDefaultValue = true)]
        public Commercial Commercial { get; set; }

        /// <summary>
        /// Gets or Sets Engine
        /// </summary>
        [DataMember(Name = "engine", EmitDefaultValue = false)]
        public Engine Engine { get; set; }

        /// <summary>
        /// Gets or Sets Battery
        /// </summary>
        [DataMember(Name = "battery", EmitDefaultValue = false)]
        public Battery Battery { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VehicleModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PredefinedProfile: ").Append(PredefinedProfile).Append("\n");
            sb.Append("  VehicleType: ").Append(VehicleType).Append("\n");
            sb.Append("  Commercial: ").Append(Commercial).Append("\n");
            sb.Append("  Engine: ").Append(Engine).Append("\n");
            sb.Append("  Battery: ").Append(Battery).Append("\n");
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
            return this.Equals(input as VehicleModel);
        }

        /// <summary>
        /// Returns true if VehicleModel instances are equal
        /// </summary>
        /// <param name="input">Instance of VehicleModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VehicleModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.PredefinedProfile == input.PredefinedProfile ||
                    (this.PredefinedProfile != null &&
                    this.PredefinedProfile.Equals(input.PredefinedProfile))
                ) && 
                (
                    this.VehicleType == input.VehicleType ||
                    (this.VehicleType != null &&
                    this.VehicleType.Equals(input.VehicleType))
                ) && 
                (
                    this.Commercial == input.Commercial ||
                    (this.Commercial != null &&
                    this.Commercial.Equals(input.Commercial))
                ) && 
                (
                    this.Engine == input.Engine ||
                    (this.Engine != null &&
                    this.Engine.Equals(input.Engine))
                ) && 
                (
                    this.Battery == input.Battery ||
                    (this.Battery != null &&
                    this.Battery.Equals(input.Battery))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.PredefinedProfile != null)
                {
                    hashCode = (hashCode * 59) + this.PredefinedProfile.GetHashCode();
                }
                if (this.VehicleType != null)
                {
                    hashCode = (hashCode * 59) + this.VehicleType.GetHashCode();
                }
                if (this.Commercial != null)
                {
                    hashCode = (hashCode * 59) + this.Commercial.GetHashCode();
                }
                if (this.Engine != null)
                {
                    hashCode = (hashCode * 59) + this.Engine.GetHashCode();
                }
                if (this.Battery != null)
                {
                    hashCode = (hashCode * 59) + this.Battery.GetHashCode();
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
            // PredefinedProfile (string) maxLength
            if (this.PredefinedProfile != null && this.PredefinedProfile.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PredefinedProfile, length must be less than 50.", new [] { "PredefinedProfile" });
            }

            // PredefinedProfile (string) minLength
            if (this.PredefinedProfile != null && this.PredefinedProfile.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PredefinedProfile, length must be greater than 1.", new [] { "PredefinedProfile" });
            }

            // VehicleType (string) maxLength
            if (this.VehicleType != null && this.VehicleType.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VehicleType, length must be less than 50.", new [] { "VehicleType" });
            }

            // VehicleType (string) minLength
            if (this.VehicleType != null && this.VehicleType.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VehicleType, length must be greater than 1.", new [] { "VehicleType" });
            }

            yield break;
        }
    }

}
