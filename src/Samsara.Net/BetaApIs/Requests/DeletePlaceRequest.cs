using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record DeletePlaceRequest
{
    /// <summary>
    /// Samsara place id to delete. Mutually exclusive with `externalId`; provide exactly one.
    /// </summary>
    [JsonIgnore]
    public long? PlaceId { get; set; }

    /// <summary>
    /// External id token in `key:value` form (e.g. crmId:warehouse-east). Mutually exclusive with `placeId`; provide exactly one.
    /// </summary>
    [JsonIgnore]
    public string? ExternalId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
