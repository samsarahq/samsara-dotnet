using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DriverRemoteSignoutPostDriverRemoteSignoutResponseBody
{
    /// <summary>
    /// The name of the driver
    /// </summary>
    [JsonPropertyName("driverName")]
    public string? DriverName { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
