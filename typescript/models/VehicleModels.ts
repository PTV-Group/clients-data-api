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
import type { VehicleModel } from './VehicleModel';
import {
    VehicleModelFromJSON,
    VehicleModelFromJSONTyped,
    VehicleModelToJSON,
} from './VehicleModel';

/**
 * 
 * @export
 * @interface VehicleModels
 */
export interface VehicleModels {
    /**
     * A list of model-based vehicles.
     * @type {Array<VehicleModel>}
     * @memberof VehicleModels
     */
    vehicleModels: Array<VehicleModel>;
}

/**
 * Check if a given object implements the VehicleModels interface.
 */
export function instanceOfVehicleModels(value: object): value is VehicleModels {
    if (!('vehicleModels' in value) || value['vehicleModels'] === undefined) return false;
    return true;
}

export function VehicleModelsFromJSON(json: any): VehicleModels {
    return VehicleModelsFromJSONTyped(json, false);
}

export function VehicleModelsFromJSONTyped(json: any, ignoreDiscriminator: boolean): VehicleModels {
    if (json == null) {
        return json;
    }
    return {
        
        'vehicleModels': ((json['vehicleModels'] as Array<any>).map(VehicleModelFromJSON)),
    };
}

export function VehicleModelsToJSON(value?: VehicleModels | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'vehicleModels': ((value['vehicleModels'] as Array<any>).map(VehicleModelToJSON)),
    };
}

