using Samsara.Net.Core;

namespace Samsara.Net.Coaching;

public record CoachingPutDriverAssignmentRequest
{
    /// <summary>
    /// Required string ID of the driver. This is a unique Samsara ID of a driver.
    /// </summary>
    public required string DriverId { get; set; }

    /// <summary>
    /// Optional string ID of the coach. This is a unique Samsara user ID. If not provided, existing coach assignment will be removed.
    /// </summary>
    public string? CoachId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
