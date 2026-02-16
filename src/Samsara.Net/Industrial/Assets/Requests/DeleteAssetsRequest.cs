using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Industrial.Assets;

[Serializable]
public record DeleteAssetsRequest
{
    /// <summary>
    /// Id of the asset to be deleted.
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
