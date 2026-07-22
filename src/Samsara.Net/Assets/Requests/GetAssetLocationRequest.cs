using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Assets;

[Serializable]
public record GetAssetLocationRequest
{
    /// <summary>
    /// Samsara asset ID.
    /// </summary>
    [JsonIgnore]
    public required long AssetId { get; set; }

    /// <summary>
    /// Timestamp in milliseconds representing the start of the period to fetch, inclusive. Used in combination with endMs.
    /// </summary>
    [JsonIgnore]
    public long? StartMs { get; set; }

    /// <summary>
    /// Timestamp in milliseconds representing the end of the period to fetch, inclusive. Used in combination with startMs.
    /// </summary>
    [JsonIgnore]
    public long? EndMs { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
