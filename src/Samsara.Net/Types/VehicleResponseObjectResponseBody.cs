using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A single vehicle
/// </summary>
[Serializable]
public record VehicleResponseObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// List of attributes associated with the entity
    /// </summary>
    [JsonPropertyName("attributes")]
    public IEnumerable<GoaAttributeTinyResponseBody>? Attributes { get; set; }

    /// <summary>
    /// The type of auxiliary input configured for this Vehicle.
    /// </summary>
    [JsonPropertyName("auxInputType1")]
    public string? AuxInputType1 { get; set; }

    /// <summary>
    /// The type of auxiliary input configured for this Vehicle.
    /// </summary>
    [JsonPropertyName("auxInputType10")]
    public string? AuxInputType10 { get; set; }

    /// <summary>
    /// The type of auxiliary input configured for this Vehicle.
    /// </summary>
    [JsonPropertyName("auxInputType11")]
    public string? AuxInputType11 { get; set; }

    /// <summary>
    /// The type of auxiliary input configured for this Vehicle.
    /// </summary>
    [JsonPropertyName("auxInputType12")]
    public string? AuxInputType12 { get; set; }

    /// <summary>
    /// The type of auxiliary input configured for this Vehicle.
    /// </summary>
    [JsonPropertyName("auxInputType13")]
    public string? AuxInputType13 { get; set; }

    /// <summary>
    /// The type of auxiliary input configured for this Vehicle.
    /// </summary>
    [JsonPropertyName("auxInputType2")]
    public string? AuxInputType2 { get; set; }

    /// <summary>
    /// The type of auxiliary input configured for this Vehicle.
    /// </summary>
    [JsonPropertyName("auxInputType3")]
    public string? AuxInputType3 { get; set; }

    /// <summary>
    /// The type of auxiliary input configured for this Vehicle.
    /// </summary>
    [JsonPropertyName("auxInputType4")]
    public string? AuxInputType4 { get; set; }

    /// <summary>
    /// The type of auxiliary input configured for this Vehicle.
    /// </summary>
    [JsonPropertyName("auxInputType5")]
    public string? AuxInputType5 { get; set; }

    /// <summary>
    /// The type of auxiliary input configured for this Vehicle.
    /// </summary>
    [JsonPropertyName("auxInputType6")]
    public string? AuxInputType6 { get; set; }

    /// <summary>
    /// The type of auxiliary input configured for this Vehicle.
    /// </summary>
    [JsonPropertyName("auxInputType7")]
    public string? AuxInputType7 { get; set; }

    /// <summary>
    /// The type of auxiliary input configured for this Vehicle.
    /// </summary>
    [JsonPropertyName("auxInputType8")]
    public string? AuxInputType8 { get; set; }

    /// <summary>
    /// The type of auxiliary input configured for this Vehicle.
    /// </summary>
    [JsonPropertyName("auxInputType9")]
    public string? AuxInputType9 { get; set; }

    /// <summary>
    /// The serial number of the camera installed in the vehicle
    /// </summary>
    [JsonPropertyName("cameraSerial")]
    public string? CameraSerial { get; set; }

    /// <summary>
    /// Time the vehicle was created in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public required DateTime CreatedAtTime { get; set; }

    /// <summary>
    /// Engine serial number.
    /// </summary>
    [JsonPropertyName("esn")]
    public string? Esn { get; set; }

    /// <summary>
    /// A map of external ids
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    [JsonPropertyName("gateway")]
    public GoaGatewayTinyResponseResponseBody? Gateway { get; set; }

    /// <summary>
    /// The harsh acceleration setting type.
    /// </summary>
    [JsonPropertyName("harshAccelerationSettingType")]
    public string? HarshAccelerationSettingType { get; set; }

    /// <summary>
    /// ID of the vehicle
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Whether the remote privacy button is enabled for the vehicle. If omitted, the organization does not have the remote privacy button feature enabled.
    /// </summary>
    [JsonPropertyName("isRemotePrivacyButtonEnabled")]
    public bool? IsRemotePrivacyButtonEnabled { get; set; }

    /// <summary>
    /// The license plate of the vehicle.
    /// </summary>
    [JsonPropertyName("licensePlate")]
    public string? LicensePlate { get; set; }

    /// <summary>
    /// The Vehicle’s manufacturing make.
    /// </summary>
    [JsonPropertyName("make")]
    public string? Make { get; set; }

    /// <summary>
    /// The Vehicle’s manufacturing model.
    /// </summary>
    [JsonPropertyName("model")]
    public string? Model { get; set; }

    /// <summary>
    /// Name of the vehicle
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// These are generic notes about the Vehicle.
    /// </summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("sensorConfiguration")]
    public VehicleSensorConfigurationResponseBody? SensorConfiguration { get; set; }

    /// <summary>
    /// The serial number of the gateway installed in the vehicle.
    /// </summary>
    [JsonPropertyName("serial")]
    public string? Serial { get; set; }

    [JsonPropertyName("staticAssignedDriver")]
    public DriverObjectResponseBody? StaticAssignedDriver { get; set; }

    /// <summary>
    /// The list of tags associated with the Vehicle.
    /// </summary>
    [JsonPropertyName("tags")]
    public IEnumerable<GoaTagTinyResponseResponseBody>? Tags { get; set; }

    /// <summary>
    /// Time the vehicle was updated in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("updatedAtTime")]
    public DateTime? UpdatedAtTime { get; set; }

    /// <summary>
    /// Whether the vehicle is regulated or unregulated (non-CMV).  Valid values: `regulated`, `unregulated`
    /// </summary>
    [JsonPropertyName("vehicleRegulationMode")]
    public VehicleResponseObjectResponseBodyVehicleRegulationMode? VehicleRegulationMode { get; set; }

    /// <summary>
    /// The type of the vehicle. Only returned for customers with commercial speed limits (CSL) enabled.  Valid values: `unset`, `passenger`, `truck`, `bus`
    /// </summary>
    [JsonPropertyName("vehicleType")]
    public VehicleResponseObjectResponseBodyVehicleType? VehicleType { get; set; }

    /// <summary>
    /// The weight of the vehicle in either pounds (lb) or kilograms (kg). Unit of weight is unknown. Only returned for customers with commercial speed limits (CSL) enabled.
    /// </summary>
    [JsonPropertyName("vehicleWeight")]
    public long? VehicleWeight { get; set; }

    /// <summary>
    /// The weight of the vehicle in kilograms (kg). Only returned for customers with commercial speed limits (CSL) enabled.
    /// </summary>
    [JsonPropertyName("vehicleWeightInKilograms")]
    public long? VehicleWeightInKilograms { get; set; }

    /// <summary>
    /// The weight of the vehicle in pounds (lb). Only returned for customers with commercial speed limits (CSL) enabled.
    /// </summary>
    [JsonPropertyName("vehicleWeightInPounds")]
    public long? VehicleWeightInPounds { get; set; }

    /// <summary>
    /// The VIN of the vehicle.
    /// </summary>
    [JsonPropertyName("vin")]
    public string? Vin { get; set; }

    [JsonPropertyName("year")]
    public string? Year { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
