using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record PostDriverVehicleAssignmentsV2ResponseBodyResponseBody
{
    /// <summary>
    /// A description of the outcome from submitting Driver Assignment information
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
