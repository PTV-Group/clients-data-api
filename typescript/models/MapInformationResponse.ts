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
import type { GeographicalUnit } from './GeographicalUnit';
import {
    GeographicalUnitFromJSON,
    GeographicalUnitFromJSONTyped,
    GeographicalUnitToJSON,
} from './GeographicalUnit';

/**
 * 
 * @export
 * @interface MapInformationResponse
 */
export interface MapInformationResponse {
    /**
     * Lists the available data and their features for each geographical unit, usually a country or a state, sorted by their ISO 3166 code.
     * @type {Array<GeographicalUnit>}
     * @memberof MapInformationResponse
     */
    geographicalUnits: Array<GeographicalUnit>;
}

/**
 * Check if a given object implements the MapInformationResponse interface.
 */
export function instanceOfMapInformationResponse(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "geographicalUnits" in value;

    return isInstance;
}

export function MapInformationResponseFromJSON(json: any): MapInformationResponse {
    return MapInformationResponseFromJSONTyped(json, false);
}

export function MapInformationResponseFromJSONTyped(json: any, ignoreDiscriminator: boolean): MapInformationResponse {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'geographicalUnits': ((json['geographicalUnits'] as Array<any>).map(GeographicalUnitFromJSON)),
    };
}

export function MapInformationResponseToJSON(value?: MapInformationResponse | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'geographicalUnits': ((value.geographicalUnits as Array<any>).map(GeographicalUnitToJSON)),
    };
}

