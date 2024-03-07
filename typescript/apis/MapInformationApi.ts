/* tslint:disable */
/* eslint-disable */
/**
 * Data
 * With the Data service you can obtain additional data such as vehicle profiles.
 *
 * The version of the OpenAPI document: 1.9
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


import * as runtime from '../runtime';
import type {
  ErrorResponse,
  MapInformationResponse,
} from '../models/index';
import {
    ErrorResponseFromJSON,
    ErrorResponseToJSON,
    MapInformationResponseFromJSON,
    MapInformationResponseToJSON,
} from '../models/index';

/**
 * 
 */
export class MapInformationApi extends runtime.BaseAPI {

    /**
     * Gets information about the map. See [here](./concepts/map-information) for more information.
     */
    async getMapInformationRaw(initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<runtime.ApiResponse<MapInformationResponse>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};
		headerParameters['User-Agent'] = "ptv-generated typescript client";

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["apiKey"] = this.configuration.apiKey("apiKey"); // apiKeyAuth authentication
        }

        const response = await this.request({
            path: `/map-information`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        }, initOverrides);

        return new runtime.JSONApiResponse(response, (jsonValue) => MapInformationResponseFromJSON(jsonValue));
    }

    /**
     * Gets information about the map. See [here](./concepts/map-information) for more information.
     */
    async getMapInformation(initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<MapInformationResponse> {
        const response = await this.getMapInformationRaw(initOverrides);
        return await response.value();
    }

}
