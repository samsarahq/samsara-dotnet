using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// ListTimeEntriesEntityTimeEntryTimeEntryLocation object
/// </summary>
[Serializable]
public record ListTimeEntriesEntityTimeEntryTimeEntryLocationTypeResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Latitude in decimal degrees.
    /// </summary>
    [JsonPropertyName("latitude")]
    public double? Latitude { get; set; }

    /// <summary>
    /// Longitude in decimal degrees.
    /// </summary>
    [JsonPropertyName("longitude")]
    public double? Longitude { get; set; }

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
