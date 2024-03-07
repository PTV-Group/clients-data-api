/* tslint:disable */
/* eslint-disable */
/**
 * Data
 * With the Data service you can obtain additional data such as vehicle profiles.
 *
 * The version of the OpenAPI document: 1.9
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { exists, mapValues } from '../runtime';
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
import type { Validity } from './Validity';
import {
    ValidityFromJSON,
    ValidityFromJSONTyped,
    ValidityToJSON,
} from './Validity';

/**
 * A collection of roads and attributes to be assigned.
 * @export
 * @interface RoadsToBeAttributed
 */
export interface RoadsToBeAttributed {
    /**
     * A point or a polyline to select roads.
     * 
     * For a single point the road closest to this point will be selected. Several points will be considered
     * a polyline and all roads intersected by this polyline will be selected. The polyline must not be closed,
     * i.e. the first and the last point must be different. To obtain best results a polyline should not cover
     * more than one time zone. Ferries will not be selected.
     * 
     * Format: `<point1_lat>,<point1_lon>,...,<pointN_lat>,<pointN_lon>`.
     * 
     * A request will be rejected if it
     * * does not contain an even number of coordinates,
     * * contains a closed polyline,
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
export function instanceOfRoadsToBeAttributed(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "points" in value;
    isInstance = isInstance && "attributes" in value;

    return isInstance;
}

export function RoadsToBeAttributedFromJSON(json: any): RoadsToBeAttributed {
    return RoadsToBeAttributedFromJSONTyped(json, false);
}

export function RoadsToBeAttributedFromJSONTyped(json: any, ignoreDiscriminator: boolean): RoadsToBeAttributed {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'points': json['points'],
        'polylines': !exists(json, 'polylines') ? undefined : json['polylines'],
        'direction': !exists(json, 'direction') ? undefined : RoadDirectionTypeFromJSON(json['direction']),
        'attributes': RoadAttributesFromJSON(json['attributes']),
        'validity': !exists(json, 'validity') ? undefined : ValidityFromJSON(json['validity']),
        'unmatchedAfterMapUpdate': !exists(json, 'unmatchedAfterMapUpdate') ? undefined : json['unmatchedAfterMapUpdate'],
        'description': !exists(json, 'description') ? undefined : json['description'],
    };
}

export function RoadsToBeAttributedToJSON(value?: RoadsToBeAttributed | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'points': value.points,
        'polylines': value.polylines,
        'direction': RoadDirectionTypeToJSON(value.direction),
        'attributes': RoadAttributesToJSON(value.attributes),
        'validity': ValidityToJSON(value.validity),
        'unmatchedAfterMapUpdate': value.unmatchedAfterMapUpdate,
        'description': value.description,
    };
}

