using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Carrier for a given driver. If the driver's carrier differs from the general organization's carrier settings, the override value is used. Updating this value only updates the override setting for this driver.
/// </summary>
[Serializable]
public record DriverCarrierSettings : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Carrier for a given driver.
    /// </summary>
    [JsonPropertyName("carrierName")]
    public string? CarrierName { get; set; }

    /// <summary>
    /// Carrier US DOT Number. If this differs from the general organization's settings, the override value is used. Updating this value only updates the override setting for this driver.
    /// </summary>
    [JsonPropertyName("dotNumber")]
    public long? DotNumber { get; set; }

    [JsonPropertyName("homeTerminalAddress")]
    public string? HomeTerminalAddress { get; set; }

    [JsonPropertyName("homeTerminalName")]
    public string? HomeTerminalName { get; set; }

    /// <summary>
    /// Main office address for a given driver. If this differs from the general organization's settings, the override value is used.
    /// </summary>
    [JsonPropertyName("mainOfficeAddress")]
    public string? MainOfficeAddress { get; set; }

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
