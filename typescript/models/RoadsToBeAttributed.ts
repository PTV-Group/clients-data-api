/* tslint:disable */
/* eslint-disable */
/**
 * Data
 * With the Data service you can obtain additional data such as vehicle profiles.
 *
 * The version of the OpenAPI document: 1.12
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { mapValues } from '../runtime';
import type { Validity } from './Validity';
import {
    ValidityFromJSON,
    ValidityFromJSONTyped,
    ValidityToJSON,
} from './Validity';
import type { RoadAttributes } from './RoadAttributes';
import {
    RoadAttributesFromJSON,
    RoadAttributesFromJSONTyped,
    RoadAttributesToJSON,
} from './RoadAttributes';
import type { RoadDirectionType } from './RoadDirectionType';
import {
    RoadDirectionTypeFromJSON,
    RoadDirectionTypeFromJSONTyped,
    RoadDirectionTypeToJSON,
} from './RoadDirectionType';

/**
 * 
 * @export
 * @interface RoadsToBeAttributed
 */
export interface RoadsToBeAttributed {
    /**
     * A point, a polyline or a polygon to select roads.
     * 
     * For a single point the road closest to this point will be selected. Several points where the first and last 
     * point are different will be considered a polyline and all roads intersected by this polyline will be 
     * selected. If the polyline is closed, i.e. the first and the last point are the same, the polyline defines 
     * a polygon and all roads whose complete polyline is within the polygon will be selected. A polygon must be 
     * valid according to [OGC](https://www.ogc.org/standard/sfa/). Holes within polygons are not supported.
     * Ferries will not be selected.
     * 
     * Format: `<point1_lat>,<point1_lon>,...,<pointN_lat>,<pointN_lon>`.
     * 
     * A request will be rejected if it
     * * does not contain an even number of coordinates,
     * * contains a closed polyline defining an invalid polygon according to OGC,
     * * contains invalid coordinates,
     * * covers no road or
     * * covers more than 5000 roads.
     * @type {string}
     * @memberof RoadsToBeAttributed
     */
    points: string;
    /**
     * The polylines of the roads in the format specified by **polylineFormat**.
     * 
     * Only present in responses, will be ignored in requests.
     * @type {Array<string>}
     * @memberof RoadsToBeAttributed
     */
    polylines?: Array<string>;
    /**
     * 
     * @type {RoadDirectionType}
     * @memberof RoadsToBeAttributed
     */
    direction?: RoadDirectionType;
    /**
     * 
     * @type {RoadAttributes}
     * @memberof RoadsToBeAttributed
     */
    attributes: RoadAttributes;
    /**
     * 
     * @type {Validity}
     * @memberof RoadsToBeAttributed
     */
    validity?: Validity;
    /**
     * If **roadsToBeAttributed** could not be matched to a new map after an update they are marked with this boolean flag.
     * Unmatched **roadsToBeAttributed** might cause some unwanted changes of behavior for the scenario.
     * This parameter must not be true if it is sent as part of a request.
     * @type {boolean}
     * @memberof RoadsToBeAttributed
     */
    unmatchedAfterMapUpdate?: boolean;
    /**
     * A description of this set of attributed roads which is useful to refer to that in an application.
     * @type {string}
     * @memberof RoadsToBeAttributed
     */
    description?: string;
}



/**
 * Check if a given object implements the RoadsToBeAttributed interface.
 */
export function instanceOfRoadsToBeAttributed(value: object): value is RoadsToBeAttributed {
    if (!('points' in value) || value['points'] === undefined) return false;
    if (!('attributes' in value) || value['attributes'] === undefined) return false;
    return true;
}

export function RoadsToBeAttributedFromJSON(json: any): RoadsToBeAttributed {
    return RoadsToBeAttributedFromJSONTyped(json, false);
}

export function RoadsToBeAttributedFromJSONTyped(json: any, ignoreDiscriminator: boolean): RoadsToBeAttributed {
    if (json == null) {
        return json;
    }
    return {
        
        'points': json['points'],
        'polylines': json['polylines'] == null ? undefined : json['polylines'],
        'direction': json['direction'] == null ? undefined : RoadDirectionTypeFromJSON(json['direction']),
        'attributes': RoadAttributesFromJSON(json['attributes']),
        'validity': json['validity'] == null ? undefined : ValidityFromJSON(json['validity']),
        'unmatchedAfterMapUpdate': json['unmatchedAfterMapUpdate'] == null ? undefined : json['unmatchedAfterMapUpdate'],
        'description': json['description'] == null ? undefined : json['description'],
    };
}

export function RoadsToBeAttributedToJSON(value?: RoadsToBeAttributed | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'points': value['points'],
        'polylines': value['polylines'],
        'direction': RoadDirectionTypeToJSON(value['direction']),
        'attributes': RoadAttributesToJSON(value['attributes']),
        'validity': ValidityToJSON(value['validity']),
        'unmatchedAfterMapUpdate': value['unmatchedAfterMapUpdate'],
        'description': value['description'],
    };
}

