using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// An equipment object.
/// </summary>
public record EquipmentObject
{
    /// <summary>
    /// An equipment identification number.
    /// </summary>
    [JsonPropertyName("assetSerial")]
    public string? AssetSerial { get; set; }

    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("installedGateway")]
    public EquipmentInstalledGateway? InstalledGateway { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Notes about a piece of equipment. Samsara supports a maximum of 255 chars.
    /// </summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>
    /// An array of all tag mini-objects that are associated with the given equipment.
    /// </summary>
    [JsonPropertyName("tags")]
    public IEnumerable<TagTinyResponse>? Tags { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
