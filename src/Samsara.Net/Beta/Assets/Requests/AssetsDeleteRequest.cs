using Samsara.Net.Core;

namespace Samsara.Net.Beta.Assets;

public record AssetsDeleteRequest
{
    /// <summary>
    /// A filter selecting a single asset by id.
    /// </summary>
    public required string Id { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
