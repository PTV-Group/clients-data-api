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


/**
 * The emission standard of the vehicle valid in the European Union.
 * This parameter is not only important for toll and emission calculation but also for considering 
 * low-emission zones which can be entered only if the vehicle has a proper emission standard.
 * In contrast to explicit approvals like environmental badges or vehicle registrations
 * the emission standard is automatically considered when entering such low-emission zones.
 * 
 * Values different from _NONE_ are supported for **engineType** _COMBUSTION_ and _HYBRID_. Relevant for `routing`, `toll`, `emissions`.
 * 
 * @export
 */
export const EmissionStandard = {
    NONE: 'NONE',
    EURO_0: 'EURO_0',
    EURO_1: 'EURO_1',
    EURO_2: 'EURO_2',
    EURO_3: 'EURO_3',
    EURO_4: 'EURO_4',
    EURO_5: 'EURO_5',
    EURO_EEV: 'EURO_EEV',
    EURO_6: 'EURO_6',
    EURO_6C: 'EURO_6C',
    EURO_6D_TEMP: 'EURO_6D_TEMP',
    EURO_6D: 'EURO_6D',
    EURO_6E: 'EURO_6E',
    EURO_7: 'EURO_7'
} as const;
export type EmissionStandard = typeof EmissionStandard[keyof typeof EmissionStandard];


export function instanceOfEmissionStandard(value: any): boolean {
    for (const key in EmissionStandard) {
        if (Object.prototype.hasOwnProperty.call(EmissionStandard, key)) {
            if (EmissionStandard[key as keyof typeof EmissionStandard] === value) {
                return true;
            }
        }
    }
    return false;
}

export function EmissionStandardFromJSON(json: any): EmissionStandard {
    return EmissionStandardFromJSONTyped(json, false);
}

export function EmissionStandardFromJSONTyped(json: any, ignoreDiscriminator: boolean): EmissionStandard {
    return json as EmissionStandard;
}

export function EmissionStandardToJSON(value?: EmissionStandard | null): any {
    return value as any;
}

