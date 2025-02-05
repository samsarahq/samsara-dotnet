using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsFaultCodesValueObdiiConfirmedDtcs
{
    /// <summary>
    /// The DTC description, if available.
    /// </summary>
    [JsonPropertyName("dtcDescription")]
    public string? DtcDescription { get; set; }

    /// <summary>
    /// The DTC identifier.
    /// </summary>
    [JsonPropertyName("dtcId")]
    public required int DtcId { get; set; }

    /// <summary>
    /// The DTC short code, if available.
    /// </summary>
    [JsonPropertyName("dtcShortCode")]
    public string? DtcShortCode { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
