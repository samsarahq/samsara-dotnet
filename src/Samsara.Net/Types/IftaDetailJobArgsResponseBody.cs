using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The arguments used to create this job.
/// </summary>
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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
