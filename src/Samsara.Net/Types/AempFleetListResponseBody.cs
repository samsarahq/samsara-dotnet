using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Contains a list of equipment objects and links
/// </summary>
[Serializable]
public record AempFleetListResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The list of Equipment objects.
    /// </summary>
    [JsonPropertyName("Equipment")]
    public IEnumerable<AempEquipmentWithAdditionalFieldsResponseBody> Equipment { get; set; } =
        new List<AempEquipmentWithAdditionalFieldsResponseBody>();

    /// <summary>
    /// The list of links associated with the current API request.
    /// </summary>
    [JsonPropertyName("Links")]
    public IEnumerable<AempLinkResponseBody> Links { get; set; } = new List<AempLinkResponseBody>();

    /// <summary>
    /// Date and time at which the snapshot of the fleet was created in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("snapshotTime")]
    public required string SnapshotTime { get; set; }

    /// <summary>
    /// The version of the ISO/TS 15143-3 standard
    /// </summary>
    [JsonPropertyName("version")]
    public required string Version { get; set; }

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
