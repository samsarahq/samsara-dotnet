using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record GetRidershipPassengerRequest
{
    /// <summary>
    /// ID of the ridership passenger. This can either be the Samsara-specified UUID, or an external ID. External IDs are customer-specified key-value pairs. To specify an external ID, use the following format: `key:value`. For example, `student:STU-001`.
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <summary>
    /// Optional boolean indicating whether to return external IDs on supported entities
    /// </summary>
    [JsonIgnore]
    public bool? IncludeExternalIds { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
