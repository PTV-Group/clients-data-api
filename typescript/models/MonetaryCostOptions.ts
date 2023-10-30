/* tslint:disable */
/* eslint-disable */
/**
 * Data
 * With the Data service you can obtain additional data such as vehicle profiles.
 *
 * The version of the OpenAPI document: 1.3
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
 * @interface MonetaryCostOptions
 */
export interface MonetaryCostOptions {
    /**
     * Specifies the cost per kilometer. The default value of a profile is used as an example and can change at any time.
     * @type {number}
     * @memberof MonetaryCostOptions
     */
    costPerKilometer: number;
    /**
     * Specifies the cost per hour. It is not applied to service, break or rest periods. The default value of a profile is used as an example and can change at any time.
     * @type {number}
     * @memberof MonetaryCostOptions
     */
    workingCostPerHour: number;
}

/**
 * Check if a given object implements the MonetaryCostOptions interface.
 */
export function instanceOfMonetaryCostOptions(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "costPerKilometer" in value;
    isInstance = isInstance && "workingCostPerHour" in value;

    return isInstance;
}

export function MonetaryCostOptionsFromJSON(json: any): MonetaryCostOptions {
    return MonetaryCostOptionsFromJSONTyped(json, false);
}

export function MonetaryCostOptionsFromJSONTyped(json: any, ignoreDiscriminator: boolean): MonetaryCostOptions {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'costPerKilometer': json['costPerKilometer'],
        'workingCostPerHour': json['workingCostPerHour'],
    };
}

export function MonetaryCostOptionsToJSON(value?: MonetaryCostOptions | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'costPerKilometer': value.costPerKilometer,
        'workingCostPerHour': value.workingCostPerHour,
    };
}
