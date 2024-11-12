/*
 * Data
 *
 * With the Data service you can obtain additional data such as vehicle profiles.
 *
 * The version of the OpenAPI document: 1.12
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
    /// The features supported by this geographical unit. 
    /// </summary>
    [DataContract(Name = "MapFeatures")]
    public partial class MapFeatures : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MapFeatures" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MapFeatures() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MapFeatures" /> class.
        /// </summary>
        /// <param name="toll">If true, toll is supported in this geographical unit. False means that no toll data is available or toll does not apply in this geographical unit. Vignettes are not considered. (required).</param>
        /// <param name="tollFeatures">tollFeatures.</param>
        public MapFeatures(bool? toll = default(bool?), TollFeatures tollFeatures = default(TollFeatures))
        {
            // to ensure "toll" is required (not null)
            if (toll == null)
            {
                throw new ArgumentNullException("toll is a required property for MapFeatures and cannot be null");
            }
            this.Toll = toll;
            this.TollFeatures = tollFeatures;
        }

        /// <summary>
        /// If true, toll is supported in this geographical unit. False means that no toll data is available or toll does not apply in this geographical unit. Vignettes are not considered.
        /// </summary>
        /// <value>If true, toll is supported in this geographical unit. False means that no toll data is available or toll does not apply in this geographical unit. Vignettes are not considered.</value>
        [DataMember(Name = "toll", IsRequired = true, EmitDefaultValue = true)]
        public bool? Toll { get; set; }

        /// <summary>
        /// Gets or Sets TollFeatures
        /// </summary>
        [DataMember(Name = "tollFeatures", EmitDefaultValue = false)]
        public TollFeatures TollFeatures { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MapFeatures {\n");
            sb.Append("  Toll: ").Append(Toll).Append("\n");
            sb.Append("  TollFeatures: ").Append(TollFeatures).Append("\n");
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
