using Samsara.Net.Core;

namespace Samsara.Net.Industrial;

public record IndustrialGetLatestRunRequest
{
    /// <summary>
    /// The configured program's ID on the camera.
    /// </summary>
    public long? ProgramId { get; set; }

    /// <summary>
    /// EndMs is an optional param. It will default to the current time.
    /// </summary>
    public long? StartedAtMs { get; set; }

    /// <summary>
    /// Include is a filter parameter. Accepts 'pass', 'reject' or 'no_read'.
    /// </summary>
    public string? Include { get; set; }

    /// <summary>
    /// Limit is an integer value from 1 to 1,000.
    /// </summary>
    public long? Limit { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
