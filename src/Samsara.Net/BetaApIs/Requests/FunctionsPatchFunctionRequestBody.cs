using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record FunctionsPatchFunctionRequestBody
{
    /// <summary>
    /// The name of the Function to update.
    /// </summary>
    [JsonIgnore]
    public required string Name { get; set; }

    [JsonPropertyName("config")]
    public PatchFunctionRequestConfigRequestBody? Config { get; set; }

    /// <summary>
    /// A description of the Function.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Timestamp of the last known update to this Function, obtained from a create or get response. Required to prevent conflicting updates.
    /// </summary>
    [JsonPropertyName("lastUpdateTimestampMs")]
    public required long LastUpdateTimestampMs { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
