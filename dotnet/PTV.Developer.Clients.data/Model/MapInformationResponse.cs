/*
 * Data
 *
 * With the Data service you can obtain additional data such as vehicle profiles.
 *
 * The version of the OpenAPI document: 1.7
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
    /// MapInformationResponse
    /// </summary>
    [DataContract(Name = "MapInformationResponse")]
    public partial class MapInformationResponse : IEquatable<MapInformationResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MapInformationResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MapInformationResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MapInformationResponse" /> class.
        /// </summary>
        /// <param name="geographicalUnits">Lists the available data and their features for each geographical unit, usually a country or a state, sorted by their ISO 3166 code. (required).</param>
        public MapInformationResponse(List<GeographicalUnit> geographicalUnits = default(List<GeographicalUnit>))
        {
            // to ensure "geographicalUnits" is required (not null)
            if (geographicalUnits == null)
            {
                throw new ArgumentNullException("geographicalUnits is a required property for MapInformationResponse and cannot be null");
            }
            this.GeographicalUnits = geographicalUnits;
        }

        /// <summary>
        /// Lists the available data and their features for each geographical unit, usually a country or a state, sorted by their ISO 3166 code.
        /// </summary>
        /// <value>Lists the available data and their features for each geographical unit, usually a country or a state, sorted by their ISO 3166 code.</value>
        [DataMember(Name = "geographicalUnits", IsRequired = true, EmitDefaultValue = true)]
        public List<GeographicalUnit> GeographicalUnits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MapInformationResponse {\n");
            sb.Append("  GeographicalUnits: ").Append(GeographicalUnits).Append("\n");
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
            return this.Equals(input as MapInformationResponse);
        }

        /// <summary>
        /// Returns true if MapInformationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MapInformationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MapInformationResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GeographicalUnits == input.GeographicalUnits ||
                    this.GeographicalUnits != null &&
                    input.GeographicalUnits != null &&
                    this.GeographicalUnits.SequenceEqual(input.GeographicalUnits)
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
                if (this.GeographicalUnits != null)
                {
                    hashCode = (hashCode * 59) + this.GeographicalUnits.GetHashCode();
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
