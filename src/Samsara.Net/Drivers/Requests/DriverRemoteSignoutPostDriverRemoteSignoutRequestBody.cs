using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Drivers;

[Serializable]
public record DriverRemoteSignoutPostDriverRemoteSignoutRequestBody
{
    /// <summary>
    /// ID of the driver.
    /// </summary>
    [JsonPropertyName("driverId")]
    public required string DriverId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
