using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Vendor specific data for J1939 vehicles.
/// </summary>
[Serializable]
public record VehicleStatsFaultCodesVendorSpecificFields : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The DTC description, if available.
    /// </summary>
    [JsonPropertyName("dtcDescription")]
    public string? DtcDescription { get; set; }

    /// <summary>
    /// A link to vendor repair instructions, if available.
    /// </summary>
    [JsonPropertyName("repairInstructionsUrl")]
    public string? RepairInstructionsUrl { get; set; }

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
