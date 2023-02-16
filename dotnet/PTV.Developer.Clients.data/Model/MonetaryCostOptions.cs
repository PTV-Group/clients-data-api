/*
 * Data
 *
 * With the Data service you can obtain additional data such as vehicle profiles.
 *
 * The version of the OpenAPI document: 1.3
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
    /// MonetaryCostOptions
    /// </summary>
    [DataContract(Name = "MonetaryCostOptions")]
    public partial class MonetaryCostOptions : IEquatable<MonetaryCostOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MonetaryCostOptions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MonetaryCostOptions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MonetaryCostOptions" /> class.
        /// </summary>
        /// <param name="costPerKilometer">Specifies the cost per kilometer. The default value of a profile is used as an example and can change at any time. (required).</param>
        /// <param name="workingCostPerHour">Specifies the cost per hour. It is not applied to service, break or rest periods. The default value of a profile is used as an example and can change at any time. (required).</param>
        public MonetaryCostOptions(double costPerKilometer = default(double), double workingCostPerHour = default(double))
        {
            this.CostPerKilometer = costPerKilometer;
            this.WorkingCostPerHour = workingCostPerHour;
        }

        /// <summary>
        /// Specifies the cost per kilometer. The default value of a profile is used as an example and can change at any time.
        /// </summary>
        /// <value>Specifies the cost per kilometer. The default value of a profile is used as an example and can change at any time.</value>
        [DataMember(Name = "costPerKilometer", IsRequired = true, EmitDefaultValue = true)]
        public double CostPerKilometer { get; set; }

        /// <summary>
        /// Specifies the cost per hour. It is not applied to service, break or rest periods. The default value of a profile is used as an example and can change at any time.
        /// </summary>
        /// <value>Specifies the cost per hour. It is not applied to service, break or rest periods. The default value of a profile is used as an example and can change at any time.</value>
        [DataMember(Name = "workingCostPerHour", IsRequired = true, EmitDefaultValue = true)]
        public double WorkingCostPerHour { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MonetaryCostOptions {\n");
            sb.Append("  CostPerKilometer: ").Append(CostPerKilometer).Append("\n");
            sb.Append("  WorkingCostPerHour: ").Append(WorkingCostPerHour).Append("\n");
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
            return this.Equals(input as MonetaryCostOptions);
        }

        /// <summary>
        /// Returns true if MonetaryCostOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of MonetaryCostOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MonetaryCostOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CostPerKilometer == input.CostPerKilometer ||
                    this.CostPerKilometer.Equals(input.CostPerKilometer)
                ) && 
                (
                    this.WorkingCostPerHour == input.WorkingCostPerHour ||
                    this.WorkingCostPerHour.Equals(input.WorkingCostPerHour)
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
                hashCode = (hashCode * 59) + this.CostPerKilometer.GetHashCode();
                hashCode = (hashCode * 59) + this.WorkingCostPerHour.GetHashCode();
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
            // CostPerKilometer (double) minimum
            if (this.CostPerKilometer < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CostPerKilometer, must be a value greater than or equal to 0.", new [] { "CostPerKilometer" });
            }

            // WorkingCostPerHour (double) minimum
            if (this.WorkingCostPerHour < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WorkingCostPerHour, must be a value greater than or equal to 0.", new [] { "WorkingCostPerHour" });
            }

            yield break;
        }
    }

}
