using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1DvirBaseNextDriverSignature
{
    /// <summary>
    /// ID of the driver who signed the DVIR
    /// </summary>
    [JsonPropertyName("driverId")]
    public long? DriverId { get; set; }

    /// <summary>
    /// Email of the  driver who signed the next DVIR on this vehicle.
    /// </summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>
    /// The name of the driver who signed the next DVIR on this vehicle.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The time in millis when the next driver signed the DVIR on this vehicle.
    /// </summary>
    [JsonPropertyName("signedAt")]
    public long? SignedAt { get; set; }

    /// <summary>
    /// Type corresponds to driver.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Username of the  driver who signed the next DVIR on this vehicle.
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
