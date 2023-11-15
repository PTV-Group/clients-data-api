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


/**
 * The electricity type of the vehicle.
 * 
 * Supported for **engineType** _ELECTRIC_ or _HYBRID_. Relevant for `emissions`.
 * 
 * @export
 */
export const ElectricityType = {
    BATTERY: 'BATTERY',
    HYDROGEN_FUEL_CELL: 'HYDROGEN_FUEL_CELL',
    NONE: 'NONE'
} as const;
export type ElectricityType = typeof ElectricityType[keyof typeof ElectricityType];


export function ElectricityTypeFromJSON(json: any): ElectricityType {
    return ElectricityTypeFromJSONTyped(json, false);
}

export function ElectricityTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): ElectricityType {
    return json as ElectricityType;
}

export function ElectricityTypeToJSON(value?: ElectricityType | null): any {
    return value as any;
}

