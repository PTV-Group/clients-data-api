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
/**
 * Represents the start or destination location of a combined transport, e.g. the port. The fields **latitude** and **longitude** 
 * can be used as input for combined transport waypoints in the method **calculateRoutePost** of the Routing API.
 * @export
 * @interface CombinedTransportLocation
 */
export interface CombinedTransportLocation {
    /**
     * The latitude value in degrees (WGS84/EPSG:4326) from south to north.
     * @type {number}
     * @memberof CombinedTransportLocation
     */
    latitude: number;
    /**
     * The longitude value in degrees (WGS84/EPSG:4326) from west to east.
     * @type {number}
     * @memberof CombinedTransportLocation
     */
    longitude: number;
    /**
     * The name of the location, usually refers to the district to which the location is assigned.
     * @type {string}
     * @memberof CombinedTransportLocation
     */
    name: string;
    /**
     * The country or subdivision of this location represented by its code according to [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) or [ISO 3166-2](https://en.wikipedia.org/wiki/ISO_3166-2) if referring to a subdivision.
     * @type {string}
     * @memberof CombinedTransportLocation
     */
    countryCode: string;
}

/**
 * Check if a given object implements the CombinedTransportLocation interface.
 */
export function instanceOfCombinedTransportLocation(value: object): value is CombinedTransportLocation {
    if (!('latitude' in value) || value['latitude'] === undefined) return false;
    if (!('longitude' in value) || value['longitude'] === undefined) return false;
    if (!('name' in value) || value['name'] === undefined) return false;
    if (!('countryCode' in value) || value['countryCode'] === undefined) return false;
    return true;
}

export function CombinedTransportLocationFromJSON(json: any): CombinedTransportLocation {
    return CombinedTransportLocationFromJSONTyped(json, false);
}

export function CombinedTransportLocationFromJSONTyped(json: any, ignoreDiscriminator: boolean): CombinedTransportLocation {
    if (json == null) {
        return json;
    }
    return {
        
        'latitude': json['latitude'],
        'longitude': json['longitude'],
        'name': json['name'],
        'countryCode': json['countryCode'],
    };
}

export function CombinedTransportLocationToJSON(value?: CombinedTransportLocation | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'latitude': value['latitude'],
        'longitude': value['longitude'],
        'name': value['name'],
        'countryCode': value['countryCode'],
    };
}
