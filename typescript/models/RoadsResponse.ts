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
import type { Road } from './Road';
import {
    RoadFromJSON,
    RoadFromJSONTyped,
    RoadToJSON,
} from './Road';

/**
 * The roads selected by the input.
 * @export
 * @interface RoadsResponse
 */
export interface RoadsResponse {
    /**
     * The list of selected roads according to the criteria specified in the request.
     * @type {Array<Road>}
     * @memberof RoadsResponse
     */
    roads?: Array<Road>;
}

/**
 * Check if a given object implements the RoadsResponse interface.
 */
export function instanceOfRoadsResponse(value: object): boolean {
    let isInstance = true;

    return isInstance;
}

export function RoadsResponseFromJSON(json: any): RoadsResponse {
    return RoadsResponseFromJSONTyped(json, false);
}

export function RoadsResponseFromJSONTyped(json: any, ignoreDiscriminator: boolean): RoadsResponse {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'roads': !exists(json, 'roads') ? undefined : ((json['roads'] as Array<any>).map(RoadFromJSON)),
    };
}

export function RoadsResponseToJSON(value?: RoadsResponse | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'roads': value.roads === undefined ? undefined : ((value.roads as Array<any>).map(RoadToJSON)),
    };
}
