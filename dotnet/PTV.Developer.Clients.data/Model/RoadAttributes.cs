/*
 * Data
 *
 * With the Data service you can obtain additional data such as vehicle profiles.
 *
 * The version of the OpenAPI document: 1.13
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
    /// The attributes assigned to each of the selected roads.
    /// </summary>
    [DataContract(Name = "RoadAttributes")]
    public partial class RoadAttributes : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoadAttributes" /> class.
        /// </summary>
        /// <param name="prohibited">The road is prohibited, it will not be used in route calculation. Setting this value to false does not have a meaning..</param>
        /// <param name="relativeSpeed">The driving speed on this road is set relative to this value [%]. This is useful when, for example, dense traffic is known or expected due to public events or because lanes are closed. Settings this value to 70 means that the driving speed is 70% of the originally assumed driving speed..</param>
        public RoadAttributes(bool? prohibited = default(bool?), int? relativeSpeed = default(int?))
        {
            this.Prohibited = prohibited;
            this.RelativeSpeed = relativeSpeed;
        }

        /// <summary>
        /// The road is prohibited, it will not be used in route calculation. Setting this value to false does not have a meaning.
        /// </summary>
        /// <value>The road is prohibited, it will not be used in route calculation. Setting this value to false does not have a meaning.</value>
        [DataMember(Name = "prohibited", EmitDefaultValue = true)]
        public bool? Prohibited { get; set; }

        /// <summary>
        /// The driving speed on this road is set relative to this value [%]. This is useful when, for example, dense traffic is known or expected due to public events or because lanes are closed. Settings this value to 70 means that the driving speed is 70% of the originally assumed driving speed.
        /// </summary>
        /// <value>The driving speed on this road is set relative to this value [%]. This is useful when, for example, dense traffic is known or expected due to public events or because lanes are closed. Settings this value to 70 means that the driving speed is 70% of the originally assumed driving speed.</value>
        /// <example>70</example>
        [DataMember(Name = "relativeSpeed", EmitDefaultValue = true)]
        public int? RelativeSpeed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RoadAttributes {\n");
            sb.Append("  Prohibited: ").Append(Prohibited).Append("\n");
            sb.Append("  RelativeSpeed: ").Append(RelativeSpeed).Append("\n");
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
            // RelativeSpeed (int?) maximum
            if (this.RelativeSpeed > (int?)99)
            {
                yield return new ValidationResult("Invalid value for RelativeSpeed, must be a value less than or equal to 99.", new [] { "RelativeSpeed" });
            }

            // RelativeSpeed (int?) minimum
            if (this.RelativeSpeed < (int?)1)
            {
                yield return new ValidationResult("Invalid value for RelativeSpeed, must be a value greater than or equal to 1.", new [] { "RelativeSpeed" });
            }

            yield break;
        }
    }

}
