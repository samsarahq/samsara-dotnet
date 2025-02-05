using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record HosDriversEldEventObjectResponseBody
{
    /// <summary>
    /// A value indicating whether the driver is active or deactivated.  Valid values: `active`, `deactivated`
    /// </summary>
    [JsonPropertyName("driverActivationStatus")]
    public required HosDriversEldEventObjectResponseBodyDriverActivationStatus DriverActivationStatus { get; set; }

    /// <summary>
    /// List of ELD event objects.
    /// </summary>
    [JsonPropertyName("eldEvents")]
    public IEnumerable<HosEldEventObjectResponseBody> EldEvents { get; set; } =
        new List<HosEldEventObjectResponseBody>();

    /// <summary>
    /// A map of external ids
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    /// <summary>
    /// ID of the driver.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Name of the driver.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
