using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record GrossVehicleWeight
{
    /// <summary>
    /// The unit of weight for the vehicle.
    /// </summary>
    [JsonPropertyName("unit")]
    public GrossVehicleWeightUnit? Unit { get; set; }

    /// <summary>
    /// The weight value of the vehicle.
    /// </summary>
    [JsonPropertyName("weight")]
    public long? Weight { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
