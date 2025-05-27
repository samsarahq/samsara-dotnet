using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Passenger vehicle DTC information
/// </summary>
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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
