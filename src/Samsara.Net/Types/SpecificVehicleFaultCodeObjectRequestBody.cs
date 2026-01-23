using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A specific vehicle fault code.
/// </summary>
[Serializable]
public record SpecificVehicleFaultCodeObjectRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The specific fault code name.
    /// </summary>
    [JsonPropertyName("faultCode")]
    public required string FaultCode { get; set; }

    /// <summary>
    /// The specific fault code type.  Valid values: `INVALID_FAULT_CODE_TYPE`, `J1939_DTC`, `J1939_SPN`, `PASSENGER_DTC`
    /// </summary>
    [JsonPropertyName("type")]
    public required SpecificVehicleFaultCodeObjectRequestBodyType Type { get; set; }

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
