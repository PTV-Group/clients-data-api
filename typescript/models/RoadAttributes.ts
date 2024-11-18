/* tslint:disable */
/* eslint-disable */
/**
 * Data
 * With the Data service you can obtain additional data such as vehicle profiles.
 *
 * The version of the OpenAPI document: 1.13
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { mapValues } from '../runtime';
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
    /**
     * The driving speed on this road is set relative to this value [%].
     * This is useful when, for example, dense traffic is known or expected due to public events or because lanes are closed.
     * Settings this value to 70 means that the driving speed is 70% of the originally assumed driving speed.
     * @type {number}
     * @memberof RoadAttributes
     */
    relativeSpeed?: number;
}

/**
 * Check if a given object implements the RoadAttributes interface.
 */
export function instanceOfRoadAttributes(value: object): value is RoadAttributes {
    return true;
}

export function RoadAttributesFromJSON(json: any): RoadAttributes {
    return RoadAttributesFromJSONTyped(json, false);
}

export function RoadAttributesFromJSONTyped(json: any, ignoreDiscriminator: boolean): RoadAttributes {
    if (json == null) {
        return json;
    }
    return {
        
        'prohibited': json['prohibited'] == null ? undefined : json['prohibited'],
        'relativeSpeed': json['relativeSpeed'] == null ? undefined : json['relativeSpeed'],
    };
}

export function RoadAttributesToJSON(value?: RoadAttributes | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'prohibited': value['prohibited'],
        'relativeSpeed': value['relativeSpeed'],
    };
}

