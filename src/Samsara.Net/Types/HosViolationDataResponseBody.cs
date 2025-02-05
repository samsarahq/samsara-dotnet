using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record HosViolationDataResponseBody
{
    [JsonPropertyName("driver")]
    public AlertObjectDriverResponseBody? Driver { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
