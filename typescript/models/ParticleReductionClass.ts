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


/**
 * The particle reduction class (Partikelminderungsklasse) according to 'Anlage XIV zu &sect; 48 StVZO' (German law).
 * 
 * Supported for **engineType** _COMBUSTION_ and _HYBRID_. Relevant for `toll`.
 * @export
 */
export const ParticleReductionClass = {
    PMK_0: 'PMK_0',
    PMK_1: 'PMK_1',
    PMK_2: 'PMK_2',
    PMK_3: 'PMK_3',
    PMK_4: 'PMK_4',
    NONE: 'NONE'
} as const;
export type ParticleReductionClass = typeof ParticleReductionClass[keyof typeof ParticleReductionClass];


export function ParticleReductionClassFromJSON(json: any): ParticleReductionClass {
    return ParticleReductionClassFromJSONTyped(json, false);
}

export function ParticleReductionClassFromJSONTyped(json: any, ignoreDiscriminator: boolean): ParticleReductionClass {
    return json as ParticleReductionClass;
}

export function ParticleReductionClassToJSON(value?: ParticleReductionClass | null): any {
    return value as any;
}
