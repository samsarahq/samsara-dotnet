using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record DeleteRidershipPassengerRequest
{
    /// <summary>
    /// Samsara UUID of the passenger, or an external ID in `key:value` format, such as `student:STU-001`.
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
