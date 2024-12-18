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
import type { TollSystem } from './TollSystem';
import {
    TollSystemFromJSON,
    TollSystemFromJSONTyped,
    TollSystemToJSON,
} from './TollSystem';

/**
 * The toll features contained by this geographical unit.
 * 
 * @export
 * @interface TollFeatures
 */
export interface TollFeatures {
    /**
     * The list of toll systems contained by this geographical unit.
     * @type {Array<TollSystem>}
     * @memberof TollFeatures
     */
    tollSystems: Array<TollSystem>;
}

/**
 * Check if a given object implements the TollFeatures interface.
 */
export function instanceOfTollFeatures(value: object): value is TollFeatures {
    if (!('tollSystems' in value) || value['tollSystems'] === undefined) return false;
    return true;
}

export function TollFeaturesFromJSON(json: any): TollFeatures {
    return TollFeaturesFromJSONTyped(json, false);
}

export function TollFeaturesFromJSONTyped(json: any, ignoreDiscriminator: boolean): TollFeatures {
    if (json == null) {
        return json;
    }
    return {
        
        'tollSystems': ((json['tollSystems'] as Array<any>).map(TollSystemFromJSON)),
    };
}

export function TollFeaturesToJSON(value?: TollFeatures | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'tollSystems': ((value['tollSystems'] as Array<any>).map(TollSystemToJSON)),
    };
}

