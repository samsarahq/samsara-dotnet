using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record HosLogsForDriver
{
    [JsonPropertyName("driver")]
    public DriverTinyResponse? Driver { get; set; }

    [JsonPropertyName("hosLogs")]
    public IEnumerable<HosLogEntry>? HosLogs { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
