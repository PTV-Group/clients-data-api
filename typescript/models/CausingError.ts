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

import { exists, mapValues } from '../runtime';
/**
 * 
 * @export
 * @interface CausingError
 */
export interface CausingError {
    /**
     * A human readable message that describes the error.
     * @type {string}
     * @memberof CausingError
     */
    description: string;
    /**
     * A constant string that can be used to identify this error class programmatically.
     * An errorCode can have **details** to provide information in additional properties which are described with the code they apply to. They are of type string unless otherwise specified.
     * Note that additional errorCodes as well as the **details** of existing errorCodes may be added at any time. Furthermore, the **description** may change at any time.
     * 
     * **Error codes for** `GENERAL_VALIDATION_ERROR`
     * 
     * * `GENERAL_INVALID_VALUE` - A parameter is set to an invalid value.
     *   * `value` - The invalid value.
     * * `GENERAL_UNRECOGNIZED_PARAMETER` - A parameter is unknown.
     * * `GENERAL_MISSING_PARAMETER` - A required parameter is missing.
     * * `GENERAL_MINIMUM_LENGTH_VIOLATED` - The minimum length is violated.
     *   * `minimumLength` - The minimum length (integer).
     * * `GENERAL_MAXIMUM_LENGTH_VIOLATED` - The maximum length is violated.
     *   * `maximumLength` - The maximum length (integer).
     * * `GENERAL_MINIMUM_VALUE_VIOLATED` - The minimum value restriction is violated.
     *   * `minimumValue` - The minimum value (integer or double).
     * * `GENERAL_MAXIMUM_VALUE_VIOLATED` - The maximum value restriction is violated.
     *   * `maximumValue` - The maximum value (integer or double).
     * * `GENERAL_DUPLICATE_PARAMETER` - A parameter is duplicated.
     * * `GENERAL_INVALID_LIST` - A list has an invalid format such as duplicate commas.
     *   * `value` - The invalid list.
     * 
     * **Error codes for** `GENERAL_RESOURCE_NOT_FOUND`
     * 
     * * `GENERAL_INVALID_ID` - The ID does not exist.
     *   * `value` - The invalid ID.
     * @type {string}
     * @memberof CausingError
     */
    errorCode: string;
    /**
     * The name of the affected query or path parameter or a JSONPath to the affected property of the request.
     * @type {string}
     * @memberof CausingError
     */
    parameter?: string;
    /**
     * Additional properties specific to this error class.
     * @type {{ [key: string]: any; }}
     * @memberof CausingError
     */
    details?: { [key: string]: any; };
}

/**
 * Check if a given object implements the CausingError interface.
 */
export function instanceOfCausingError(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "description" in value;
    isInstance = isInstance && "errorCode" in value;

    return isInstance;
}

export function CausingErrorFromJSON(json: any): CausingError {
    return CausingErrorFromJSONTyped(json, false);
}

export function CausingErrorFromJSONTyped(json: any, ignoreDiscriminator: boolean): CausingError {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'description': json['description'],
        'errorCode': json['errorCode'],
        'parameter': !exists(json, 'parameter') ? undefined : json['parameter'],
        'details': !exists(json, 'details') ? undefined : json['details'],
    };
}

export function CausingErrorToJSON(value?: CausingError | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'description': value.description,
        'errorCode': value.errorCode,
        'parameter': value.parameter,
        'details': value.details,
    };
}

