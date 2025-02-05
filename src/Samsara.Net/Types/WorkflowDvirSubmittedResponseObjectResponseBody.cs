using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record WorkflowDvirSubmittedResponseObjectResponseBody
{
    [JsonPropertyName("driver")]
    public GoaDriverTinyResponseResponseBody? Driver { get; set; }

    [JsonPropertyName("dvir")]
    public WorkflowDvirObjectResponseBody? Dvir { get; set; }

    [JsonPropertyName("vehicle")]
    public VehicleWithGatewayTinyResponseResponseBody? Vehicle { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
