/*
 * Data
 *
 * With the Data service you can obtain additional data such as vehicle profiles.
 *
 * The version of the OpenAPI document: 1.11
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
    /// VehicleModels
    /// </summary>
    [DataContract(Name = "VehicleModels")]
    public partial class VehicleModels : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleModels" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VehicleModels() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleModels" /> class.
        /// </summary>
        /// <param name="varVehicleModels">A list of model-based vehicles. (required).</param>
        public VehicleModels(List<VehicleModel> varVehicleModels = default(List<VehicleModel>))
        {
            // to ensure "varVehicleModels" is required (not null)
            if (varVehicleModels == null)
            {
                throw new ArgumentNullException("varVehicleModels is a required property for VehicleModels and cannot be null");
            }
            this.VarVehicleModels = varVehicleModels;
        }

        /// <summary>
        /// A list of model-based vehicles.
        /// </summary>
        /// <value>A list of model-based vehicles.</value>
        [DataMember(Name = "vehicleModels", IsRequired = true, EmitDefaultValue = true)]
        public List<VehicleModel> VarVehicleModels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VehicleModels {\n");
            sb.Append("  VarVehicleModels: ").Append(VarVehicleModels).Append("\n");
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