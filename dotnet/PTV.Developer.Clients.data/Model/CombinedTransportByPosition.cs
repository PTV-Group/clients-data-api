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
    /// The position around which to scan for combined transports in the map data.
    /// </summary>
    [DataContract(Name = "CombinedTransportByPosition")]
    public partial class CombinedTransportByPosition : IEquatable<CombinedTransportByPosition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CombinedTransportByPosition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CombinedTransportByPosition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CombinedTransportByPosition" /> class.
        /// </summary>
        /// <param name="latitude">The latitude value in degrees (WGS84/EPSG:4326) from south to north. (required).</param>
        /// <param name="longitude">The longitude value in degrees (WGS84/EPSG:4326) from west to east. (required).</param>
        /// <param name="radius">The circle defined by the given point and this radius [m] in which to scan for combined transports. (default to 5000).</param>
        public CombinedTransportByPosition(double latitude = default(double), double longitude = default(double), int radius = 5000)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Radius = radius;
        }

        /// <summary>
        /// The latitude value in degrees (WGS84/EPSG:4326) from south to north.
        /// </summary>
        /// <value>The latitude value in degrees (WGS84/EPSG:4326) from south to north.</value>
        /// <example>49.480301</example>
        [DataMember(Name = "latitude", IsRequired = true, EmitDefaultValue = true)]
        public double Latitude { get; set; }

        /// <summary>
        /// The longitude value in degrees (WGS84/EPSG:4326) from west to east.
        /// </summary>
        /// <value>The longitude value in degrees (WGS84/EPSG:4326) from west to east.</value>
        /// <example>6.110667</example>
        [DataMember(Name = "longitude", IsRequired = true, EmitDefaultValue = true)]
        public double Longitude { get; set; }

        /// <summary>
        /// The circle defined by the given point and this radius [m] in which to scan for combined transports.
        /// </summary>
        /// <value>The circle defined by the given point and this radius [m] in which to scan for combined transports.</value>
        [DataMember(Name = "radius", EmitDefaultValue = false)]
        public int Radius { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CombinedTransportByPosition {\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  Radius: ").Append(Radius).Append("\n");
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
            return this.Equals(input as CombinedTransportByPosition);
        }

        /// <summary>
        /// Returns true if CombinedTransportByPosition instances are equal
        /// </summary>
        /// <param name="input">Instance of CombinedTransportByPosition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CombinedTransportByPosition input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Latitude == input.Latitude ||
                    this.Latitude.Equals(input.Latitude)
                ) && 
                (
                    this.Longitude == input.Longitude ||
                    this.Longitude.Equals(input.Longitude)
                ) && 
                (
                    this.Radius == input.Radius ||
                    this.Radius.Equals(input.Radius)
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
                hashCode = (hashCode * 59) + this.Latitude.GetHashCode();
                hashCode = (hashCode * 59) + this.Longitude.GetHashCode();
                hashCode = (hashCode * 59) + this.Radius.GetHashCode();
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
            // Latitude (double) maximum
            if (this.Latitude > (double)90)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Latitude, must be a value less than or equal to 90.", new [] { "Latitude" });
            }

            // Latitude (double) minimum
            if (this.Latitude < (double)-90)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Latitude, must be a value greater than or equal to -90.", new [] { "Latitude" });
            }

            // Longitude (double) maximum
            if (this.Longitude > (double)180)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Longitude, must be a value less than or equal to 180.", new [] { "Longitude" });
            }

            // Longitude (double) minimum
            if (this.Longitude < (double)-180)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Longitude, must be a value greater than or equal to -180.", new [] { "Longitude" });
            }

            // Radius (int) minimum
            if (this.Radius < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Radius, must be a value greater than or equal to 1.", new [] { "Radius" });
            }

            yield break;
        }
    }

}
