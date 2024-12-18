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
    /// RoadsToBeAttributed
    /// </summary>
    [DataContract(Name = "RoadsToBeAttributed")]
    public partial class RoadsToBeAttributed : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [DataMember(Name = "direction", EmitDefaultValue = true)]
        public RoadDirectionType? Direction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RoadsToBeAttributed" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RoadsToBeAttributed() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RoadsToBeAttributed" /> class.
        /// </summary>
        /// <param name="points">A point, a polyline or a polygon to select roads.  For a single point the road closest to this point will be selected. Several points where the first and last  point are different will be considered a polyline and all roads intersected by this polyline will be  selected. If the polyline is closed, i.e. the first and the last point are the same, the polyline defines  a polygon and all roads whose complete polyline is within the polygon will be selected. A polygon must be  valid according to [OGC](https://www.ogc.org/standard/sfa/). Holes within polygons are not supported. Ferries will not be selected.  Format: &#x60;&lt;point1_lat&gt;,&lt;point1_lon&gt;,...,&lt;pointN_lat&gt;,&lt;pointN_lon&gt;&#x60;.  A request will be rejected if it * does not contain an even number of coordinates, * contains a closed polyline defining an invalid polygon according to OGC, * contains invalid coordinates, * covers no road or * covers more than 5000 roads. (required).</param>
        /// <param name="polylines">The polylines of the roads in the format specified by **polylineFormat**.  Only present in responses, will be ignored in requests..</param>
        /// <param name="direction">direction.</param>
        /// <param name="attributes">attributes (required).</param>
        /// <param name="validity">validity.</param>
        /// <param name="unmatchedAfterMapUpdate">If **roadsToBeAttributed** could not be matched to a new map after an update they are marked with this boolean flag. Unmatched **roadsToBeAttributed** might cause some unwanted changes of behavior for the scenario. This parameter must not be true if it is sent as part of a request. (default to false).</param>
        /// <param name="description">A description of this set of attributed roads which is useful to refer to that in an application..</param>
        public RoadsToBeAttributed(string points = default(string), List<string> polylines = default(List<string>), RoadDirectionType? direction = default(RoadDirectionType?), RoadAttributes attributes = default(RoadAttributes), Validity validity = default(Validity), bool? unmatchedAfterMapUpdate = false, string description = default(string))
        {
            // to ensure "points" is required (not null)
            if (points == null)
            {
                throw new ArgumentNullException("points is a required property for RoadsToBeAttributed and cannot be null");
            }
            this.Points = points;
            // to ensure "attributes" is required (not null)
            if (attributes == null)
            {
                throw new ArgumentNullException("attributes is a required property for RoadsToBeAttributed and cannot be null");
            }
            this.Attributes = attributes;
            this.Polylines = polylines;
            this.Direction = direction;
            this.Validity = validity;
            // use default value if no "unmatchedAfterMapUpdate" provided
            this.UnmatchedAfterMapUpdate = unmatchedAfterMapUpdate ?? false;
            this.Description = description;
        }

        /// <summary>
        /// A point, a polyline or a polygon to select roads.  For a single point the road closest to this point will be selected. Several points where the first and last  point are different will be considered a polyline and all roads intersected by this polyline will be  selected. If the polyline is closed, i.e. the first and the last point are the same, the polyline defines  a polygon and all roads whose complete polyline is within the polygon will be selected. A polygon must be  valid according to [OGC](https://www.ogc.org/standard/sfa/). Holes within polygons are not supported. Ferries will not be selected.  Format: &#x60;&lt;point1_lat&gt;,&lt;point1_lon&gt;,...,&lt;pointN_lat&gt;,&lt;pointN_lon&gt;&#x60;.  A request will be rejected if it * does not contain an even number of coordinates, * contains a closed polyline defining an invalid polygon according to OGC, * contains invalid coordinates, * covers no road or * covers more than 5000 roads.
        /// </summary>
        /// <value>A point, a polyline or a polygon to select roads.  For a single point the road closest to this point will be selected. Several points where the first and last  point are different will be considered a polyline and all roads intersected by this polyline will be  selected. If the polyline is closed, i.e. the first and the last point are the same, the polyline defines  a polygon and all roads whose complete polyline is within the polygon will be selected. A polygon must be  valid according to [OGC](https://www.ogc.org/standard/sfa/). Holes within polygons are not supported. Ferries will not be selected.  Format: &#x60;&lt;point1_lat&gt;,&lt;point1_lon&gt;,...,&lt;pointN_lat&gt;,&lt;pointN_lon&gt;&#x60;.  A request will be rejected if it * does not contain an even number of coordinates, * contains a closed polyline defining an invalid polygon according to OGC, * contains invalid coordinates, * covers no road or * covers more than 5000 roads.</value>
        [DataMember(Name = "points", IsRequired = true, EmitDefaultValue = true)]
        public string Points { get; set; }

        /// <summary>
        /// The polylines of the roads in the format specified by **polylineFormat**.  Only present in responses, will be ignored in requests.
        /// </summary>
        /// <value>The polylines of the roads in the format specified by **polylineFormat**.  Only present in responses, will be ignored in requests.</value>
        [DataMember(Name = "polylines", EmitDefaultValue = false)]
        public List<string> Polylines { get; set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name = "attributes", IsRequired = true, EmitDefaultValue = true)]
        public RoadAttributes Attributes { get; set; }

        /// <summary>
        /// Gets or Sets Validity
        /// </summary>
        [DataMember(Name = "validity", EmitDefaultValue = false)]
        public Validity Validity { get; set; }

        /// <summary>
        /// If **roadsToBeAttributed** could not be matched to a new map after an update they are marked with this boolean flag. Unmatched **roadsToBeAttributed** might cause some unwanted changes of behavior for the scenario. This parameter must not be true if it is sent as part of a request.
        /// </summary>
        /// <value>If **roadsToBeAttributed** could not be matched to a new map after an update they are marked with this boolean flag. Unmatched **roadsToBeAttributed** might cause some unwanted changes of behavior for the scenario. This parameter must not be true if it is sent as part of a request.</value>
        [DataMember(Name = "unmatchedAfterMapUpdate", EmitDefaultValue = true)]
        public bool? UnmatchedAfterMapUpdate { get; set; }

        /// <summary>
        /// A description of this set of attributed roads which is useful to refer to that in an application.
        /// </summary>
        /// <value>A description of this set of attributed roads which is useful to refer to that in an application.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RoadsToBeAttributed {\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
            sb.Append("  Polylines: ").Append(Polylines).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Validity: ").Append(Validity).Append("\n");
            sb.Append("  UnmatchedAfterMapUpdate: ").Append(UnmatchedAfterMapUpdate).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
