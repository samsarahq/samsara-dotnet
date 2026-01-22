using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Assets;

[Serializable]
public record UpdateAssetsRequest
{
    [JsonIgnore]
    public required string Id { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
