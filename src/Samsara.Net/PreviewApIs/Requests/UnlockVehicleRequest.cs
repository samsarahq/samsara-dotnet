using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.PreviewApIs;

[Serializable]
public record UnlockVehicleRequest
{
    /// <summary>
    /// The ID of the vehicle to lock or unlock. This can be a Samsara internal ID or an external ID in the format `samsara.vin:{VIN}`.
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
