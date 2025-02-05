using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

public record DriverRemoteSignoutPostDriverRemoteSignoutRequestBody
{
    /// <summary>
    /// ID of the driver.
    /// </summary>
    [JsonPropertyName("driverId")]
    public required string DriverId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
