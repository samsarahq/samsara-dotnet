using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.Industrial;

public record AssetPatch
{
    [JsonPropertyName("customMetadata")]
    public Dictionary<string, string>? CustomMetadata { get; set; }

    [JsonPropertyName("location")]
    public AssetLocation? Location { get; set; }

    /// <summary>
    /// Required if locationType is "dataInput". Specifies the id of a location data input which will determine the asset's location. The data input must be in the asset.
    /// </summary>
    [JsonPropertyName("locationDataInputId")]
    public string? LocationDataInputId { get; set; }

    [JsonPropertyName("locationType")]
    public LocationType? LocationType { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The id of the parent asset that the asset belongs to. Pass in an empty string to remove the child from the parent.
    /// </summary>
    [JsonPropertyName("parentId")]
    public string? ParentId { get; set; }

    /// <summary>
    /// The asset's isRunning status will be true when the associated data input's value is 1. Data input cannot be of location format. The data input must be in the asset.
    /// </summary>
    [JsonPropertyName("runningStatusDataInputId")]
    public string? RunningStatusDataInputId { get; set; }

    [JsonPropertyName("tagIds")]
    public IEnumerable<string>? TagIds { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
