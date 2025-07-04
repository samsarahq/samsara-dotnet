using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Vehicles.Stats;

public record StatsHistoryRequest
{
    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    [JsonIgnore]
    public string? After { get; set; }

    /// <summary>
    /// A start time in RFC 3339 format. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    [JsonIgnore]
    public required string StartTime { get; set; }

    /// <summary>
    /// An end time in RFC 3339 format. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    [JsonIgnore]
    public required string EndTime { get; set; }

    /// <summary>
    /// A filter on the data based on this comma-separated list of parent tag IDs, for use by orgs with tag hierarchies. Specifying a parent tag will implicitly include all descendent tags of the parent tag. Example: `parentTagIds=345,678`
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> ParentTagIds { get; set; } = new List<string>();

    /// <summary>
    /// A filter on the data based on this comma-separated list of tag IDs. Example: `tagIds=1234,5678`
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> TagIds { get; set; } = new List<string>();

    /// <summary>
    /// A filter on the data based on this comma-separated list of vehicle IDs. Example: `vehicleIds=1234,5678`
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> VehicleIds { get; set; } = new List<string>();

    /// <summary>
    /// The stat types you want this endpoint to return information on. See also the &lt;a href="/docs/telematics#query-parameters" target="_blank"&gt;Telematics&lt;/a&gt; guide for more details.
    ///
    /// You may list ***up to 4*** types using comma-separated format. For example: `types=gps,engineStates,obdOdometerMeters`.
    ///
    /// *Note:* `auxInput3`-`auxInput10` count as a single type against the limit of 3. For example, you could list `types=engineStates,obdOdometerMeters,auxInput3,auxInput4` because `auxInput3` and `auxInput4` count as a single stat type. `auxInput1` and `auxInput2` still count as their own individual types.
    ///
    /// - `ambientAirTemperatureMilliC`: The ambient air temperature reading in millidegree Celsius.
    /// - `auxInput1`-`auxInput13`: Stat events from the &lt;a href="https://kb.samsara.com/hc/en-us/articles/360043040512-Auxiliary-Inputs" target="_blank"&gt;auxiliary inputs&lt;/a&gt; for the vehicle.
    /// - `barometricPressurePa`: The barometric pressure reading in pascals.
    /// - `batteryMilliVolts`: The vehicle battery voltage reading.
    /// - `defLevelMilliPercent`: The Diesel Exhaust Fluid (DEF) level in milli percentage points (e.g. `99001`, `49999`, etc).
    /// - `ecuSpeedMph`: The speed of the engine in miles per hour according to the ECU.
    /// - `engineCoolantTemperatureMilliC`: The engine coolant temperature reading in millidegree Celsius.
    /// - `engineImmobilizer`: The state of the engine immobilizer - Valid values: `ignition_disabled`, `ignition_enabled`. This stat type will only return states of our first Engine Immobilizer Hardware (ACC-EI). Please use &lt;a href="https://developers.samsara.com/reference/getengineimmobilizerstates" target="_blank"&gt;Get engine immobilizer states&lt;/a&gt; to get states for both Engine Immobilizer Hardware versions (incl. HW-EI21).
    /// - `engineLoadPercent`: The engine load in percentage points (e.g. `99`, `50`, etc).
    /// - `engineOilPressureKPa`: The engine oil pressure reading in kilopascals.
    /// - `engineRpm`: The revolutions per minute of the engine.
    /// - `engineStates`: The state of the engine (`Off`, `On`, `Idle`).
    /// - `faultCodes`: The diagnostic fault codes for the vehicle.
    /// - `fuelPercents`: The engine fuel level in percentage points (e.g. `99`, `50`, etc).
    /// - `gps`: GPS data including lat/long, heading, speed, address book entry (if exists), and a reverse geocoded address.
    /// - `gpsDistanceMeters`: The distance the vehicle has traveled since the gateway was installed based on GPS calculations.
    /// - `gpsOdometerMeters`: Odometer reading provided by GPS calculations when OBD odometer cannot be pulled automatically. You must provide a manual odometer reading before this value is updated. Manual odometer readings can be provided via the [PATCH /fleet/vehicles/{id}](ref:updatevehicle) endpoint or through the &lt;a href="https://kb.samsara.com/hc/en-us/articles/115005273667-Editing-Odometer-Reading" target="_blank"&gt;cloud dasbhoard&lt;/a&gt;. Odometer readings that are manually set will update as GPS trip data is gathered. Try combining with `obdOdometerMeters`.
    /// - `intakeManifoldTemperatureMilliC`: The intake manifold temperature reading in millidegree Celsius.
    /// - `nfcCardScans`: ID card scans.
    /// - `obdEngineSeconds`: The cumulative number of seconds the engine has run according to onboard diagnostics.
    /// - `obdOdometerMeters`: The odometer reading according to onboard diagnostics. If Samsara does not have diagnostic coverage for a particular vehicle, the value for this stat type will be omitted. Try combining with `gpsOdometerMeters`.
    /// - `syntheticEngineSeconds`: Data for the synthetic engine seconds for the vehicle.
    /// - `evStateOfChargeMilliPercent`: Milli percent State of Charge for electric and hybrid vehicles. Not all EV and HEVs may report this field.
    /// - `evChargingStatus`: Charging status for electric and hybrid vehicles. Not all EV and HEVs may report this field. Statuses:  unknown - 0, not charging - 1, charging - 2.
    /// - `evChargingEnergyMicroWh`: Charging energy for electric and hybrid vehicles in microwatt hours. Not all EV and HEVs may report this field.
    /// - `evChargingVoltageMilliVolt`: Charging voltage for electric and hybrid vehicles in milli volts. Not all EV and HEVs may report this field.
    /// - `evChargingCurrentMilliAmp`: Charging current for electric and hybrid vehicles in milli amps. Not all EV and HEVs may report this field.
    /// - `evConsumedEnergyMicroWh`: Consumed energy (including regenerated) for electric and hybrid vehicles in microwatt hours. Not all EV and HEVs may report this field.
    /// - `evRegeneratedEnergyMicroWh`: Regenerated energy for electric and hybrid vehicles in microwatt hours. Not all EV and HEVs may report this field.
    /// - `evBatteryVoltageMilliVolt`: Battery voltage for electric and hybrid vehicles in milli volts. Not all EV and HEVs may report this field.
    /// - `evBatteryCurrentMilliAmp`: Battery current for electric and hybrid vehicles in milli amps. Not all EV and HEVs may report this field.
    /// - `evBatteryStateOfHealthMilliPercent`: Milli percent battery state of health for electric and hybrid vehicles. Not all EV and HEVs may report this field.
    /// - `evAverageBatteryTemperatureMilliCelsius`: Battery temperature for electric and hybrid vehicles in milli celsius. Not all EV and HEVs may report this field.
    /// - `evDistanceDrivenMeters`: Electric distance driven for electric and hybrid vehicles in meters. Not all EV and HEVs may report this field.
    /// - `spreaderLiquidRate`: Liquid spread rate reading in milliliters per meter, read from the material spreader. Unfiltered live stats are supplied as-read from the Material Spreader unit. Readings do not consider total spread rate(s) over time or distance.
    /// - `spreaderGranularRate`: Granular spread rate reading in milliliters per meter, read from the material spreader. Unfiltered live stats are supplied as-read from the Material Spreader unit. Readings do not consider total spread rate(s) over time or distance.
    /// - `spreaderPrewetRate`: Prewet spread rate reading in milliliters per meter, read from the material spreader. Unfiltered live stats are supplied as-read from the Material Spreader unit. Readings do not consider total spread rate(s) over time or distance.
    /// - `spreaderAirTemp`: Air (ambient) temperature in milli celsius reading from material spreader.
    /// - `spreaderRoadTemp`: Road temperature reading in milli celsius from material spreader.
    /// - `spreaderOnState`: Whether vehicle spreader is enabled.
    /// - `spreaderActive`: Whether vehicle is actively spreading any material.
    /// - `spreaderBlastState`: Whether vehicle is actively spreading material in ‘blast mode’.
    /// - `spreaderGranularName`: Name of most recent type of granular material spread, read from the material spreader.
    /// - `spreaderPrewetName`: Name of most recent type of prewet material spread, read from the material spreader.
    /// - `spreaderLiquidName`: Name of most recent type of liquid material spread, read from the material spreader.
    /// - `spreaderPlowStatus`: Snow plow status (`Up` or `Down`), as read from the material spreader. Note: this is separate from plow status defined via auxInput.
    /// - `seatbeltDriver`: Seatbelt Driver Status as read from the vehicle. `Buckled` or `Unbuckled`. (Beta only)
    /// </summary>
    [JsonIgnore]
    public IEnumerable<StatsHistoryRequestTypesItem> Types { get; set; } =
        new List<StatsHistoryRequestTypesItem>();

    /// <summary>
    /// Decorations to add to the primary stats listed in the `types` parameter. For example, if you wish to know the vehicle's location whenever the engine changes state, you may set `types=engineStates&decorations=gps`.
    ///
    /// You may list ***up to 2*** decorations using comma-separated format. If multiple stats are listed in the `types` parameter, the decorations will be added to each one. For example: `types=engineStates,obdOdometerMeters,faultCodes&decorations=gps,fuelPercents` will list GPS and fuel decorations for each engine state change, each odometer reading, and each fault code. See the &lt;a href="/docs/telematics#query-parameters" target="_blank"&gt;Telematics&lt;/a&gt; guide for more details.
    ///
    /// Note that decorations may significantly increase the response payload size.
    ///
    /// - `ambientAirTemperatureMilliC`: The ambient air temperature reading in millidegree Celsius.
    /// - `auxInput1`-`auxInput13`: Stat events from the &lt;a href="https://kb.samsara.com/hc/en-us/articles/360043040512-Auxiliary-Inputs" target="_blank"&gt;auxiliary inputs&lt;/a&gt; for the vehicle.
    /// - `batteryMilliVolts`: The vehicle battery voltage reading.
    /// - `barometricPressurePa`: The barometric pressure reading in pascals.
    /// - `ecuSpeedMph`: The speed of the engine in miles per hour according to the ECU.
    /// - `engineCoolantTemperatureMilliC`: The engine coolant temperature reading in millidegree Celsius.
    /// - `engineImmobilizer`: The state of the engine immobilizer - Valid values: `ignition_disabled`, `ignition_enabled`. This stat type will only return states of our first Engine Immobilizer Hardware (ACC-EI). Please use &lt;a href="https://developers.samsara.com/reference/getengineimmobilizerstates" target="_blank"&gt;Get engine immobilizer states&lt;/a&gt; to get states for both Engine Immobilizer Hardware versions (incl. HW-EI21).
    /// - `engineOilPressureKPa`: The engine oil pressure reading in kilopascals.
    /// - `engineLoadPercent`: The engine load in percentage points (e.g. `99`, `50`, etc).
    /// - `engineRpm`: The revolutions per minute of the engine.
    /// - `engineStates`: The state of the engine (`Off`, `On`, `Idle`).
    /// - `faultCodes`: The diagnostic fault codes for the vehicle.
    /// - `fuelPercents`: The engine fuel level in percentage points (e.g. `99`, `50`, etc).
    /// - `gps`: GPS data including lat/long, heading, speed, address book entry (if exists), and a reverse geocoded address.
    /// - `gpsDistanceMeters`: The distance the vehicle has traveled since the gateway was installed based on GPS calculations.
    /// - `intakeManifoldTemperatureMilliC`: The intake manifold temperature reading in millidegree Celsius.
    /// - `nfcCardScans`: ID card scans.
    /// - `obdEngineSeconds`: The cumulative number of seconds the engine has run according to onboard diagnostics.
    /// - `obdOdometerMeters`: The odometer reading according to onboard diagnostics. If Samsara does not have diagnostic coverage for a particular vehicle, the value for this stat type will be omitted.
    /// - `syntheticEngineSeconds`: Data for the synthetic engine seconds for the vehicle.
    /// - `evStateOfChargeMilliPercent`: Milli percent State of Charge for electric and hybrid vehicles. Not all EV and HEVs may report this field.
    /// - `evChargingStatus`: Charging status for electric and hybrid vehicles. Not all EV and HEVs may report this field. Statuses:  unknown - 0, not charging - 1, charging - 2.
    /// - `evChargingEnergyMicroWh`: Charging energy for electric and hybrid vehicles in microwatt hours. Not all EV and HEVs may report this field.
    /// - `evChargingVoltageMilliVolt`: Charging voltage for electric and hybrid vehicles in milli  volts. Not all EV and HEVs may report this field.
    /// - `evChargingCurrentMilliAmp`: Charging current for electric and hybrid vehicles in milli amps. Not all EV and HEVs may report this field.
    /// - `evConsumedEnergyMicroWh`: Consumed energy (including regenerated) for electric and hybrid vehicles in microwatt hours. Not all EV and HEVs may report this field.
    /// - `evRegeneratedEnergyMicroWh`: Regenerated energy for electric and hybrid vehicles in microwatt hours. Not all EV and HEVs may report this field.
    /// - `evBatteryVoltageMilliVolt`: Battery voltage for electric and hybrid vehicles in milli volts. Not all EV and HEVs may report this field.
    /// - `evBatteryCurrentMilliAmp`: Battery current for electric and hybrid vehicles in milli amps. Not all EV and HEVs may report this field.
    /// - `evBatteryStateOfHealthMilliPercent`: Milli percent battery state of health for electric and hybrid vehicles. Not all EV and HEVs may report this field.
    /// - `evAverageBatteryTemperatureMilliCelsius`: Battery temperature for electric and hybrid vehicles in milli celsius. Not all EV and HEVs may report this field.
    /// - `evDistanceDrivenMeters`: Electric distance driven for electric and hybrid vehicles in meters. Not all EV and HEVs may report this field.
    /// - `spreaderLiquidRate`: Liquid spread rate reading in milliliters per meter, read from the material spreader. Unfiltered live stats are supplied as-read from the Material Spreader unit. Readings do not consider total spread rate(s) over time or distance.
    /// - `spreaderGranularRate`: Granular spread rate reading in milliliters per meter, read from the material spreader. Unfiltered live stats are supplied as-read from the Material Spreader unit. Readings do not consider total spread rate(s) over time or distance.
    /// - `spreaderPrewetRate`: Prewet spread rate reading in milliliters per meter, read from the material spreader. Unfiltered live stats are supplied as-read from the Material Spreader unit. Readings do not consider total spread rate(s) over time or distance.
    /// - `spreaderAirTemp`: Air (ambient) temperature in milli celsius reading from material spreader.
    /// - `spreaderRoadTemp`: Road temperature reading in milli celsius from material spreader.
    /// - `spreaderOnState`: Whether vehicle spreader is enabled.
    /// - `spreaderActive`: Whether vehicle is actively spreading any material.
    /// - `spreaderBlastState`: Whether vehicle is actively spreading material in ‘blast mode’.
    /// - `spreaderGranularName`: Name of most recent type of granular material spread, read from the material spreader.
    /// - `spreaderPrewetName`: Name of most recent type of prewet material spread, read from the material spreader.
    /// - `spreaderLiquidName`: Name of most recent type of liquid material spread, read from the material spreader.
    /// - `spreaderPlowStatus`: Snow plow status (`Up` or `Down`), as read from the material spreader. Note: this is separate from plow status defined via auxInput.
    /// - `seatbeltDriver`: Seatbelt Driver Status as read from the vehicle. `Buckled` or `Unbuckled`. (Beta only)
    /// </summary>
    [JsonIgnore]
    public IEnumerable<StatsHistoryRequestDecorationsItem> Decorations { get; set; } =
        new List<StatsHistoryRequestDecorationsItem>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
