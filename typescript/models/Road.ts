/* tslint:disable */
/* eslint-disable */
/**
 * Data
 * With the Data service you can obtain additional data such as vehicle profiles.
 *
 * The version of the OpenAPI document: 1.6
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { exists, mapValues } from '../runtime';
/**
 * 
 * @export
 * @interface Road
 */
export interface Road {
    /**
     * The polyline of the road in the format specified by **polylineFormat**.
     * @type {string}
     * @memberof Road
     */
    polyline?: string;
}

/**
 * Check if a given object implements the Road interface.
 */
export function instanceOfRoad(value: object): boolean {
    let isInstance = true;

    return isInstance;
}

export function RoadFromJSON(json: any): Road {
    return RoadFromJSONTyped(json, false);
}

export function RoadFromJSONTyped(json: any, ignoreDiscriminator: boolean): Road {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'polyline': !exists(json, 'polyline') ? undefined : json['polyline'],
    };
}

export function RoadToJSON(value?: Road | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'polyline': value.polyline,
    };
}

