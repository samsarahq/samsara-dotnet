using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
