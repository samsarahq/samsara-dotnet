using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Response after successfully updating the LogMetaData object.
/// </summary>
public record PatchShippingDocsResponseBodyResponseBody
{
    /// <summary>
    /// Whether the driver has claimed the [Adverse Driving Exemption](https://kb.samsara.com/hc/en-us/articles/360047336792-Adverse-Driving-Exemption) for this HOS day chart.
    /// </summary>
    [JsonPropertyName("adverseDrivingClaimed")]
    public bool? AdverseDrivingClaimed { get; set; }

    /// <summary>
    /// Whether the driver has claimed the [Big Day Exemption](https://kb.samsara.com/hc/en-us/articles/360057113891-16-Hour-Short-Haul-Exemption-Big-Day-) for this HOS day chart.
    /// </summary>
    [JsonPropertyName("bigDayClaimed")]
    public bool? BigDayClaimed { get; set; }

    /// <summary>
    /// The address of the carrier used for this HOS chart.
    /// </summary>
    [JsonPropertyName("carrierFormattedAddress")]
    public string? CarrierFormattedAddress { get; set; }

    /// <summary>
    /// The name of the carrier used for this HOS chart.
    /// </summary>
    [JsonPropertyName("carrierName")]
    public string? CarrierName { get; set; }

    /// <summary>
    /// The US DOT number of the carrier used for this HOS chart.
    /// </summary>
    [JsonPropertyName("carrierUsDotNumber")]
    public long? CarrierUsDotNumber { get; set; }

    /// <summary>
    /// The address of the Home Terminal used for this HOS chart.
    /// </summary>
    [JsonPropertyName("homeTerminalFormattedAddress")]
    public string? HomeTerminalFormattedAddress { get; set; }

    /// <summary>
    /// The name of the Home Terminal used for this HOS chart.
    /// </summary>
    [JsonPropertyName("homeTerminalName")]
    public string? HomeTerminalName { get; set; }

    /// <summary>
    /// Whether this HOS day chart was certified by the driver.
    /// </summary>
    [JsonPropertyName("isCertified")]
    public bool? IsCertified { get; set; }

    /// <summary>
    /// Whether the driver has the 150 air-mile Short Haul Exemption active for this HOS day chart.
    /// </summary>
    [JsonPropertyName("isUsShortHaulActive")]
    public bool? IsUsShortHaulActive { get; set; }

    /// <summary>
    /// List of trailer names associated with the driver for the day. If a trailer was associated with a log through the driver app, the trailer name will be the trailer ID.
    /// </summary>
    [JsonPropertyName("trailerNames")]
    public IEnumerable<string>? TrailerNames { get; set; }

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
