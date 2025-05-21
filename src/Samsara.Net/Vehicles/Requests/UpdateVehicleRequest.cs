using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.Vehicles;

public record UpdateVehicleRequest
{
    [JsonPropertyName("attributes")]
    public IEnumerable<AttributeTiny>? Attributes { get; set; }

    /// <summary>
    /// The type of &lt;a href="https://kb.samsara.com/hc/en-us/articles/360043040512-Auxiliary-Inputs" target="_blank"&gt;auxiliary input&lt;/a&gt; configured for this Vehicle. Once configured, these inputs will generate dynamic, time-series data that will be available to view in the Samsara Dashboard. **By default**: empty. This can be set or updated through the Samsara Dashboard or the API at any time. Inputs 3-13 are only available on gateways with an attached aux expander. Valid values: `None`, `Emergency Lights`, `Emergency Alarm`, `Stop Paddle`, `Power Take-Off`, `Plow`, `Sweeper`, `Salter`, `Reefer`, `Door`, `Boom`, `Auxiliary Engine`, `Generator`, `Eight-Way Lights`, `Panic Button`, `Privacy Button`, `Front Axle Drive`, `Weight Sensor`, `Other`, `Secondary Fuel Source`, `(ECU) Power Take-Off`.
    /// </summary>
    [JsonPropertyName("auxInputType1")]
    public UpdateVehicleRequestAuxInputType1? AuxInputType1 { get; set; }

    /// <summary>
    /// The type of &lt;a href="https://kb.samsara.com/hc/en-us/articles/360043040512-Auxiliary-Inputs" target="_blank"&gt;auxiliary input&lt;/a&gt; configured for this Vehicle. Once configured, these inputs will generate dynamic, time-series data that will be available to view in the Samsara Dashboard. **By default**: empty. This can be set or updated through the Samsara Dashboard or the API at any time. Inputs 3-13 are only available on gateways with an attached aux expander. Valid values: `None`, `Emergency Lights`, `Emergency Alarm`, `Stop Paddle`, `Power Take-Off`, `Plow`, `Sweeper`, `Salter`, `Reefer`, `Door`, `Boom`, `Auxiliary Engine`, `Generator`, `Eight-Way Lights`, `Panic Button`, `Privacy Button`, `Front Axle Drive`, `Weight Sensor`, `Other`, `Secondary Fuel Source`, `(ECU) Power Take-Off`.
    /// </summary>
    [JsonPropertyName("auxInputType10")]
    public UpdateVehicleRequestAuxInputType10? AuxInputType10 { get; set; }

    /// <summary>
    /// The type of &lt;a href="https://kb.samsara.com/hc/en-us/articles/360043040512-Auxiliary-Inputs" target="_blank"&gt;auxiliary input&lt;/a&gt; configured for this Vehicle. Once configured, these inputs will generate dynamic, time-series data that will be available to view in the Samsara Dashboard. **By default**: empty. This can be set or updated through the Samsara Dashboard or the API at any time. Inputs 3-13 are only available on gateways with an attached aux expander. Valid values: `None`, `Emergency Lights`, `Emergency Alarm`, `Stop Paddle`, `Power Take-Off`, `Plow`, `Sweeper`, `Salter`, `Reefer`, `Door`, `Boom`, `Auxiliary Engine`, `Generator`, `Eight-Way Lights`, `Panic Button`, `Privacy Button`, `Front Axle Drive`, `Weight Sensor`, `Other`, `Secondary Fuel Source`, `(ECU) Power Take-Off`.
    /// </summary>
    [JsonPropertyName("auxInputType11")]
    public UpdateVehicleRequestAuxInputType11? AuxInputType11 { get; set; }

    /// <summary>
    /// The type of &lt;a href="https://kb.samsara.com/hc/en-us/articles/360043040512-Auxiliary-Inputs" target="_blank"&gt;auxiliary input&lt;/a&gt; configured for this Vehicle. Once configured, these inputs will generate dynamic, time-series data that will be available to view in the Samsara Dashboard. **By default**: empty. This can be set or updated through the Samsara Dashboard or the API at any time. Inputs 3-13 are only available on gateways with an attached aux expander. Valid values: `None`, `Emergency Lights`, `Emergency Alarm`, `Stop Paddle`, `Power Take-Off`, `Plow`, `Sweeper`, `Salter`, `Reefer`, `Door`, `Boom`, `Auxiliary Engine`, `Generator`, `Eight-Way Lights`, `Panic Button`, `Privacy Button`, `Front Axle Drive`, `Weight Sensor`, `Other`, `Secondary Fuel Source`, `(ECU) Power Take-Off`.
    /// </summary>
    [JsonPropertyName("auxInputType12")]
    public UpdateVehicleRequestAuxInputType12? AuxInputType12 { get; set; }

    /// <summary>
    /// The type of &lt;a href="https://kb.samsara.com/hc/en-us/articles/360043040512-Auxiliary-Inputs" target="_blank"&gt;auxiliary input&lt;/a&gt; configured for this Vehicle. Once configured, these inputs will generate dynamic, time-series data that will be available to view in the Samsara Dashboard. **By default**: empty. This can be set or updated through the Samsara Dashboard or the API at any time. Inputs 3-13 are only available on gateways with an attached aux expander. Valid values: `None`, `Emergency Lights`, `Emergency Alarm`, `Stop Paddle`, `Power Take-Off`, `Plow`, `Sweeper`, `Salter`, `Reefer`, `Door`, `Boom`, `Auxiliary Engine`, `Generator`, `Eight-Way Lights`, `Panic Button`, `Privacy Button`, `Front Axle Drive`, `Weight Sensor`, `Other`, `Secondary Fuel Source`, `(ECU) Power Take-Off`.
    /// </summary>
    [JsonPropertyName("auxInputType13")]
    public UpdateVehicleRequestAuxInputType13? AuxInputType13 { get; set; }

    /// <summary>
    /// The type of &lt;a href="https://kb.samsara.com/hc/en-us/articles/360043040512-Auxiliary-Inputs" target="_blank"&gt;auxiliary input&lt;/a&gt; configured for this Vehicle. Once configured, these inputs will generate dynamic, time-series data that will be available to view in the Samsara Dashboard. **By default**: empty. This can be set or updated through the Samsara Dashboard or the API at any time. Inputs 3-13 are only available on gateways with an attached aux expander. Valid values: `None`, `Emergency Lights`, `Emergency Alarm`, `Stop Paddle`, `Power Take-Off`, `Plow`, `Sweeper`, `Salter`, `Reefer`, `Door`, `Boom`, `Auxiliary Engine`, `Generator`, `Eight-Way Lights`, `Panic Button`, `Privacy Button`, `Front Axle Drive`, `Weight Sensor`, `Other`, `Secondary Fuel Source`, `(ECU) Power Take-Off`.
    /// </summary>
    [JsonPropertyName("auxInputType2")]
    public UpdateVehicleRequestAuxInputType2? AuxInputType2 { get; set; }

    /// <summary>
    /// The type of &lt;a href="https://kb.samsara.com/hc/en-us/articles/360043040512-Auxiliary-Inputs" target="_blank"&gt;auxiliary input&lt;/a&gt; configured for this Vehicle. Once configured, these inputs will generate dynamic, time-series data that will be available to view in the Samsara Dashboard. **By default**: empty. This can be set or updated through the Samsara Dashboard or the API at any time. Inputs 3-13 are only available on gateways with an attached aux expander. Valid values: `None`, `Emergency Lights`, `Emergency Alarm`, `Stop Paddle`, `Power Take-Off`, `Plow`, `Sweeper`, `Salter`, `Reefer`, `Door`, `Boom`, `Auxiliary Engine`, `Generator`, `Eight-Way Lights`, `Panic Button`, `Privacy Button`, `Front Axle Drive`, `Weight Sensor`, `Other`, `Secondary Fuel Source`, `(ECU) Power Take-Off`.
    /// </summary>
    [JsonPropertyName("auxInputType3")]
    public UpdateVehicleRequestAuxInputType3? AuxInputType3 { get; set; }

    /// <summary>
    /// The type of &lt;a href="https://kb.samsara.com/hc/en-us/articles/360043040512-Auxiliary-Inputs" target="_blank"&gt;auxiliary input&lt;/a&gt; configured for this Vehicle. Once configured, these inputs will generate dynamic, time-series data that will be available to view in the Samsara Dashboard. **By default**: empty. This can be set or updated through the Samsara Dashboard or the API at any time. Inputs 3-13 are only available on gateways with an attached aux expander. Valid values: `None`, `Emergency Lights`, `Emergency Alarm`, `Stop Paddle`, `Power Take-Off`, `Plow`, `Sweeper`, `Salter`, `Reefer`, `Door`, `Boom`, `Auxiliary Engine`, `Generator`, `Eight-Way Lights`, `Panic Button`, `Privacy Button`, `Front Axle Drive`, `Weight Sensor`, `Other`, `Secondary Fuel Source`, `(ECU) Power Take-Off`.
    /// </summary>
    [JsonPropertyName("auxInputType4")]
    public UpdateVehicleRequestAuxInputType4? AuxInputType4 { get; set; }

    /// <summary>
    /// The type of &lt;a href="https://kb.samsara.com/hc/en-us/articles/360043040512-Auxiliary-Inputs" target="_blank"&gt;auxiliary input&lt;/a&gt; configured for this Vehicle. Once configured, these inputs will generate dynamic, time-series data that will be available to view in the Samsara Dashboard. **By default**: empty. This can be set or updated through the Samsara Dashboard or the API at any time. Inputs 3-13 are only available on gateways with an attached aux expander. Valid values: `None`, `Emergency Lights`, `Emergency Alarm`, `Stop Paddle`, `Power Take-Off`, `Plow`, `Sweeper`, `Salter`, `Reefer`, `Door`, `Boom`, `Auxiliary Engine`, `Generator`, `Eight-Way Lights`, `Panic Button`, `Privacy Button`, `Front Axle Drive`, `Weight Sensor`, `Other`, `Secondary Fuel Source`, `(ECU) Power Take-Off`.
    /// </summary>
    [JsonPropertyName("auxInputType5")]
    public UpdateVehicleRequestAuxInputType5? AuxInputType5 { get; set; }

    /// <summary>
    /// The type of &lt;a href="https://kb.samsara.com/hc/en-us/articles/360043040512-Auxiliary-Inputs" target="_blank"&gt;auxiliary input&lt;/a&gt; configured for this Vehicle. Once configured, these inputs will generate dynamic, time-series data that will be available to view in the Samsara Dashboard. **By default**: empty. This can be set or updated through the Samsara Dashboard or the API at any time. Inputs 3-13 are only available on gateways with an attached aux expander. Valid values: `None`, `Emergency Lights`, `Emergency Alarm`, `Stop Paddle`, `Power Take-Off`, `Plow`, `Sweeper`, `Salter`, `Reefer`, `Door`, `Boom`, `Auxiliary Engine`, `Generator`, `Eight-Way Lights`, `Panic Button`, `Privacy Button`, `Front Axle Drive`, `Weight Sensor`, `Other`, `Secondary Fuel Source`, `(ECU) Power Take-Off`.
    /// </summary>
    [JsonPropertyName("auxInputType6")]
    public UpdateVehicleRequestAuxInputType6? AuxInputType6 { get; set; }

    /// <summary>
    /// The type of &lt;a href="https://kb.samsara.com/hc/en-us/articles/360043040512-Auxiliary-Inputs" target="_blank"&gt;auxiliary input&lt;/a&gt; configured for this Vehicle. Once configured, these inputs will generate dynamic, time-series data that will be available to view in the Samsara Dashboard. **By default**: empty. This can be set or updated through the Samsara Dashboard or the API at any time. Inputs 3-13 are only available on gateways with an attached aux expander. Valid values: `None`, `Emergency Lights`, `Emergency Alarm`, `Stop Paddle`, `Power Take-Off`, `Plow`, `Sweeper`, `Salter`, `Reefer`, `Door`, `Boom`, `Auxiliary Engine`, `Generator`, `Eight-Way Lights`, `Panic Button`, `Privacy Button`, `Front Axle Drive`, `Weight Sensor`, `Other`, `Secondary Fuel Source`, `(ECU) Power Take-Off`.
    /// </summary>
    [JsonPropertyName("auxInputType7")]
    public UpdateVehicleRequestAuxInputType7? AuxInputType7 { get; set; }

    /// <summary>
    /// The type of &lt;a href="https://kb.samsara.com/hc/en-us/articles/360043040512-Auxiliary-Inputs" target="_blank"&gt;auxiliary input&lt;/a&gt; configured for this Vehicle. Once configured, these inputs will generate dynamic, time-series data that will be available to view in the Samsara Dashboard. **By default**: empty. This can be set or updated through the Samsara Dashboard or the API at any time. Inputs 3-13 are only available on gateways with an attached aux expander. Valid values: `None`, `Emergency Lights`, `Emergency Alarm`, `Stop Paddle`, `Power Take-Off`, `Plow`, `Sweeper`, `Salter`, `Reefer`, `Door`, `Boom`, `Auxiliary Engine`, `Generator`, `Eight-Way Lights`, `Panic Button`, `Privacy Button`, `Front Axle Drive`, `Weight Sensor`, `Other`, `Secondary Fuel Source`, `(ECU) Power Take-Off`.
    /// </summary>
    [JsonPropertyName("auxInputType8")]
    public UpdateVehicleRequestAuxInputType8? AuxInputType8 { get; set; }

    /// <summary>
    /// The type of &lt;a href="https://kb.samsara.com/hc/en-us/articles/360043040512-Auxiliary-Inputs" target="_blank"&gt;auxiliary input&lt;/a&gt; configured for this Vehicle. Once configured, these inputs will generate dynamic, time-series data that will be available to view in the Samsara Dashboard. **By default**: empty. This can be set or updated through the Samsara Dashboard or the API at any time. Inputs 3-13 are only available on gateways with an attached aux expander. Valid values: `None`, `Emergency Lights`, `Emergency Alarm`, `Stop Paddle`, `Power Take-Off`, `Plow`, `Sweeper`, `Salter`, `Reefer`, `Door`, `Boom`, `Auxiliary Engine`, `Generator`, `Eight-Way Lights`, `Panic Button`, `Privacy Button`, `Front Axle Drive`, `Weight Sensor`, `Other`, `Secondary Fuel Source`, `(ECU) Power Take-Off`.
    /// </summary>
    [JsonPropertyName("auxInputType9")]
    public UpdateVehicleRequestAuxInputType9? AuxInputType9 { get; set; }

    /// <summary>
    /// A manual override for the vehicle's engine hours. You may only override a vehicle's engine hours if it cannot be read from on-board diagnostics. When you provide a manual engine hours override, Samsara will begin updating a vehicle's engine hours based on when the Samsara Vehicle Gateway is recieving power or not. Setting the value to 0 will unset the manual engine hours.
    /// </summary>
    [JsonPropertyName("engineHours")]
    public long? EngineHours { get; set; }

    /// <summary>
    /// The &lt;a href="/docs/external-ids" target="_blank"&gt;external IDs&lt;/a&gt; for the given object.
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    [JsonPropertyName("gatewaySerial")]
    public string? GatewaySerial { get; set; }

    [JsonPropertyName("grossVehicleWeight")]
    public GrossVehicleWeight? GrossVehicleWeight { get; set; }

    /// <summary>
    /// The harsh acceleration setting type. This setting influences the acceleration sensitivity from which a &lt;a href="https://kb.samsara.com/hc/en-us/articles/360043051792-Safety-Event-Overview" target="_blank"&gt;harsh event&lt;/a&gt; is triggered. **By default**, this setting is inferred by the Samsara Vehicle Gateway from the engine computer, but it may be set or updated through the Samsara Dashboard or the API at any time. If set to `off`, then no acceleration based harsh events are triggered for the vehicle. Valid values: `passengerCar`, `lightTruck`, `heavyDuty`, `off`, `automatic`.
    /// </summary>
    [JsonPropertyName("harshAccelerationSettingType")]
    public UpdateVehicleRequestHarshAccelerationSettingType? HarshAccelerationSettingType { get; set; }

    /// <summary>
    /// The license plate of the Vehicle. **By default**: empty. Can be set or updated through the Samsara Dashboard or the API at any time.
    /// </summary>
    [JsonPropertyName("licensePlate")]
    public string? LicensePlate { get; set; }

    /// <summary>
    /// The human-readable name of the Vehicle. This is set by a fleet administrator and will appear in both Samsara’s cloud dashboard as well as the Samsara Driver mobile app. **By default**, this name is the serial number of the Samsara Vehicle Gateway. It can be set or updated through the Samsara Dashboard or through the API at any time.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// These are generic notes about the Vehicle. Empty by default. Can be set or updated through the Samsara Dashboard or the API at any time.
    /// </summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>
    /// A manual override for the vehicle's odometer. You may only override a vehicle's odometer if it cannot be read from on-board diagnostics. When you provide a manual odometer override, Samsara will begin updating a vehicle's odometer using GPS distance traveled since this override was set. See &lt;a href="https://kb.samsara.com/hc/en-us/articles/115005273667" target="_blank"&gt;here&lt;/a&gt; for more details.
    /// </summary>
    [JsonPropertyName("odometerMeters")]
    public long? OdometerMeters { get; set; }

    /// <summary>
    /// ID for the static assigned driver of the vehicle. Setting the value to 0 will unassign the current driver.
    /// </summary>
    [JsonPropertyName("staticAssignedDriverId")]
    public string? StaticAssignedDriverId { get; set; }

    /// <summary>
    /// An array of IDs of tags to associate with this vehicle. If your access to the API is scoped by one or more tags, this field is required to pass in.
    /// </summary>
    [JsonPropertyName("tagIds")]
    public IEnumerable<string>? TagIds { get; set; }

    [JsonPropertyName("vehicleRegulationMode")]
    public VehicleRegulationMode? VehicleRegulationMode { get; set; }

    [JsonPropertyName("vehicleType")]
    public string? VehicleType { get; set; }

    /// <summary>
    /// The VIN of the Vehicle. Most of the time, this will be automatically read from the engine computer by the Samsara Vehicle Gateway. It will be empty if it cannot be read. It can be set or updated through the Samsara Dashboard or the API at any time.
    /// </summary>
    [JsonPropertyName("vin")]
    public string? Vin { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
