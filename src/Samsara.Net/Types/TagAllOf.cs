using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record TagAllOf : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The addresses that belong to this tag.
    /// </summary>
    [JsonPropertyName("addresses")]
    public IEnumerable<TaggedObject>? Addresses { get; set; }

    /// <summary>
    /// The trailers, unpowered, and powered assets that belong to this tag.
    /// </summary>
    [JsonPropertyName("assets")]
    public IEnumerable<TaggedObject>? Assets { get; set; }

    /// <summary>
    /// The drivers that belong to this tag.
    /// </summary>
    [JsonPropertyName("drivers")]
    public IEnumerable<TaggedObject>? Drivers { get; set; }

    /// <summary>
    /// The [external IDs](https://developers.samsara.com/docs/external-ids) for the given object.
    /// </summary>
    [JsonPropertyName("externalIds")]
    public TagAllOfExternalIds? ExternalIds { get; set; }

    /// <summary>
    /// The machines that belong to thistag.
    /// </summary>
    [JsonPropertyName("machines")]
    public IEnumerable<TaggedObject>? Machines { get; set; }

    [JsonPropertyName("parentTag")]
    public ParentTag? ParentTag { get; set; }

    /// <summary>
    /// The sensors that belong to this tag.
    /// </summary>
    [JsonPropertyName("sensors")]
    public IEnumerable<TaggedObject>? Sensors { get; set; }

    /// <summary>
    /// The vehicles that belong to this tag.
    /// </summary>
    [JsonPropertyName("vehicles")]
    public IEnumerable<TaggedObject>? Vehicles { get; set; }

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
