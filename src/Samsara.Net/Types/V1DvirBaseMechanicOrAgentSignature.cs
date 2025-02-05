using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1DvirBaseMechanicOrAgentSignature
{
    /// <summary>
    /// ID of the driver who signed the DVIR. Will not be returned if mechanicUserId is returned.
    /// </summary>
    [JsonPropertyName("driverId")]
    public long? DriverId { get; set; }

    /// <summary>
    /// Email of the  agent|mechanic who signed the DVIR.
    /// </summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>
    /// ID of the mechanic who signed the DVIR. Will not be returned if driverId is returned.
    /// </summary>
    [JsonPropertyName("mechanicUserId")]
    public long? MechanicUserId { get; set; }

    /// <summary>
    /// The name of the agent or mechanic who signed the DVIR.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The time in millis when the DVIR was signed
    /// </summary>
    [JsonPropertyName("signedAt")]
    public long? SignedAt { get; set; }

    /// <summary>
    /// Type corresponds to whether the signature corresponds to driver|mechanic.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Username of the  agent|mechanic who signed the DVIR.
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
