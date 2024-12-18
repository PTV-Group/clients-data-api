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


import * as runtime from '../runtime';
import type {
  ErrorResponse,
  PredefinedVehicleProfiles,
} from '../models/index';
import {
    ErrorResponseFromJSON,
    ErrorResponseToJSON,
    PredefinedVehicleProfilesFromJSON,
    PredefinedVehicleProfilesToJSON,
} from '../models/index';

/**
 * 
 */
export class VehicleProfilesApi extends runtime.BaseAPI {

    /**
     * Returns the predefined vehicle profiles for routing.
     */
    async getPredefinedVehicleProfilesRaw(initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<runtime.ApiResponse<PredefinedVehicleProfiles>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["apiKey"] = await this.configuration.apiKey("apiKey"); // apiKeyAuth authentication
        }

        const response = await this.request({
            path: `/vehicle-profiles/predefined`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        }, initOverrides);

        return new runtime.JSONApiResponse(response, (jsonValue) => PredefinedVehicleProfilesFromJSON(jsonValue));
    }

    /**
     * Returns the predefined vehicle profiles for routing.
     */
    async getPredefinedVehicleProfiles(initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<PredefinedVehicleProfiles> {
        const response = await this.getPredefinedVehicleProfilesRaw(initOverrides);
        return await response.value();
    }

}
