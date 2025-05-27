using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Coaching.DriverCoachAssignments;

public record DriverCoachAssignmentsUpdateRequest
{
    /// <summary>
    /// Required string ID of the driver. This is a unique Samsara ID of a driver.
    /// </summary>
    [JsonIgnore]
    public required string DriverId { get; set; }

    /// <summary>
    /// Optional string ID of the coach. This is a unique Samsara user ID. If not provided, existing coach assignment will be removed.
    /// </summary>
    [JsonIgnore]
    public string? CoachId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
