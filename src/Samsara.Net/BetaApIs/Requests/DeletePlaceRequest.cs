using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record DeletePlaceRequest
{
    /// <summary>
    /// Samsara place id to delete.
    /// </summary>
    [JsonIgnore]
    public required long PlaceId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
