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
    /// WeeklyScheduleInterval
    /// </summary>
    [DataContract(Name = "WeeklyScheduleInterval")]
    public partial class WeeklyScheduleInterval : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets DayOfWeek
        /// </summary>
        [DataMember(Name = "dayOfWeek", IsRequired = true, EmitDefaultValue = true)]
        public DayOfWeek DayOfWeek { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WeeklyScheduleInterval" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WeeklyScheduleInterval() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WeeklyScheduleInterval" /> class.
        /// </summary>
        /// <param name="dayOfWeek">dayOfWeek (required).</param>
        /// <param name="hour">The hour the schedule interval starts. (required).</param>
        /// <param name="minute">The minutes of hours the schedule interval starts. (required).</param>
        /// <param name="duration">The duration of the schedule interval in [min]. (required).</param>
        public WeeklyScheduleInterval(DayOfWeek dayOfWeek = default(DayOfWeek), int? hour = default(int?), int? minute = default(int?), int? duration = default(int?))
        {
            this.DayOfWeek = dayOfWeek;
            // to ensure "hour" is required (not null)
            if (hour == null)
            {
                throw new ArgumentNullException("hour is a required property for WeeklyScheduleInterval and cannot be null");
            }
            this.Hour = hour;
            // to ensure "minute" is required (not null)
            if (minute == null)
            {
                throw new ArgumentNullException("minute is a required property for WeeklyScheduleInterval and cannot be null");
            }
            this.Minute = minute;
            // to ensure "duration" is required (not null)
            if (duration == null)
            {
                throw new ArgumentNullException("duration is a required property for WeeklyScheduleInterval and cannot be null");
            }
            this.Duration = duration;
        }

        /// <summary>
        /// The hour the schedule interval starts.
        /// </summary>
        /// <value>The hour the schedule interval starts.</value>
        /// <example>12</example>
        [DataMember(Name = "hour", IsRequired = true, EmitDefaultValue = true)]
        public int? Hour { get; set; }

        /// <summary>
        /// The minutes of hours the schedule interval starts.
        /// </summary>
        /// <value>The minutes of hours the schedule interval starts.</value>
        /// <example>30</example>
        [DataMember(Name = "minute", IsRequired = true, EmitDefaultValue = true)]
        public int? Minute { get; set; }

        /// <summary>
        /// The duration of the schedule interval in [min].
        /// </summary>
        /// <value>The duration of the schedule interval in [min].</value>
        /// <example>360</example>
        [DataMember(Name = "duration", IsRequired = true, EmitDefaultValue = true)]
        public int? Duration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WeeklyScheduleInterval {\n");
            sb.Append("  DayOfWeek: ").Append(DayOfWeek).Append("\n");
            sb.Append("  Hour: ").Append(Hour).Append("\n");
            sb.Append("  Minute: ").Append(Minute).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
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
            // Hour (int?) maximum
            if (this.Hour > (int?)23)
            {
                yield return new ValidationResult("Invalid value for Hour, must be a value less than or equal to 23.", new [] { "Hour" });
            }

            // Hour (int?) minimum
            if (this.Hour < (int?)0)
            {
                yield return new ValidationResult("Invalid value for Hour, must be a value greater than or equal to 0.", new [] { "Hour" });
            }

            // Minute (int?) maximum
            if (this.Minute > (int?)59)
            {
                yield return new ValidationResult("Invalid value for Minute, must be a value less than or equal to 59.", new [] { "Minute" });
            }

            // Minute (int?) minimum
            if (this.Minute < (int?)0)
            {
                yield return new ValidationResult("Invalid value for Minute, must be a value greater than or equal to 0.", new [] { "Minute" });
            }

            // Duration (int?) maximum
            if (this.Duration > (int?)10080)
            {
                yield return new ValidationResult("Invalid value for Duration, must be a value less than or equal to 10080.", new [] { "Duration" });
            }

            // Duration (int?) minimum
            if (this.Duration < (int?)1)
            {
                yield return new ValidationResult("Invalid value for Duration, must be a value greater than or equal to 1.", new [] { "Duration" });
            }

            yield break;
        }
    }

}
