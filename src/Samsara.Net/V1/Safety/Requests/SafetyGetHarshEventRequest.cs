using Samsara.Net.Core;

namespace Samsara.Net.V1.Safety;

public record SafetyGetHarshEventRequest
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
