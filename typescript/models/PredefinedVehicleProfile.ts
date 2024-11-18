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
import type { Vehicle } from './Vehicle';
import {
    VehicleFromJSON,
    VehicleFromJSONTyped,
    VehicleToJSON,
} from './Vehicle';
import type { RegionType } from './RegionType';
import {
    RegionTypeFromJSON,
    RegionTypeFromJSONTyped,
    RegionTypeToJSON,
} from './RegionType';
import type { MonetaryCostOptions } from './MonetaryCostOptions';
import {
    MonetaryCostOptionsFromJSON,
    MonetaryCostOptionsFromJSONTyped,
    MonetaryCostOptionsToJSON,
} from './MonetaryCostOptions';

/**
 * 
 * @export
 * @interface PredefinedVehicleProfile
 */
export interface PredefinedVehicleProfile {
    /**
     * The name of the predefined profile.
     * @type {string}
     * @memberof PredefinedVehicleProfile
     */
    name: string;
    /**
     * The description of the predefined profile.
     * @type {string}
     * @memberof PredefinedVehicleProfile
     */
    description: string;
    /**
     * 
     * @type {RegionType}
     * @memberof PredefinedVehicleProfile
     */
    region: RegionType;
    /**
     * 
     * @type {Vehicle}
     * @memberof PredefinedVehicleProfile
     */
    vehicle?: Vehicle;
    /**
     * The default currency for the predefined vehicle according to [ISO 4217](https://en.wikipedia.org/wiki/ISO_4217).
     * @type {string}
     * @memberof PredefinedVehicleProfile
     */
    currency: string;
    /**
     * 
     * @type {MonetaryCostOptions}
     * @memberof PredefinedVehicleProfile
     */
    monetaryCostOptions?: MonetaryCostOptions;
}



/**
 * Check if a given object implements the PredefinedVehicleProfile interface.
 */
export function instanceOfPredefinedVehicleProfile(value: object): value is PredefinedVehicleProfile {
    if (!('name' in value) || value['name'] === undefined) return false;
    if (!('description' in value) || value['description'] === undefined) return false;
    if (!('region' in value) || value['region'] === undefined) return false;
    if (!('currency' in value) || value['currency'] === undefined) return false;
    return true;
}

export function PredefinedVehicleProfileFromJSON(json: any): PredefinedVehicleProfile {
    return PredefinedVehicleProfileFromJSONTyped(json, false);
}

export function PredefinedVehicleProfileFromJSONTyped(json: any, ignoreDiscriminator: boolean): PredefinedVehicleProfile {
    if (json == null) {
        return json;
    }
    return {
        
        'name': json['name'],
        'description': json['description'],
        'region': RegionTypeFromJSON(json['region']),
        'vehicle': json['vehicle'] == null ? undefined : VehicleFromJSON(json['vehicle']),
        'currency': json['currency'],
        'monetaryCostOptions': json['monetaryCostOptions'] == null ? undefined : MonetaryCostOptionsFromJSON(json['monetaryCostOptions']),
    };
}

export function PredefinedVehicleProfileToJSON(value?: PredefinedVehicleProfile | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'name': value['name'],
        'description': value['description'],
        'region': RegionTypeToJSON(value['region']),
        'vehicle': VehicleToJSON(value['vehicle']),
        'currency': value['currency'],
        'monetaryCostOptions': MonetaryCostOptionsToJSON(value['monetaryCostOptions']),
    };
}

