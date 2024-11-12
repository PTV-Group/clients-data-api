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

import { mapValues } from '../runtime';
import type { LowEmissionZoneTypes } from './LowEmissionZoneTypes';
import {
    LowEmissionZoneTypesFromJSON,
    LowEmissionZoneTypesFromJSONTyped,
    LowEmissionZoneTypesToJSON,
} from './LowEmissionZoneTypes';
import type { HazardousMaterials } from './HazardousMaterials';
import {
    HazardousMaterialsFromJSON,
    HazardousMaterialsFromJSONTyped,
    HazardousMaterialsToJSON,
} from './HazardousMaterials';
import type { EmissionStandard } from './EmissionStandard';
import {
    EmissionStandardFromJSON,
    EmissionStandardFromJSONTyped,
    EmissionStandardToJSON,
} from './EmissionStandard';
import type { EtcSubscriptionTypes } from './EtcSubscriptionTypes';
import {
    EtcSubscriptionTypesFromJSON,
    EtcSubscriptionTypesFromJSONTyped,
    EtcSubscriptionTypesToJSON,
} from './EtcSubscriptionTypes';
import type { ParticleReductionClass } from './ParticleReductionClass';
import {
    ParticleReductionClassFromJSON,
    ParticleReductionClassFromJSONTyped,
    ParticleReductionClassToJSON,
} from './ParticleReductionClass';
import type { EngineType } from './EngineType';
import {
    EngineTypeFromJSON,
    EngineTypeFromJSONTyped,
    EngineTypeToJSON,
} from './EngineType';
import type { TunnelRestrictionCode } from './TunnelRestrictionCode';
import {
    TunnelRestrictionCodeFromJSON,
    TunnelRestrictionCodeFromJSONTyped,
    TunnelRestrictionCodeToJSON,
} from './TunnelRestrictionCode';
import type { TruckRoutes } from './TruckRoutes';
import {
    TruckRoutesFromJSON,
    TruckRoutesFromJSONTyped,
    TruckRoutesToJSON,
} from './TruckRoutes';
import type { ElectricityType } from './ElectricityType';
import {
    ElectricityTypeFromJSON,
    ElectricityTypeFromJSONTyped,
    ElectricityTypeToJSON,
} from './ElectricityType';
import type { FuelType } from './FuelType';
import {
    FuelTypeFromJSON,
    FuelTypeFromJSONTyped,
    FuelTypeToJSON,
} from './FuelType';

/**
 * Physical and legal properties of the vehicle such as its dimensions.
 * 
 * These parameters are not supported for non-motorized profiles such as _BICYCLE_ or _PEDESTRIAN_.
 * Unsupported parameters such as **electricityType** for combustion vehicles will not be present in the response.
 * @export
 * @interface Vehicle
 */
export interface Vehicle {
    /**
     * 
     * @type {EngineType}
     * @memberof Vehicle
     */
    engineType?: EngineType;
    /**
     * 
     * @type {FuelType}
     * @memberof Vehicle
     */
    fuelType?: FuelType;
    /**
     * 
     * @type {ElectricityType}
     * @memberof Vehicle
     */
    electricityType?: ElectricityType;
    /**
     * The average fuel consumption of the vehicle.
     * Depending on the **fuelType** [l/100km] for liquid fuel types or [kg/100km] for gaseous fuel types.
     * 
     * Supported for **engineType** _COMBUSTION_  or _HYBRID_. Relevant for `emissions`.
     * 
     * @type {number}
     * @memberof Vehicle
     */
    averageFuelConsumption?: number;
    /**
     * The average power consumption of the vehicle [kWh/100km].
     * 
     * Supported for **engineType** _ELECTRIC_ or _HYBRID_. Relevant for `emissions`.
     * 
     * @type {number}
     * @memberof Vehicle
     */
    averageElectricityConsumption?: number;
    /**
     * The ratio of biofuel to conventional fuel [%], i.e. 10 for E10 with 10% biofuel.
     * 
     * Supported for **engineType** _COMBUSTION_ or _HYBRID_ and only for the fuel types _GASOLINE_, _DIESEL_, _CNG_GASOLINE_ and _LNG_GASOLINE_.
     * Relevant for `emissions`.
     * 
     * @type {number}
     * @memberof Vehicle
     */
    bioFuelRatio?: number;
    /**
     * Electric energy usage ratio from the total amount of energy consumed by the vehicle.
     * 
     * Supported for **engineType** _HYBRID_. Relevant for `emissions`.
     * 
     * @type {number}
     * @memberof Vehicle
     */
    hybridRatio?: number;
    /**
     * Ratio of CNG or LPG usage from the total amount of fuel consumption.
     * 
     * Supported for **engineType** _COMBUSTION_ with **fuelType**  _CNG_GASOLINE_ or _LPG_GASOLINE_. Relevant for `emissions`.
     * 
     * @type {number}
     * @memberof Vehicle
     */
    dualFuelRatio?: number;
    /**
     * The cylinder capacity of the vehicle [cm&#x00B3;].
     * 
     * Supported for **engineType** _COMBUSTION_ or _HYBRID_.
     * 
     * @type {number}
     * @memberof Vehicle
     */
    cylinderCapacity?: number;
    /**
     * 
     * @type {EmissionStandard}
     * @memberof Vehicle
     */
    emissionStandard?: EmissionStandard;
    /**
     * The CO&#8322; emission class valid in the European Union. See also the 
     * [Directive 1999/62/EC](https://eur-lex.europa.eu/eli/dir/1999/62/2022-03-24) of the European Parliament and 
     * of the Council on the charging of heavy goods vehicles for the use of certain infrastructures, Article 7ga.
     * 
     * Relevant for `toll`.
     * 
     * @type {number}
     * @memberof Vehicle
     */
    co2EmissionClass?: number;
    /**
     * Comma-separated list of the low-emission zone types of the vehicle.
     * This parameter is deprecated and superseded by **lowEmissionZoneApprovals**.
     * 
     * Relevant for `routing`.
     * 
     * @type {Array<LowEmissionZoneTypes>}
     * @memberof Vehicle
     * @deprecated
     */
    lowEmissionZoneTypes?: Array<LowEmissionZoneTypes>;
    /**
     * Comma-separated list of approvals to enter low-emission zones.
     * Usually, such approvals are environmental badges to be placed on the windscreen,
     * but that can also be any other kind of approval or vehicle registration
     * allowing it to enter a low-emission zone.
     * 
     * Low-emission zones which do not need any kind of approval but depend only on the **emissionStandard**
     * are not affected by this parameter. Instead they can be entered if the **emissionStandard** 
     * is sufficient. Electric vehicles can always enter these zones.
     * 
     * Available values are: 
     * "NONE", "AT_EURO_1", "AT_EURO_2", "AT_EURO_3", "AT_EURO_4", "AT_EURO_5", "AT_EURO_6",
     * "DE_GREEN", "DE_YELLOW", "DE_RED", "DK_AUTHORIZED", "ES_CAT_B", "ES_CAT_C", "ES_CAT_ECO", "ES_CAT_ZERO",
     * "FR_CRITAIR_0", "FR_CRITAIR_1", "FR_CRITAIR_2", "FR_CRITAIR_3", "FR_CRITAIR_4", "FR_CRITAIR_5"
     * 
     * This list can be extended at any time, clients should handle unknown values properly. Relevant for `routing`.
     * 
     * @type {Array<string>}
     * @memberof Vehicle
     */
    lowEmissionZoneApprovals?: Array<string>;
    /**
     * 
     * @type {ParticleReductionClass}
     * @memberof Vehicle
     */
    particleReductionClass?: ParticleReductionClass;
    /**
     * The empty weight of the vehicle [kg].
     * 
     * Relevant for `routing`, `emissions`.
     * 
     * @type {number}
     * @memberof Vehicle
     */
    emptyWeight?: number;
    /**
     * The weight of the vehicle's load [kg].
     * 
     * Relevant for `routing`, `emissions`.
     * 
     * @type {number}
     * @memberof Vehicle
     */
    loadWeight?: number;
    /**
     * The total permitted weight of the vehicle and load [kg].
     * 
     * Relevant for `routing`, `toll`, `emissions`.
     * 
     * @type {number}
     * @memberof Vehicle
     */
    totalPermittedWeight?: number;
    /**
     * The total technically permitted weight of the vehicle and load [kg].
     * Sometimes vehicles are registered with a smaller permitted weight than technically possible. For 
     * such cases the possibly larger total technically permitted weight is specified here, it is relevant for 
     * toll calculation in some European countries.
     * 
     * Relevant for `toll`.
     * 
     * @type {number}
     * @memberof Vehicle
     */
    totalTechnicallyPermittedWeight?: number;
    /**
     * The maximum distributed weight that may be supported by an axle of the vehicle [kg].
     * 
     * Relevant for `routing`, `toll`.
     * 
     * @type {number}
     * @memberof Vehicle
     */
    axleWeight?: number;
    /**
     * The total number of axles of the vehicle including the trailers.
     * 
     * Relevant for `toll`.
     * 
     * @type {number}
     * @memberof Vehicle
     */
    numberOfAxles?: number;
    /**
     * The total number of tires of the vehicle including the trailers.
     * 
     * Relevant for `toll`.
     * 
     * @type {number}
     * @memberof Vehicle
     */
    numberOfTires?: number;
    /**
     * The height of the vehicle [cm].
     * 
     * Relevant for `routing`, `toll`.
     * 
     * @type {number}
     * @memberof Vehicle
     */
    height?: number;
    /**
     * The height above the front axle [cm].
     * 
     * Relevant for `toll`.
     * 
     * @type {number}
     * @memberof Vehicle
     */
    heightAboveFrontAxle?: number;
    /**
     * The length of the vehicle [cm].
     * 
     * Relevant for `routing`, `toll`.
     * 
     * @type {number}
     * @memberof Vehicle
     */
    length?: number;
    /**
     * The width of the vehicle [cm].
     * 
     * Relevant for `routing`, `toll`.
     * 
     * @type {number}
     * @memberof Vehicle
     */
    width?: number;
    /**
     * Comma-separated list of hazardous materials the vehicle has loaded.
     * 
     * Relevant for `routing`.
     * 
     * @type {Array<HazardousMaterials>}
     * @memberof Vehicle
     */
    hazardousMaterials?: Array<HazardousMaterials>;
    /**
     * 
     * @type {TunnelRestrictionCode}
     * @memberof Vehicle
     */
    tunnelRestrictionCode?: TunnelRestrictionCode;
    /**
     * Comma-separated list of truck routes the vehicle has to follow.
     * This parameter will be ignored for non-truck profiles such as EUR_CAR, EUR_VAN, USA_1_PICKUP or AUS_LCV_LIGHT_COMMERCIAL.
     *  * `DE_LKWUEBERLSTVAUSNV`
     *  Preferred routes for long trucks in Germany, also known as Lang-LKW.
     *  * `NL_LZV`
     *  Preferred routes for long trucks in the Netherlands, also known as LZV (Langere en Zwaardere Vrachtautocombinatie).
     *  * `NZ_HPMV`
     *  The network for High Productivity Motor Vehicles (HPMV) carrying the maximum loads available under a permit (New Zeland Transport Agency).
     *  * `SE_BK_1`
     *  Public roads and bridges that support up to 64 t total permitted weight (Swedish Transport Administration).
     *  * `SE_BK_2`
     *  Public roads and bridges that support up to 51.4 t total permitted weight.
     *  Actual limit depends on wheelbase and axle weight (Swedish Transport Administration).
     *  * `SE_BK_3`
     *  Public roads and bridges that support up to 37.5 t total permitted weight.
     *  Actual limit depends on wheelbase and axle weight (Swedish Transport Administration).
     *  * `SE_BK_4`
     *  Public roads and bridges that support up to 74 t total permitted weight (draft summer 2018, Swedish Transport Administration).
     *  * `US_STAA`
     *  Routes that belong to the highway network as defined by the Surface Transportation Assistance Act in the US.
     *  * `US_TD`
     *  Part of a state-designated highway network for trucks in the US.
     *  * `AU_B_DOUBLE`
     *  B-Double routes as defined in Australia.
     *  * `AU_B_DOUBLE_HML`
     *  Routes for B-Double vehicle combinations operating at Higher Mass Limits (HML) (Australian Transport Administration).
     *  * `AU_B_TRIPLE`
     *  B-Triple routes as defined in Australia.
     *  * `AU_B_TRIPLE_HML`
     *  Routes for B-Triple vehicle combinations operating at Higher Mass Limits (HML) (Australian Transport Administration).
     *  * `AU_AB_TRIPLE`
     *  Routes for AB-Triple vehicle combinations operating (Australian Transport Administration).
     *  * `AU_AB_TRIPLE_HML`
     *  Routes for AB-Triple vehicle combinations operating at Higher Mass Limits (HML) (Australian Transport Administration).
     *  * `NONE`
     *  Not used.
     * 
     * Relevant for `routing`.
     * Cannot be used with **options[routingMode]=MONETARY**.
     * 
     * @type {Array<TruckRoutes>}
     * @memberof Vehicle
     */
    truckRoutes?: Array<TruckRoutes>;
    /**
     * Specifies if the vehicle usage is commercial.
     * 
     * Relevant for `toll`.
     * 
     * @type {boolean}
     * @memberof Vehicle
     */
    commercial?: boolean;
    /**
     * A comma separated list of ETC Subscriptions.
     * See [here](../routing-api/concepts/electronic-toll-collection) for more information on available subscriptions.
     * 
     * Relevant for `toll`.
     * 
     * @type {Array<EtcSubscriptionTypes>}
     * @memberof Vehicle
     */
    etcSubscriptions?: Array<EtcSubscriptionTypes>;
}



/**
 * Check if a given object implements the Vehicle interface.
 */
export function instanceOfVehicle(value: object): value is Vehicle {
    return true;
}

export function VehicleFromJSON(json: any): Vehicle {
    return VehicleFromJSONTyped(json, false);
}

export function VehicleFromJSONTyped(json: any, ignoreDiscriminator: boolean): Vehicle {
    if (json == null) {
        return json;
    }
    return {
        
        'engineType': json['engineType'] == null ? undefined : EngineTypeFromJSON(json['engineType']),
        'fuelType': json['fuelType'] == null ? undefined : FuelTypeFromJSON(json['fuelType']),
        'electricityType': json['electricityType'] == null ? undefined : ElectricityTypeFromJSON(json['electricityType']),
        'averageFuelConsumption': json['averageFuelConsumption'] == null ? undefined : json['averageFuelConsumption'],
        'averageElectricityConsumption': json['averageElectricityConsumption'] == null ? undefined : json['averageElectricityConsumption'],
        'bioFuelRatio': json['bioFuelRatio'] == null ? undefined : json['bioFuelRatio'],
        'hybridRatio': json['hybridRatio'] == null ? undefined : json['hybridRatio'],
        'dualFuelRatio': json['dualFuelRatio'] == null ? undefined : json['dualFuelRatio'],
        'cylinderCapacity': json['cylinderCapacity'] == null ? undefined : json['cylinderCapacity'],
        'emissionStandard': json['emissionStandard'] == null ? undefined : EmissionStandardFromJSON(json['emissionStandard']),
        'co2EmissionClass': json['co2EmissionClass'] == null ? undefined : json['co2EmissionClass'],
        'lowEmissionZoneTypes': json['lowEmissionZoneTypes'] == null ? undefined : ((json['lowEmissionZoneTypes'] as Array<any>).map(LowEmissionZoneTypesFromJSON)),
        'lowEmissionZoneApprovals': json['lowEmissionZoneApprovals'] == null ? undefined : json['lowEmissionZoneApprovals'],
        'particleReductionClass': json['particleReductionClass'] == null ? undefined : ParticleReductionClassFromJSON(json['particleReductionClass']),
        'emptyWeight': json['emptyWeight'] == null ? undefined : json['emptyWeight'],
        'loadWeight': json['loadWeight'] == null ? undefined : json['loadWeight'],
        'totalPermittedWeight': json['totalPermittedWeight'] == null ? undefined : json['totalPermittedWeight'],
        'totalTechnicallyPermittedWeight': json['totalTechnicallyPermittedWeight'] == null ? undefined : json['totalTechnicallyPermittedWeight'],
        'axleWeight': json['axleWeight'] == null ? undefined : json['axleWeight'],
        'numberOfAxles': json['numberOfAxles'] == null ? undefined : json['numberOfAxles'],
        'numberOfTires': json['numberOfTires'] == null ? undefined : json['numberOfTires'],
        'height': json['height'] == null ? undefined : json['height'],
        'heightAboveFrontAxle': json['heightAboveFrontAxle'] == null ? undefined : json['heightAboveFrontAxle'],
        'length': json['length'] == null ? undefined : json['length'],
        'width': json['width'] == null ? undefined : json['width'],
        'hazardousMaterials': json['hazardousMaterials'] == null ? undefined : ((json['hazardousMaterials'] as Array<any>).map(HazardousMaterialsFromJSON)),
        'tunnelRestrictionCode': json['tunnelRestrictionCode'] == null ? undefined : TunnelRestrictionCodeFromJSON(json['tunnelRestrictionCode']),
        'truckRoutes': json['truckRoutes'] == null ? undefined : ((json['truckRoutes'] as Array<any>).map(TruckRoutesFromJSON)),
        'commercial': json['commercial'] == null ? undefined : json['commercial'],
        'etcSubscriptions': json['etcSubscriptions'] == null ? undefined : ((json['etcSubscriptions'] as Array<any>).map(EtcSubscriptionTypesFromJSON)),
    };
}

export function VehicleToJSON(value?: Vehicle | null): any {
    if (value == null) {
        return value;
    }
    return {
        
        'engineType': EngineTypeToJSON(value['engineType']),
        'fuelType': FuelTypeToJSON(value['fuelType']),
        'electricityType': ElectricityTypeToJSON(value['electricityType']),
        'averageFuelConsumption': value['averageFuelConsumption'],
        'averageElectricityConsumption': value['averageElectricityConsumption'],
        'bioFuelRatio': value['bioFuelRatio'],
        'hybridRatio': value['hybridRatio'],
        'dualFuelRatio': value['dualFuelRatio'],
        'cylinderCapacity': value['cylinderCapacity'],
        'emissionStandard': EmissionStandardToJSON(value['emissionStandard']),
        'co2EmissionClass': value['co2EmissionClass'],
        'lowEmissionZoneTypes': value['lowEmissionZoneTypes'] == null ? undefined : ((value['lowEmissionZoneTypes'] as Array<any>).map(LowEmissionZoneTypesToJSON)),
        'lowEmissionZoneApprovals': value['lowEmissionZoneApprovals'],
        'particleReductionClass': ParticleReductionClassToJSON(value['particleReductionClass']),
        'emptyWeight': value['emptyWeight'],
        'loadWeight': value['loadWeight'],
        'totalPermittedWeight': value['totalPermittedWeight'],
        'totalTechnicallyPermittedWeight': value['totalTechnicallyPermittedWeight'],
        'axleWeight': value['axleWeight'],
        'numberOfAxles': value['numberOfAxles'],
        'numberOfTires': value['numberOfTires'],
        'height': value['height'],
        'heightAboveFrontAxle': value['heightAboveFrontAxle'],
        'length': value['length'],
        'width': value['width'],
        'hazardousMaterials': value['hazardousMaterials'] == null ? undefined : ((value['hazardousMaterials'] as Array<any>).map(HazardousMaterialsToJSON)),
        'tunnelRestrictionCode': TunnelRestrictionCodeToJSON(value['tunnelRestrictionCode']),
        'truckRoutes': value['truckRoutes'] == null ? undefined : ((value['truckRoutes'] as Array<any>).map(TruckRoutesToJSON)),
        'commercial': value['commercial'],
        'etcSubscriptions': value['etcSubscriptions'] == null ? undefined : ((value['etcSubscriptions'] as Array<any>).map(EtcSubscriptionTypesToJSON)),
    };
}

