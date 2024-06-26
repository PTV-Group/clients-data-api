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
import type { RoadsToBeAttributed } from './RoadsToBeAttributed';
import {
    RoadsToBeAttributedFromJSON,
    RoadsToBeAttributedFromJSONTyped,
    RoadsToBeAttributedToJSON,
} from './RoadsToBeAttributed';

/**
 * A custom road attribute scenario.
 * @export
 * @interface CustomRoadAttributeScenario
 */
export interface CustomRoadAttributeScenario {
    /**
     * The ID of the custom road attribute scenario.
     * @type {string}
     * @memberof CustomRoadAttributeScenario
     */
    readonly id?: string;
    /**
     * A user-defined name of the custom road attribute scenario.
     * If specified, it must be unique for the current user.
     * This name can be used in other APIs instead of its ID, then it must not contain a comma.
     * @type {string}
     * @memberof CustomRoadAttributeScenario
     */
    name?: string;
    /**
     * A collection of roads and attributes to be assigned. The accumulated number of roads from all selectors must
     * not exceed 20000 roads.
     * @type {Array<RoadsToBeAttributed>}
     * @memberof CustomRoadAttributeScenario
     */
    roadsToBeAttributed: Array<RoadsToBeAttributed>;
    /**
     * If true, this custom road attribute scenario can be used by every user by its ID.
     * Other users than the owner cannot modify or delete it nor will it be listed with **getAllCustomRoadAttributeScenarios**.
     * @type {boolean}
     * @memberof CustomRoadAttributeScenario
     */
    shared?: boolean;
    /**
     * If false, this custom road attribute scenario will be marked inactive and not used for subsequent route calculations until set active again.
     * This is useful to ignore the scenario without deleting its contents.
     * @type {boolean}
     * @memberof CustomRoadAttributeScenario
     */
    active?: boolean;
    /**
     * The revision number of the custom road attribute scenario which will automatically be maintained by the server.
     * In responses it will contain the number of updates of this specific scenario. When creating a scenario, it
     * will be ignored. When updating a scenario, pass the number which you got from the server in the corresponding
     * get request to make sure that the scenario has not been changed in the meantime. The server will reject updates
     * for which the revision number does not match the revision stored in the database.
     * When left empty in an update request, any changes will be overwritten.
     * @type {number}
     * @memberof CustomRoadAttributeScenario
     */
    revision?: number;
}

/**
 * Check if a given object implements the CustomRoadAttributeScenario interface.
 */
export function instanceOfCustomRoadAttributeScenario(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "roadsToBeAttributed" in value;

    return isInstance;
}

export function CustomRoadAttributeScenarioFromJSON(json: any): CustomRoadAttributeScenario {
    return CustomRoadAttributeScenarioFromJSONTyped(json, false);
}

export function CustomRoadAttributeScenarioFromJSONTyped(json: any, ignoreDiscriminator: boolean): CustomRoadAttributeScenario {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'id': !exists(json, 'id') ? undefined : json['id'],
        'name': !exists(json, 'name') ? undefined : json['name'],
        'roadsToBeAttributed': ((json['roadsToBeAttributed'] as Array<any>).map(RoadsToBeAttributedFromJSON)),
        'shared': !exists(json, 'shared') ? undefined : json['shared'],
        'active': !exists(json, 'active') ? undefined : json['active'],
        'revision': !exists(json, 'revision') ? undefined : json['revision'],
    };
}

export function CustomRoadAttributeScenarioToJSON(value?: CustomRoadAttributeScenario | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'name': value.name,
        'roadsToBeAttributed': ((value.roadsToBeAttributed as Array<any>).map(RoadsToBeAttributedToJSON)),
        'shared': value.shared,
        'active': value.active,
        'revision': value.revision,
    };
}

