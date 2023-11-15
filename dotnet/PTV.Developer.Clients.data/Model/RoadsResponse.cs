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
    /// The roads selected by the input.
    /// </summary>
    [DataContract(Name = "RoadsResponse")]
    public partial class RoadsResponse : IEquatable<RoadsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoadsResponse" /> class.
        /// </summary>
        /// <param name="roads">The list of selected roads according to the criteria specified in the request..</param>
        public RoadsResponse(List<Road> roads = default(List<Road>))
        {
            this.Roads = roads;
        }

        /// <summary>
        /// The list of selected roads according to the criteria specified in the request.
        /// </summary>
        /// <value>The list of selected roads according to the criteria specified in the request.</value>
        [DataMember(Name = "roads", EmitDefaultValue = false)]
        public List<Road> Roads { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RoadsResponse {\n");
            sb.Append("  Roads: ").Append(Roads).Append("\n");
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
            return this.Equals(input as RoadsResponse);
        }

        /// <summary>
        /// Returns true if RoadsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RoadsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoadsResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Roads == input.Roads ||
                    this.Roads != null &&
                    input.Roads != null &&
                    this.Roads.SequenceEqual(input.Roads)
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
                if (this.Roads != null)
                {
                    hashCode = (hashCode * 59) + this.Roads.GetHashCode();
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
