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
    /// Road
    /// </summary>
    [DataContract(Name = "Road")]
    public partial class Road : IEquatable<Road>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Road" /> class.
        /// </summary>
        /// <param name="polyline">The polyline of the road in the format specified by **polylineFormat**..</param>
        public Road(string polyline = default(string))
        {
            this.Polyline = polyline;
        }

        /// <summary>
        /// The polyline of the road in the format specified by **polylineFormat**.
        /// </summary>
        /// <value>The polyline of the road in the format specified by **polylineFormat**.</value>
        [DataMember(Name = "polyline", EmitDefaultValue = false)]
        public string Polyline { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Road {\n");
            sb.Append("  Polyline: ").Append(Polyline).Append("\n");
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
            return this.Equals(input as Road);
        }

        /// <summary>
        /// Returns true if Road instances are equal
        /// </summary>
        /// <param name="input">Instance of Road to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Road input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Polyline == input.Polyline ||
                    (this.Polyline != null &&
                    this.Polyline.Equals(input.Polyline))
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
                if (this.Polyline != null)
                {
                    hashCode = (hashCode * 59) + this.Polyline.GetHashCode();
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
            yield break;
        }
    }

}
