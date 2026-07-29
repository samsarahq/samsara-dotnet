using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record EntityWatchpointsServiceUpdateWatchpointRequestBody
{
    /// <summary>
    /// Unique identifier for the Watchpoint record.
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <summary>
    /// Customer-provided name for the watchpoint. Set to null to clear.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Customer-provided note about the watchpoint. Set to null to clear.
    /// </summary>
    [JsonPropertyName("note")]
    public string? Note { get; set; }

    /// <summary>
    /// Type of condition to observe at this watchpoint.  Valid values: `roadDefect`, `utilityCut`, `guardrail`, `streetlight`, `signage`, `stormDrain`, `graffiti`, `vegetation`, `blight`, `illegalDumping`, `littering`, `highVegetationWeeds`, `fire`, `other`
    /// </summary>
    [JsonPropertyName("observationType")]
    public EntityWatchpointsServiceUpdateWatchpointRequestBodyObservationType? ObservationType { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
