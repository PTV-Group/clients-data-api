/* tslint:disable */
/* eslint-disable */
/**
 * Data
 * With the Data service you can obtain additional data such as vehicle profiles.
 *
 * The version of the OpenAPI document: 1.9
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


/**
 * The tunnel restriction code according to ADR (European Agreement Concerning the International Carriage of Dangerous Goods by Road) depending on the load of the vehicle.
 * 
 * Relevant for `routing`.
 * 
 * @export
 */
export const TunnelRestrictionCode = {
    NONE: 'NONE',
    B: 'B',
    C: 'C',
    D: 'D',
    E: 'E'
} as const;
export type TunnelRestrictionCode = typeof TunnelRestrictionCode[keyof typeof TunnelRestrictionCode];


export function TunnelRestrictionCodeFromJSON(json: any): TunnelRestrictionCode {
    return TunnelRestrictionCodeFromJSONTyped(json, false);
}

export function TunnelRestrictionCodeFromJSONTyped(json: any, ignoreDiscriminator: boolean): TunnelRestrictionCode {
    return json as TunnelRestrictionCode;
}

export function TunnelRestrictionCodeToJSON(value?: TunnelRestrictionCode | null): any {
    return value as any;
}

