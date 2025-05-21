using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Beta.Assets;

public record AssetsDeleteRequest
{
    /// <summary>
    /// A filter selecting a single asset by id.
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
