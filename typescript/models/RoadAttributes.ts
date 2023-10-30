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
 * The attributes assigned to each of the selected roads.
 * @export
 * @interface RoadAttributes
 */
export interface RoadAttributes {
    /**
     * The road is prohibited, it will not be used in route calculation. Setting this value to false does not have a meaning.
     * @type {boolean}
     * @memberof RoadAttributes
     */
    prohibited?: boolean;
}

/**
 * Check if a given object implements the RoadAttributes interface.
 */
export function instanceOfRoadAttributes(value: object): boolean {
    let isInstance = true;

    return isInstance;
}

export function RoadAttributesFromJSON(json: any): RoadAttributes {
    return RoadAttributesFromJSONTyped(json, false);
}

export function RoadAttributesFromJSONTyped(json: any, ignoreDiscriminator: boolean): RoadAttributes {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'prohibited': !exists(json, 'prohibited') ? undefined : json['prohibited'],
    };
}

export function RoadAttributesToJSON(value?: RoadAttributes | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'prohibited': value.prohibited,
    };
}

