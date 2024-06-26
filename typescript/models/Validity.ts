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
import type { TimeInterval } from './TimeInterval';
import {
    TimeIntervalFromJSON,
    TimeIntervalFromJSONTyped,
    TimeIntervalToJSON,
} from './TimeInterval';
import type { WeeklyScheduleInterval } from './WeeklyScheduleInterval';
import {
    WeeklyScheduleIntervalFromJSON,
    WeeklyScheduleIntervalFromJSONTyped,
    WeeklyScheduleIntervalToJSON,
} from './WeeklyScheduleInterval';

/**
 * The periods during which the attributes are valid.
 * If both time intervals and weekly schedule are specified, the attributes are valid only during the weekly schedule
 * within the time intervals. If there is no such period, the attributes are never valid.
 * If not specified, the attributes are always valid.
 * @export
 * @interface Validity
 */
export interface Validity {
    /**
     * If the attributes are valid during specific periods, specify concrete time intervals.
     * Each time interval has an explicit start and end date.
     * Overlapping intervals will be merged.
     * @type {Array<TimeInterval>}
     * @memberof Validity
     */
    timeIntervals?: Array<TimeInterval>;
    /**
     * If the attributes are valid in a regular manner, i.e. at specific times and/or days of week, specify a weekly schedule.
     * Each interval is specified by the starting point in time and the duration.
     * The starting points of the intervals must be in local time and in ascending order. Overlapping intervals will be merged.
     * The total duration of all intervals must not exceed one week (168 hours).
     * @type {Array<WeeklyScheduleInterval>}
     * @memberof Validity
     */
    weeklySchedule?: Array<WeeklyScheduleInterval>;
}

/**
 * Check if a given object implements the Validity interface.
 */
export function instanceOfValidity(value: object): boolean {
    let isInstance = true;

    return isInstance;
}

export function ValidityFromJSON(json: any): Validity {
    return ValidityFromJSONTyped(json, false);
}

export function ValidityFromJSONTyped(json: any, ignoreDiscriminator: boolean): Validity {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'timeIntervals': !exists(json, 'timeIntervals') ? undefined : ((json['timeIntervals'] as Array<any>).map(TimeIntervalFromJSON)),
        'weeklySchedule': !exists(json, 'weeklySchedule') ? undefined : ((json['weeklySchedule'] as Array<any>).map(WeeklyScheduleIntervalFromJSON)),
    };
}

export function ValidityToJSON(value?: Validity | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'timeIntervals': value.timeIntervals === undefined ? undefined : ((value.timeIntervals as Array<any>).map(TimeIntervalToJSON)),
        'weeklySchedule': value.weeklySchedule === undefined ? undefined : ((value.weeklySchedule as Array<any>).map(WeeklyScheduleIntervalToJSON)),
    };
}

