using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record Vehicle
{
    /// <summary>
    /// A minified attribute
    /// </summary>
    [JsonPropertyName("attributes")]
    public IEnumerable<AttributeTiny>? Attributes { get; set; }

    [JsonPropertyName("auxInputType1")]
    public string? AuxInputType1 { get; set; }

    [JsonPropertyName("auxInputType10")]
    public string? AuxInputType10 { get; set; }

    [JsonPropertyName("auxInputType11")]
    public string? AuxInputType11 { get; set; }

    [JsonPropertyName("auxInputType12")]
    public string? AuxInputType12 { get; set; }

    [JsonPropertyName("auxInputType13")]
    public string? AuxInputType13 { get; set; }

    [JsonPropertyName("auxInputType2")]
    public string? AuxInputType2 { get; set; }

    [JsonPropertyName("auxInputType3")]
    public string? AuxInputType3 { get; set; }

    [JsonPropertyName("auxInputType4")]
    public string? AuxInputType4 { get; set; }

    [JsonPropertyName("auxInputType5")]
    public string? AuxInputType5 { get; set; }

    [JsonPropertyName("auxInputType6")]
    public string? AuxInputType6 { get; set; }

    [JsonPropertyName("auxInputType7")]
    public string? AuxInputType7 { get; set; }

    [JsonPropertyName("auxInputType8")]
    public string? AuxInputType8 { get; set; }

    [JsonPropertyName("auxInputType9")]
    public string? AuxInputType9 { get; set; }

    [JsonPropertyName("cameraSerial")]
    public string? CameraSerial { get; set; }

    [JsonPropertyName("esn")]
    public string? Esn { get; set; }

    [JsonPropertyName("externalIds")]
    public object? ExternalIds { get; set; }

    [JsonPropertyName("gateway")]
    public GatewayTiny? Gateway { get; set; }

    [JsonPropertyName("grossVehicleWeight")]
    public GrossVehicleWeight? GrossVehicleWeight { get; set; }

    [JsonPropertyName("harshAccelerationSettingType")]
    public VehicleHarshAccelerationSettingType? HarshAccelerationSettingType { get; set; }

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("licensePlate")]
    public string? LicensePlate { get; set; }

    [JsonPropertyName("make")]
    public string? Make { get; set; }

    [JsonPropertyName("model")]
    public string? Model { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("sensorConfiguration")]
    public VehicleSensorConfiguration? SensorConfiguration { get; set; }

    [JsonPropertyName("serial")]
    public string? Serial { get; set; }

    [JsonPropertyName("staticAssignedDriver")]
    public DriverTinyResponse? StaticAssignedDriver { get; set; }

    [JsonPropertyName("tags")]
    public IEnumerable<TagTinyResponse>? Tags { get; set; }

    [JsonPropertyName("vehicleRegulationMode")]
    public VehicleRegulationMode? VehicleRegulationMode { get; set; }

    [JsonPropertyName("vehicleType")]
    public string? VehicleType { get; set; }

    [JsonPropertyName("vin")]
    public string? Vin { get; set; }

    [JsonPropertyName("year")]
    public string? Year { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
