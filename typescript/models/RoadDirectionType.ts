/* tslint:disable */
/* eslint-disable */
/**
 * Data
 * With the Data service you can obtain additional data such as vehicle profiles.
 *
 * The version of the OpenAPI document: 1.12
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


/**
 * The direction of the road the attributes apply to.
 *  * `POLYLINE_DIRECTION` - Describes the direction from the start node to the end node of the polyline of the road.
 *  * `REVERSE_POLYLINE_DIRECTION` - Describes the direction from the end node to the start node of the polyline of the road.
 *  * `BOTH` - Describes both directions.
 * 
 * If the selection contains more than one road and the direction is different from _BOTH_, an error will be returned.
 * @export
 */
export const RoadDirectionType = {
    POLYLINE_DIRECTION: 'POLYLINE_DIRECTION',
    REVERSE_POLYLINE_DIRECTION: 'REVERSE_POLYLINE_DIRECTION',
    BOTH: 'BOTH'
} as const;
export type RoadDirectionType = typeof RoadDirectionType[keyof typeof RoadDirectionType];


export function instanceOfRoadDirectionType(value: any): boolean {
    for (const key in RoadDirectionType) {
        if (Object.prototype.hasOwnProperty.call(RoadDirectionType, key)) {
            if (RoadDirectionType[key as keyof typeof RoadDirectionType] === value) {
                return true;
            }
        }
    }
    return false;
}

export function RoadDirectionTypeFromJSON(json: any): RoadDirectionType {
    return RoadDirectionTypeFromJSONTyped(json, false);
}

export function RoadDirectionTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): RoadDirectionType {
    return json as RoadDirectionType;
}

export function RoadDirectionTypeToJSON(value?: RoadDirectionType | null): any {
    return value as any;
}

