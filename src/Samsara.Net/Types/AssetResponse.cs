using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record AssetResponse
{
    [JsonPropertyName("customMetadata")]
    public Dictionary<string, string>? CustomMetadata { get; set; }

    /// <summary>
    /// The list of data outputs configured on the asset.
    /// </summary>
    [JsonPropertyName("dataOutputs")]
    public IEnumerable<AssetDataOutput>? DataOutputs { get; set; }

    /// <summary>
    /// The id of the asset
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The running status of the asset. Returns True for On, and False for Off.
    /// </summary>
    [JsonPropertyName("isRunning")]
    public required bool IsRunning { get; set; }

    [JsonPropertyName("location")]
    public AssetLocation? Location { get; set; }

    [JsonPropertyName("locationDataInput")]
    public AssetResponseLocationDataInput? LocationDataInput { get; set; }

    [JsonPropertyName("locationType")]
    public LocationType? LocationType { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("parentAsset")]
    public AssetResponseParentAsset? ParentAsset { get; set; }

    [JsonPropertyName("runningStatusDataInput")]
    public AssetResponseRunningStatusDataInput? RunningStatusDataInput { get; set; }

    /// <summary>
    /// The list of [tags](https://kb.samsara.com/hc/en-us/articles/360026674631-Using-Tags-and-Tag-Nesting) associated with the Industrial Asset. **By default**: empty. Can be set or updated through the Samsara Dashboard or the API at any time.
    /// </summary>
    [JsonPropertyName("tags")]
    public IEnumerable<TagTinyResponse>? Tags { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
