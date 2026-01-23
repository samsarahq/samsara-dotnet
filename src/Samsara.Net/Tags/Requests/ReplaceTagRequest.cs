using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Tags;

[Serializable]
public record ReplaceTagRequest
{
    /// <summary>
    /// ID of the Tag. This can either be the Samsara-provided ID or an external ID. External IDs are customer-specified key-value pairs created in the POST or PATCH requests of this resource. To specify an external ID as part of a path parameter, use the following format: `key:value`. For example, `crmId:abc123`. Automatically populated external IDs are prefixed with `samsara.`. For example, `samsara.name:ELD-exempt`.
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

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
    /// The machines that belong to this tag.
    /// </summary>
    [JsonPropertyName("machines")]
    public IEnumerable<string>? Machines { get; set; }

    /// <summary>
    /// Name of this tag.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

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
