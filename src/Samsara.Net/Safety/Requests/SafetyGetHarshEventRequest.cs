using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Safety;

public record SafetyGetHarshEventRequest
{
    /// <summary>
    /// Timestamp in milliseconds representing the timestamp of a harsh event.
    /// </summary>
    [JsonIgnore]
    public required long Timestamp { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
