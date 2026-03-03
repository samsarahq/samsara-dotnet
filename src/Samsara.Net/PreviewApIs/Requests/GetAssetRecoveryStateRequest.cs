using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.PreviewApIs;

[Serializable]
public record GetAssetRecoveryStateRequest
{
    /// <summary>
    /// The ID of the asset. This can be a Samsara internal ID or an external ID in the format `key:value`.
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
