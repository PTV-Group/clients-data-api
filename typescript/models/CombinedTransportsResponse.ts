/* tslint:disable */
/* eslint-disable */
/**
 * Data
 * With the Data service you can obtain additional data such as vehicle profiles.
 *
 * The version of the OpenAPI document: 1.11
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { mapValues } from '../runtime';
import type { Warning } from './Warning';
import {
    WarningFromJSON,
    WarningFromJSONTyped,
    WarningToJSON,
} from './Warning';
import type { CombinedTransport } from './CombinedTransport';
import {
    CombinedTransportFromJSON,
    CombinedTransportFromJSONTyped,
    CombinedTransportToJSON,
} from './CombinedTransport';

/**
 * The combined transports selected by the input parameters.
 * @export
 * @interface CombinedTransportsResponse
 */
export interface CombinedTransportsResponse {
    /**
     * The list of selected combined transports sorted by ascending distance to the input coordinate.
     * @type {Array<CombinedTransport>}
     * @memberof CombinedTransportsResponse
     */
    combinedTransports: Array<CombinedTransport>;
    /**
     * A list of warnings concerning the validity of the result.
     * @type {Array<Warning>}
     * @memberof CombinedTransportsResponse
     */
    warnings?: Array<Warning>;
}

/**
 * Check if a given object implements the CombinedTransportsResponse interface.
 */
export function instanceOfCombinedTransportsResponse(value: object): value is CombinedTransportsResponse {
    if (!('combinedTransports' in value) || value['combinedTransports'] === undefined) return false;
    return true;
}

export function CombinedTransportsResponseFromJSON(json: any): CombinedTransportsResponse {
    return CombinedTransportsResponseFromJSONTyped(json, false);
}

export function CombinedTransportsResponseFromJSONTyped(json: any, ignoreDiscriminator: boolean): CombinedTransportsResponse {
    if (json == null) {
        return json;
    }
    return {
        
        'combinedTransports': ((json['combinedTransports'] as Array<any>).map(CombinedTransportFromJSON)),
        'warnings': json['warnings'] == null ? undefined : ((json['warnings'] as Array<any>).map(WarningFromJSON)),
    };
}

export function CombinedTransportsResponseToJSON(value?: CombinedTransportsResponse | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'combinedTransports': ((value['combinedTransports'] as Array<any>).map(CombinedTransportToJSON)),
        'warnings': value['warnings'] == null ? undefined : ((value['warnings'] as Array<any>).map(WarningToJSON)),
    };
}
