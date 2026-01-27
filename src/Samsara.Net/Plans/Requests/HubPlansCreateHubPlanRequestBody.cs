using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Plans;

[Serializable]
public record HubPlansCreateHubPlanRequestBody
{
    /// <summary>
    /// The ID of the hub the plan belongs to
    /// </summary>
    [JsonPropertyName("hubId")]
    public required string HubId { get; set; }

    /// <summary>
    /// The name of the plan
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The shift start time for the plan in RFC 3339 format. If not provided, defaults to 9:00 AM on the next business day in the hub's timezone.
    /// </summary>
    [JsonPropertyName("shiftStartTime")]
    public DateTime? ShiftStartTime { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
