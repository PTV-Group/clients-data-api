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


import * as runtime from '../runtime';
import type {
  ErrorResponse,
  VehicleModels,
} from '../models/index';
import {
    ErrorResponseFromJSON,
    ErrorResponseToJSON,
    VehicleModelsFromJSON,
    VehicleModelsToJSON,
} from '../models/index';

export interface GetVehicleModelsRequest {
    identification?: string;
    vehicleTypes?: Array<string>;
}

/**
 * 
 */
export class VehicleModelsApi extends runtime.BaseAPI {

    /**
     * A list of **VehicleModel** objects. Only vehicle models matching all filters are returned. In case that no vehicle model is found an empty list is returned. In case no filters are applied, all available vehicle models are returned.  This method is in a preview state, the API is stable, feature changes could be introduced in future.
     */
    async getVehicleModelsRaw(requestParameters: GetVehicleModelsRequest, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<runtime.ApiResponse<VehicleModels>> {
        const queryParameters: any = {};

        if (requestParameters.identification !== undefined) {
            queryParameters['identification'] = requestParameters.identification;
        }

        if (requestParameters.vehicleTypes) {
            queryParameters['vehicleTypes'] = requestParameters.vehicleTypes.join(runtime.COLLECTION_FORMATS["csv"]);
        }

        const headerParameters: runtime.HTTPHeaders = {};
		headerParameters['User-Agent'] = "ptv-generated typescript client";

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["apiKey"] = this.configuration.apiKey("apiKey"); // apiKeyAuth authentication
        }

        const response = await this.request({
            path: `/vehicle-models`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        }, initOverrides);

        return new runtime.JSONApiResponse(response, (jsonValue) => VehicleModelsFromJSON(jsonValue));
    }

    /**
     * A list of **VehicleModel** objects. Only vehicle models matching all filters are returned. In case that no vehicle model is found an empty list is returned. In case no filters are applied, all available vehicle models are returned.  This method is in a preview state, the API is stable, feature changes could be introduced in future.
     */
    async getVehicleModels(requestParameters: GetVehicleModelsRequest = {}, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<VehicleModels> {
        const response = await this.getVehicleModelsRaw(requestParameters, initOverrides);
        return await response.value();
    }

}
