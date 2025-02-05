using Samsara.Net.Core;

namespace Samsara.Net.Safety;

public record SafetyV1GetVehicleHarshEventRequest
{
    /// <summary>
    /// Timestamp in milliseconds representing the timestamp of a harsh event.
    /// </summary>
    public required long Timestamp { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
