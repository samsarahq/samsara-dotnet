using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Safety;

public record SafetyGetDriverSafetyScoreRequest
{
    /// <summary>
    /// Timestamp in milliseconds representing the start of the period to fetch, inclusive. Used in combination with endMs. Total duration (endMs - startMs) must be greater than or equal to 1 hour.
    /// </summary>
    [JsonIgnore]
    public required long StartMs { get; set; }

    /// <summary>
    /// Timestamp in milliseconds representing the end of the period to fetch, inclusive. Used in combination with startMs. Total duration (endMs - startMs) must be greater than or equal to 1 hour.
    /// </summary>
    [JsonIgnore]
    public required long EndMs { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
