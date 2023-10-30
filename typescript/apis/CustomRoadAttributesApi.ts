/* tslint:disable */
/* eslint-disable */
/**
 * Data
 * With the Data service you can obtain additional data such as vehicle profiles.
 *
 * The version of the OpenAPI document: 1.6
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


import * as runtime from '../runtime';
import type {
  CustomRoadAttributeScenario,
  CustomRoadAttributeScenarioList,
  ErrorResponse,
  PolylineFormat,
  RoadAttributesResults,
  RoadsResponse,
} from '../models';
import {
    CustomRoadAttributeScenarioFromJSON,
    CustomRoadAttributeScenarioToJSON,
    CustomRoadAttributeScenarioListFromJSON,
    CustomRoadAttributeScenarioListToJSON,
    ErrorResponseFromJSON,
    ErrorResponseToJSON,
    PolylineFormatFromJSON,
    PolylineFormatToJSON,
    RoadAttributesResultsFromJSON,
    RoadAttributesResultsToJSON,
    RoadsResponseFromJSON,
    RoadsResponseToJSON,
} from '../models';

export interface CreateCustomRoadAttributeScenarioRequest {
    customRoadAttributeScenario: CustomRoadAttributeScenario;
    results?: Array<RoadAttributesResults>;
    polylineFormat?: PolylineFormat;
}

export interface DeleteCustomRoadAttributeScenarioRequest {
    scenarioId: string;
}

export interface GetAllCustomRoadAttributeScenariosRequest {
    results?: Array<RoadAttributesResults>;
    polylineFormat?: PolylineFormat;
}

export interface GetCustomRoadAttributeScenarioRequest {
    scenarioId: string;
    results?: Array<RoadAttributesResults>;
    polylineFormat?: PolylineFormat;
}

export interface GetRoadsRequest {
    points: string;
    polylineFormat?: PolylineFormat;
}

export interface UpdateCustomRoadAttributeScenarioRequest {
    scenarioId: string;
    customRoadAttributeScenario: CustomRoadAttributeScenario;
    results?: Array<RoadAttributesResults>;
    polylineFormat?: PolylineFormat;
}

/**
 * 
 */
export class CustomRoadAttributesApi extends runtime.BaseAPI {

    /**
     * Create a custom road attribute scenario.  This method is in an experimental state and may change at any time.
     */
    async createCustomRoadAttributeScenarioRaw(requestParameters: CreateCustomRoadAttributeScenarioRequest, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<runtime.ApiResponse<CustomRoadAttributeScenario>> {
        if (requestParameters.customRoadAttributeScenario === null || requestParameters.customRoadAttributeScenario === undefined) {
            throw new runtime.RequiredError('customRoadAttributeScenario','Required parameter requestParameters.customRoadAttributeScenario was null or undefined when calling createCustomRoadAttributeScenario.');
        }

        const queryParameters: any = {};

        if (requestParameters.results) {
            queryParameters['results'] = requestParameters.results;
        }

        if (requestParameters.polylineFormat !== undefined) {
            queryParameters['polylineFormat'] = requestParameters.polylineFormat;
        }

        const headerParameters: runtime.HTTPHeaders = {};
		headerParameters['User-Agent'] = "ptv-generated typescript client";

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["apiKey"] = this.configuration.apiKey("apiKey"); // apiKeyAuth authentication
        }

        const response = await this.request({
            path: `/road-attributes`,
            method: 'POST',
            headers: headerParameters,
            query: queryParameters,
            body: CustomRoadAttributeScenarioToJSON(requestParameters.customRoadAttributeScenario),
        }, initOverrides);

        return new runtime.JSONApiResponse(response, (jsonValue) => CustomRoadAttributeScenarioFromJSON(jsonValue));
    }

    /**
     * Create a custom road attribute scenario.  This method is in an experimental state and may change at any time.
     */
    async createCustomRoadAttributeScenario(requestParameters: CreateCustomRoadAttributeScenarioRequest, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<CustomRoadAttributeScenario> {
        const response = await this.createCustomRoadAttributeScenarioRaw(requestParameters, initOverrides);
        return await response.value();
    }

    /**
     * Delete a custom road attribute scenario.  This method is in an experimental state and may change at any time.
     */
    async deleteCustomRoadAttributeScenarioRaw(requestParameters: DeleteCustomRoadAttributeScenarioRequest, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<runtime.ApiResponse<void>> {
        if (requestParameters.scenarioId === null || requestParameters.scenarioId === undefined) {
            throw new runtime.RequiredError('scenarioId','Required parameter requestParameters.scenarioId was null or undefined when calling deleteCustomRoadAttributeScenario.');
        }

        const queryParameters: any = {};

        const headerParameters: runtime.HTTPHeaders = {};
		headerParameters['User-Agent'] = "ptv-generated typescript client";

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["apiKey"] = this.configuration.apiKey("apiKey"); // apiKeyAuth authentication
        }

        const response = await this.request({
            path: `/road-attributes/{scenarioId}`.replace(`{${"scenarioId"}}`, encodeURIComponent(String(requestParameters.scenarioId))),
            method: 'DELETE',
            headers: headerParameters,
            query: queryParameters,
        }, initOverrides);

        return new runtime.VoidApiResponse(response);
    }

    /**
     * Delete a custom road attribute scenario.  This method is in an experimental state and may change at any time.
     */
    async deleteCustomRoadAttributeScenario(requestParameters: DeleteCustomRoadAttributeScenarioRequest, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<void> {
        await this.deleteCustomRoadAttributeScenarioRaw(requestParameters, initOverrides);
    }

    /**
     * Get a list of all custom road attribute scenarios of the current user.  This method is in an experimental state and may change at any time.
     */
    async getAllCustomRoadAttributeScenariosRaw(requestParameters: GetAllCustomRoadAttributeScenariosRequest, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<runtime.ApiResponse<CustomRoadAttributeScenarioList>> {
        const queryParameters: any = {};

        if (requestParameters.results) {
            queryParameters['results'] = requestParameters.results;
        }

        if (requestParameters.polylineFormat !== undefined) {
            queryParameters['polylineFormat'] = requestParameters.polylineFormat;
        }

        const headerParameters: runtime.HTTPHeaders = {};
		headerParameters['User-Agent'] = "ptv-generated typescript client";

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["apiKey"] = this.configuration.apiKey("apiKey"); // apiKeyAuth authentication
        }

        const response = await this.request({
            path: `/road-attributes`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        }, initOverrides);

        return new runtime.JSONApiResponse(response, (jsonValue) => CustomRoadAttributeScenarioListFromJSON(jsonValue));
    }

    /**
     * Get a list of all custom road attribute scenarios of the current user.  This method is in an experimental state and may change at any time.
     */
    async getAllCustomRoadAttributeScenarios(requestParameters: GetAllCustomRoadAttributeScenariosRequest = {}, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<CustomRoadAttributeScenarioList> {
        const response = await this.getAllCustomRoadAttributeScenariosRaw(requestParameters, initOverrides);
        return await response.value();
    }

    /**
     * Get a custom road attribute scenario by its ID.  This method is in an experimental state and may change at any time.
     */
    async getCustomRoadAttributeScenarioRaw(requestParameters: GetCustomRoadAttributeScenarioRequest, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<runtime.ApiResponse<CustomRoadAttributeScenario>> {
        if (requestParameters.scenarioId === null || requestParameters.scenarioId === undefined) {
            throw new runtime.RequiredError('scenarioId','Required parameter requestParameters.scenarioId was null or undefined when calling getCustomRoadAttributeScenario.');
        }

        const queryParameters: any = {};

        if (requestParameters.results) {
            queryParameters['results'] = requestParameters.results;
        }

        if (requestParameters.polylineFormat !== undefined) {
            queryParameters['polylineFormat'] = requestParameters.polylineFormat;
        }

        const headerParameters: runtime.HTTPHeaders = {};
		headerParameters['User-Agent'] = "ptv-generated typescript client";

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["apiKey"] = this.configuration.apiKey("apiKey"); // apiKeyAuth authentication
        }

        const response = await this.request({
            path: `/road-attributes/{scenarioId}`.replace(`{${"scenarioId"}}`, encodeURIComponent(String(requestParameters.scenarioId))),
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        }, initOverrides);

        return new runtime.JSONApiResponse(response, (jsonValue) => CustomRoadAttributeScenarioFromJSON(jsonValue));
    }

    /**
     * Get a custom road attribute scenario by its ID.  This method is in an experimental state and may change at any time.
     */
    async getCustomRoadAttributeScenario(requestParameters: GetCustomRoadAttributeScenarioRequest, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<CustomRoadAttributeScenario> {
        const response = await this.getCustomRoadAttributeScenarioRaw(requestParameters, initOverrides);
        return await response.value();
    }

    /**
     * Get roads from (click) points on a map.  This method is in an experimental state and may change at any time.
     */
    async getRoadsRaw(requestParameters: GetRoadsRequest, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<runtime.ApiResponse<RoadsResponse>> {
        if (requestParameters.points === null || requestParameters.points === undefined) {
            throw new runtime.RequiredError('points','Required parameter requestParameters.points was null or undefined when calling getRoads.');
        }

        const queryParameters: any = {};

        if (requestParameters.polylineFormat !== undefined) {
            queryParameters['polylineFormat'] = requestParameters.polylineFormat;
        }

        if (requestParameters.points !== undefined) {
            queryParameters['points'] = requestParameters.points;
        }

        const headerParameters: runtime.HTTPHeaders = {};
		headerParameters['User-Agent'] = "ptv-generated typescript client";

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["apiKey"] = this.configuration.apiKey("apiKey"); // apiKeyAuth authentication
        }

        const response = await this.request({
            path: `/roads`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        }, initOverrides);

        return new runtime.JSONApiResponse(response, (jsonValue) => RoadsResponseFromJSON(jsonValue));
    }

    /**
     * Get roads from (click) points on a map.  This method is in an experimental state and may change at any time.
     */
    async getRoads(requestParameters: GetRoadsRequest, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<RoadsResponse> {
        const response = await this.getRoadsRaw(requestParameters, initOverrides);
        return await response.value();
    }

    /**
     * Perform a full update of an existing custom road attribute scenario.  This method is in an experimental state and may change at any time.
     */
    async updateCustomRoadAttributeScenarioRaw(requestParameters: UpdateCustomRoadAttributeScenarioRequest, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<runtime.ApiResponse<CustomRoadAttributeScenario>> {
        if (requestParameters.scenarioId === null || requestParameters.scenarioId === undefined) {
            throw new runtime.RequiredError('scenarioId','Required parameter requestParameters.scenarioId was null or undefined when calling updateCustomRoadAttributeScenario.');
        }

        if (requestParameters.customRoadAttributeScenario === null || requestParameters.customRoadAttributeScenario === undefined) {
            throw new runtime.RequiredError('customRoadAttributeScenario','Required parameter requestParameters.customRoadAttributeScenario was null or undefined when calling updateCustomRoadAttributeScenario.');
        }

        const queryParameters: any = {};

        if (requestParameters.results) {
            queryParameters['results'] = requestParameters.results;
        }

        if (requestParameters.polylineFormat !== undefined) {
            queryParameters['polylineFormat'] = requestParameters.polylineFormat;
        }

        const headerParameters: runtime.HTTPHeaders = {};
		headerParameters['User-Agent'] = "ptv-generated typescript client";

        headerParameters['Content-Type'] = 'application/json';

        if (this.configuration && this.configuration.apiKey) {
            headerParameters["apiKey"] = this.configuration.apiKey("apiKey"); // apiKeyAuth authentication
        }

        const response = await this.request({
            path: `/road-attributes/{scenarioId}`.replace(`{${"scenarioId"}}`, encodeURIComponent(String(requestParameters.scenarioId))),
            method: 'PUT',
            headers: headerParameters,
            query: queryParameters,
            body: CustomRoadAttributeScenarioToJSON(requestParameters.customRoadAttributeScenario),
        }, initOverrides);

        return new runtime.JSONApiResponse(response, (jsonValue) => CustomRoadAttributeScenarioFromJSON(jsonValue));
    }

    /**
     * Perform a full update of an existing custom road attribute scenario.  This method is in an experimental state and may change at any time.
     */
    async updateCustomRoadAttributeScenario(requestParameters: UpdateCustomRoadAttributeScenarioRequest, initOverrides?: RequestInit | runtime.InitOverrideFunction): Promise<CustomRoadAttributeScenario> {
        const response = await this.updateCustomRoadAttributeScenarioRaw(requestParameters, initOverrides);
        return await response.value();
    }

}
