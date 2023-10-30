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
 * The fuel type of the vehicle.
 * The fuel types _CNG_GASOLINE_ and _LNG_GASOLINE_ are used for dual-fuel vehicles.
 * 
 * Supported for **engineType** _COMBUSTION_ and _HYBRID_. Relevant for `emissions`.
 * @export
 */
export const FuelType = {
    GASOLINE: 'GASOLINE',
    DIESEL: 'DIESEL',
    COMPRESSED_NATURAL_GAS: 'COMPRESSED_NATURAL_GAS',
    LIQUEFIED_PETROLEUM_GAS: 'LIQUEFIED_PETROLEUM_GAS',
    LIQUEFIED_NATURAL_GAS: 'LIQUEFIED_NATURAL_GAS',
    CNG_GASOLINE: 'CNG_GASOLINE',
    LPG_GASOLINE: 'LPG_GASOLINE',
    ETHANOL: 'ETHANOL',
    NONE: 'NONE'
} as const;
export type FuelType = typeof FuelType[keyof typeof FuelType];


export function FuelTypeFromJSON(json: any): FuelType {
    return FuelTypeFromJSONTyped(json, false);
}

export function FuelTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): FuelType {
    return json as FuelType;
}

export function FuelTypeToJSON(value?: FuelType | null): any {
    return value as any;
}

