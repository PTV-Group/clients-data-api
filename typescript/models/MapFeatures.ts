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
import type { TollFeatures } from './TollFeatures';
import {
    TollFeaturesFromJSON,
    TollFeaturesFromJSONTyped,
    TollFeaturesToJSON,
} from './TollFeatures';

/**
 * The features supported by this geographical unit.
 * 
 * @export
 * @interface MapFeatures
 */
export interface MapFeatures {
    /**
     * If true, toll is supported in this geographical unit.
     * False means that no toll data is available or toll does not apply in this geographical unit.
     * Vignettes are not considered.
     * @type {boolean}
     * @memberof MapFeatures
     */
    toll: boolean;
    /**
     * 
     * @type {TollFeatures}
     * @memberof MapFeatures
     */
    tollFeatures?: TollFeatures;
}

/**
 * Check if a given object implements the MapFeatures interface.
 */
export function instanceOfMapFeatures(value: object): value is MapFeatures {
    if (!('toll' in value) || value['toll'] === undefined) return false;
    return true;
}

export function MapFeaturesFromJSON(json: any): MapFeatures {
    return MapFeaturesFromJSONTyped(json, false);
}

export function MapFeaturesFromJSONTyped(json: any, ignoreDiscriminator: boolean): MapFeatures {
    if (json == null) {
        return json;
    }
    return {
        
        'toll': json['toll'],
        'tollFeatures': json['tollFeatures'] == null ? undefined : TollFeaturesFromJSON(json['tollFeatures']),
    };
}

export function MapFeaturesToJSON(value?: MapFeatures | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'toll': value['toll'],
        'tollFeatures': TollFeaturesToJSON(value['tollFeatures']),
    };
}

