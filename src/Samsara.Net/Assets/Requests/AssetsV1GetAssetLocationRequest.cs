using Samsara.Net.Core;

namespace Samsara.Net.Assets;

public record AssetsV1GetAssetLocationRequest
{
    /// <summary>
    /// Timestamp in milliseconds representing the start of the period to fetch, inclusive. Used in combination with endMs.
    /// </summary>
    public required long StartMs { get; set; }

    /// <summary>
    /// Timestamp in milliseconds representing the end of the period to fetch, inclusive. Used in combination with startMs.
    /// </summary>
    public required long EndMs { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
