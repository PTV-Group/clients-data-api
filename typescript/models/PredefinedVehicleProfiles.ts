/* tslint:disable */
/* eslint-disable */
/**
 * Data
 * With the Data service you can obtain additional data such as vehicle profiles.
 *
 * The version of the OpenAPI document: 1.10
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { exists, mapValues } from '../runtime';
import type { PredefinedVehicleProfile } from './PredefinedVehicleProfile';
import {
    PredefinedVehicleProfileFromJSON,
    PredefinedVehicleProfileFromJSONTyped,
    PredefinedVehicleProfileToJSON,
} from './PredefinedVehicleProfile';

/**
 * 
 * @export
 * @interface PredefinedVehicleProfiles
 */
export interface PredefinedVehicleProfiles {
    /**
     * A list of predefined vehicle profiles.
     * @type {Array<PredefinedVehicleProfile>}
     * @memberof PredefinedVehicleProfiles
     */
    profiles: Array<PredefinedVehicleProfile>;
}

/**
 * Check if a given object implements the PredefinedVehicleProfiles interface.
 */
export function instanceOfPredefinedVehicleProfiles(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "profiles" in value;

    return isInstance;
}

export function PredefinedVehicleProfilesFromJSON(json: any): PredefinedVehicleProfiles {
    return PredefinedVehicleProfilesFromJSONTyped(json, false);
}

export function PredefinedVehicleProfilesFromJSONTyped(json: any, ignoreDiscriminator: boolean): PredefinedVehicleProfiles {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'profiles': ((json['profiles'] as Array<any>).map(PredefinedVehicleProfileFromJSON)),
    };
}

export function PredefinedVehicleProfilesToJSON(value?: PredefinedVehicleProfiles | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'profiles': ((value.profiles as Array<any>).map(PredefinedVehicleProfileToJSON)),
    };
}

