using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record IftaDetailJobArgsResponseBody
{
    /// <summary>
    /// The `endHour` used to create this job.
    /// </summary>
    [JsonPropertyName("endHour")]
    public required string EndHour { get; set; }

    /// <summary>
    /// The `startHour` used to create this job.
    /// </summary>
    [JsonPropertyName("startHour")]
    public required string StartHour { get; set; }

    /// <summary>
    /// The vehicleIds used to create this job. Determined by the filter list of `vehicleIds`, `vehicleTagIds`, and `vehicleParentTagIds` parameters (if provided).
    /// </summary>
    [JsonPropertyName("vehicleIds")]
    public IEnumerable<long> VehicleIds { get; set; } = new List<long>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
