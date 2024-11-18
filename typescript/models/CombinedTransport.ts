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

import { mapValues } from '../runtime';
import type { CombinedTransportLocation } from './CombinedTransportLocation';
import {
    CombinedTransportLocationFromJSON,
    CombinedTransportLocationFromJSONTyped,
    CombinedTransportLocationToJSON,
} from './CombinedTransportLocation';

/**
 * 
 * @export
 * @interface CombinedTransport
 */
export interface CombinedTransport {
    /**
     * The polyline of the combined transport in the format specified by **polylineFormat**.
     * @type {string}
     * @memberof CombinedTransport
     */
    polyline: string;
    /**
     * The name of the combined transport.
     * **Note:** The names of the start location and the destination location do not have to match with the name of
     * the combined transport. In such cases the combined transport name may refer to a roundtrip with one or more 
     * intermediate stops. However, this combined transport represents only the part between the start location 
     * and the destination location.
     * @type {string}
     * @memberof CombinedTransport
     */
    name: string;
    /**
     * The approximated duration of the combined transport [s].
     * @type {number}
     * @memberof CombinedTransport
     */
    duration: number;
    /**
     * The type of the combined transport, i.e. how the vehicle is transported.
     *  * `BOAT` - The combined transport is by boat, i.e. on a ferry.
     *  * `RAIL` - The combined transport is by rail, i.e. on a train or rail shuttle.
     * @type {string}
     * @memberof CombinedTransport
     */
    type: string;
    /**
     * 
     * @type {CombinedTransportLocation}
     * @memberof CombinedTransport
     */
    start: CombinedTransportLocation;
    /**
     * 
     * @type {CombinedTransportLocation}
     * @memberof CombinedTransport
     */
    destination: CombinedTransportLocation;
    /**
     * Comma-separated list of vehicles that may use this combined transport.
     * Values can be `CAR`,`VAN`,`TRUCK`.
     * @type {string}
     * @memberof CombinedTransport
     */
    allowedFor: string;
    /**
     * The combined transport represented as a string that can be used as a **waypoints** parameter in the method **calculateRoute** of the Routing API.
     * @type {string}
     * @memberof CombinedTransport
     */
    waypointsParameter: string;
}

/**
 * Check if a given object implements the CombinedTransport interface.
 */
export function instanceOfCombinedTransport(value: object): value is CombinedTransport {
    if (!('polyline' in value) || value['polyline'] === undefined) return false;
    if (!('name' in value) || value['name'] === undefined) return false;
    if (!('duration' in value) || value['duration'] === undefined) return false;
    if (!('type' in value) || value['type'] === undefined) return false;
    if (!('start' in value) || value['start'] === undefined) return false;
    if (!('destination' in value) || value['destination'] === undefined) return false;
    if (!('allowedFor' in value) || value['allowedFor'] === undefined) return false;
    if (!('waypointsParameter' in value) || value['waypointsParameter'] === undefined) return false;
    return true;
}

export function CombinedTransportFromJSON(json: any): CombinedTransport {
    return CombinedTransportFromJSONTyped(json, false);
}

export function CombinedTransportFromJSONTyped(json: any, ignoreDiscriminator: boolean): CombinedTransport {
    if (json == null) {
        return json;
    }
    return {
        
        'polyline': json['polyline'],
        'name': json['name'],
        'duration': json['duration'],
        'type': json['type'],
        'start': CombinedTransportLocationFromJSON(json['start']),
        'destination': CombinedTransportLocationFromJSON(json['destination']),
        'allowedFor': json['allowedFor'],
        'waypointsParameter': json['waypointsParameter'],
    };
}

export function CombinedTransportToJSON(value?: CombinedTransport | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'polyline': value['polyline'],
        'name': value['name'],
        'duration': value['duration'],
        'type': value['type'],
        'start': CombinedTransportLocationToJSON(value['start']),
        'destination': CombinedTransportLocationToJSON(value['destination']),
        'allowedFor': value['allowedFor'],
        'waypointsParameter': value['waypointsParameter'],
    };
}

