using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// An object containing information about the gateway data usage in mb for the last 30 days.
/// </summary>
[Serializable]
public record DataUsageResponseObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Celluar data usage in bytes.
    /// </summary>
    [JsonPropertyName("cellularDataUsageBytes")]
    public long? CellularDataUsageBytes { get; set; }

    /// <summary>
    /// Wifi hotspot data usage in bytes.
    /// </summary>
    [JsonPropertyName("hotspotUsageBytes")]
    public long? HotspotUsageBytes { get; set; }

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
