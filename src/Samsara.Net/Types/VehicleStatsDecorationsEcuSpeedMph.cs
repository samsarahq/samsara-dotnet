using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsDecorationsEcuSpeedMph
{
    [JsonPropertyName("value")]
    public required double Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
