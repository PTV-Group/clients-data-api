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
import type { MonetaryCostOptions } from './MonetaryCostOptions';
import {
    MonetaryCostOptionsFromJSON,
    MonetaryCostOptionsFromJSONTyped,
    MonetaryCostOptionsToJSON,
} from './MonetaryCostOptions';
import type { RegionType } from './RegionType';
import {
    RegionTypeFromJSON,
    RegionTypeFromJSONTyped,
    RegionTypeToJSON,
} from './RegionType';
import type { Vehicle } from './Vehicle';
import {
    VehicleFromJSON,
    VehicleFromJSONTyped,
    VehicleToJSON,
} from './Vehicle';

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
export function instanceOfPredefinedVehicleProfile(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "name" in value;
    isInstance = isInstance && "description" in value;
    isInstance = isInstance && "region" in value;
    isInstance = isInstance && "currency" in value;

    return isInstance;
}

export function PredefinedVehicleProfileFromJSON(json: any): PredefinedVehicleProfile {
    return PredefinedVehicleProfileFromJSONTyped(json, false);
}

export function PredefinedVehicleProfileFromJSONTyped(json: any, ignoreDiscriminator: boolean): PredefinedVehicleProfile {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'name': json['name'],
        'description': json['description'],
        'region': RegionTypeFromJSON(json['region']),
        'vehicle': !exists(json, 'vehicle') ? undefined : VehicleFromJSON(json['vehicle']),
        'currency': json['currency'],
        'monetaryCostOptions': !exists(json, 'monetaryCostOptions') ? undefined : MonetaryCostOptionsFromJSON(json['monetaryCostOptions']),
    };
}

export function PredefinedVehicleProfileToJSON(value?: PredefinedVehicleProfile | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'name': value.name,
        'description': value.description,
        'region': RegionTypeToJSON(value.region),
        'vehicle': VehicleToJSON(value.vehicle),
        'currency': value.currency,
        'monetaryCostOptions': MonetaryCostOptionsToJSON(value.monetaryCostOptions),
    };
}

