using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1HosAuthenticationLogsResponse
{
    [JsonPropertyName("authenticationLogs")]
    public IEnumerable<V1HosAuthenticationLogsResponseAuthenticationLogs>? AuthenticationLogs { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
