using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Tags;

[Serializable]
public record CreateTagRequest
{
    /// <summary>
    /// The addresses that belong to this tag.
    /// </summary>
    [JsonPropertyName("addresses")]
    public IEnumerable<string>? Addresses { get; set; }

    /// <summary>
    /// The trailers, unpowered, and powered assets that belong to this tag.
    /// </summary>
    [JsonPropertyName("assets")]
    public IEnumerable<string>? Assets { get; set; }

    /// <summary>
    /// The drivers that belong to this tag.
    /// </summary>
    [JsonPropertyName("drivers")]
    public IEnumerable<string>? Drivers { get; set; }

    /// <summary>
    /// The [external IDs](https://developers.samsara.com/docs/external-ids) for the given object.
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    /// <summary>
    /// The machines that belong to this tag.
    /// </summary>
    [JsonPropertyName("machines")]
    public IEnumerable<string>? Machines { get; set; }

    /// <summary>
    /// Name of this tag.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// If this tag is part a hierarchical tag tree, this is the ID of the parent tag, otherwise this will be omitted.
    /// </summary>
    [JsonPropertyName("parentTagId")]
    public string? ParentTagId { get; set; }

    /// <summary>
    /// The sensors that belong to this tag.
    /// </summary>
    [JsonPropertyName("sensors")]
    public IEnumerable<string>? Sensors { get; set; }

    /// <summary>
    /// The vehicles that belong to this tag.
    /// </summary>
    [JsonPropertyName("vehicles")]
    public IEnumerable<string>? Vehicles { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
