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
  CombinedTransportByPosition,
  CombinedTransportByText,
  CombinedTransportsResponse,
  ErrorResponse,
  MapInformationResponse,
  PolylineFormat,
} from '../models/index';
import {
    CombinedTransportByPositionFromJSON,
    CombinedTransportByPositionToJSON,
    CombinedTransportByTextFromJSON,
    CombinedTransportByTextToJSON,
    CombinedTransportsResponseFromJSON,
    CombinedTransportsResponseToJSON,
    ErrorResponseFromJSON,
    ErrorResponseToJSON,
    MapInformationResponseFromJSON,
    MapInformationResponseToJSON,
    PolylineFormatFromJSON,
    PolylineFormatToJSON,
} from '../models/index';

export interface GetCombinedTransportsRequest {
    position?: CombinedTransportByPosition;
    text?: CombinedTransportByText;
    polylineFormat?: PolylineFormat;
}

/**
 * 
 */
export class MapInformationApi extends runtime.BaseAPI {

    /**
     * Get combined transports from a (click) point on a map or matching a given text input.  A request will be rejected if  * it covers more than 5000 combined transports or * if neither the parameter **position** nor the parameter **text** is specified.
     */
    async getCombinedTransportsRaw(requestParameters: GetCombinedTransportsRequest, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<runtime.ApiResponse<CombinedTransportsResponse>> {
        const queryParameters: any = {};

        if (requestParameters['position'] != null) {
            queryParameters['position'] = requestParameters['position'];
        }

        if (requestParameters['text'] != null) {
            queryParameters['text'] = requestParameters['text'];
        }

        if (requestParameters['polylineFormat'] != null) {
            queryParameters['polylineFormat'] = requestParameters['polylineFormat'];
        }

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["apiKey"] = await this.configuration.apiKey("apiKey"); // apiKeyAuth authentication
        }

        const response = await this.request({
            path: `/combined-transports`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        }, initOverrides);

        return new runtime.JSONApiResponse(response, (jsonValue) => CombinedTransportsResponseFromJSON(jsonValue));
    }

    /**
     * Get combined transports from a (click) point on a map or matching a given text input.  A request will be rejected if  * it covers more than 5000 combined transports or * if neither the parameter **position** nor the parameter **text** is specified.
     */
    async getCombinedTransports(requestParameters: GetCombinedTransportsRequest = {}, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<CombinedTransportsResponse> {
        const response = await this.getCombinedTransportsRaw(requestParameters, initOverrides);
        return await response.value();
    }

    /**
     * Gets information about the map. See [here](./concepts/map-information) for more information.
     */
    async getMapInformationRaw(initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<runtime.ApiResponse<MapInformationResponse>> {
        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["apiKey"] = await this.configuration.apiKey("apiKey"); // apiKeyAuth authentication
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
