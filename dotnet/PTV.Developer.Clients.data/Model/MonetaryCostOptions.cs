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
    /// MonetaryCostOptions
    /// </summary>
    [DataContract(Name = "MonetaryCostOptions")]
    public partial class MonetaryCostOptions : IValidatableObject
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
        public MonetaryCostOptions(double? costPerKilometer = default(double?), double? workingCostPerHour = default(double?))
        {
            // to ensure "costPerKilometer" is required (not null)
            if (costPerKilometer == null)
            {
                throw new ArgumentNullException("costPerKilometer is a required property for MonetaryCostOptions and cannot be null");
            }
            this.CostPerKilometer = costPerKilometer;
            // to ensure "workingCostPerHour" is required (not null)
            if (workingCostPerHour == null)
            {
                throw new ArgumentNullException("workingCostPerHour is a required property for MonetaryCostOptions and cannot be null");
            }
            this.WorkingCostPerHour = workingCostPerHour;
        }

        /// <summary>
        /// Specifies the cost per kilometer. The default value of a profile is used as an example and can change at any time.
        /// </summary>
        /// <value>Specifies the cost per kilometer. The default value of a profile is used as an example and can change at any time.</value>
        [DataMember(Name = "costPerKilometer", IsRequired = true, EmitDefaultValue = true)]
        public double? CostPerKilometer { get; set; }

        /// <summary>
        /// Specifies the cost per hour. It is not applied to service, break or rest periods. The default value of a profile is used as an example and can change at any time.
        /// </summary>
        /// <value>Specifies the cost per hour. It is not applied to service, break or rest periods. The default value of a profile is used as an example and can change at any time.</value>
        [DataMember(Name = "workingCostPerHour", IsRequired = true, EmitDefaultValue = true)]
        public double? WorkingCostPerHour { get; set; }

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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // CostPerKilometer (double?) minimum
            if (this.CostPerKilometer < (double?)0)
            {
                yield return new ValidationResult("Invalid value for CostPerKilometer, must be a value greater than or equal to 0.", new [] { "CostPerKilometer" });
            }

            // WorkingCostPerHour (double?) minimum
            if (this.WorkingCostPerHour < (double?)0)
            {
                yield return new ValidationResult("Invalid value for WorkingCostPerHour, must be a value greater than or equal to 0.", new [] { "WorkingCostPerHour" });
            }

            yield break;
        }
    }

}
