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
    /// The periods during which the attributes are valid. If both time intervals and weekly schedule are specified, the attributes are valid only during the weekly schedule within the time intervals. If there is no such period, the attributes are never valid. If not specified, the attributes are always valid.
    /// </summary>
    [DataContract(Name = "Validity")]
    public partial class Validity : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Validity" /> class.
        /// </summary>
        /// <param name="timeIntervals">If the attributes are valid during specific periods, specify concrete time intervals. Each time interval has an explicit start and end date. Overlapping intervals will be merged..</param>
        /// <param name="weeklySchedule">If the attributes are valid in a regular manner, i.e. at specific times and/or days of week, specify a weekly schedule. Each interval is specified by the starting point in time and the duration. The starting points of the intervals must be in local time and in ascending order. Overlapping intervals will be merged. The total duration of all intervals must not exceed one week (168 hours)..</param>
        public Validity(List<TimeInterval> timeIntervals = default(List<TimeInterval>), List<WeeklyScheduleInterval> weeklySchedule = default(List<WeeklyScheduleInterval>))
        {
            this.TimeIntervals = timeIntervals;
            this.WeeklySchedule = weeklySchedule;
        }

        /// <summary>
        /// If the attributes are valid during specific periods, specify concrete time intervals. Each time interval has an explicit start and end date. Overlapping intervals will be merged.
        /// </summary>
        /// <value>If the attributes are valid during specific periods, specify concrete time intervals. Each time interval has an explicit start and end date. Overlapping intervals will be merged.</value>
        [DataMember(Name = "timeIntervals", EmitDefaultValue = false)]
        public List<TimeInterval> TimeIntervals { get; set; }

        /// <summary>
        /// If the attributes are valid in a regular manner, i.e. at specific times and/or days of week, specify a weekly schedule. Each interval is specified by the starting point in time and the duration. The starting points of the intervals must be in local time and in ascending order. Overlapping intervals will be merged. The total duration of all intervals must not exceed one week (168 hours).
        /// </summary>
        /// <value>If the attributes are valid in a regular manner, i.e. at specific times and/or days of week, specify a weekly schedule. Each interval is specified by the starting point in time and the duration. The starting points of the intervals must be in local time and in ascending order. Overlapping intervals will be merged. The total duration of all intervals must not exceed one week (168 hours).</value>
        [DataMember(Name = "weeklySchedule", EmitDefaultValue = false)]
        public List<WeeklyScheduleInterval> WeeklySchedule { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Validity {\n");
            sb.Append("  TimeIntervals: ").Append(TimeIntervals).Append("\n");
            sb.Append("  WeeklySchedule: ").Append(WeeklySchedule).Append("\n");
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
