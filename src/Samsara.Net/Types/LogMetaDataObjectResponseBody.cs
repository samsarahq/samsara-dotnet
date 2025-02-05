using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record LogMetaDataObjectResponseBody
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
    /// The time this log was certified in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("certifiedAtTime")]
    public string? CertifiedAtTime { get; set; }

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
    /// List of shipping document names associated with the driver for the day. This field maps to Shipping ID in the dashboard.
    /// </summary>
    [JsonPropertyName("shippingDocs")]
    public string? ShippingDocs { get; set; }

    /// <summary>
    /// List of trailer names associated with the driver for the day. If a trailer was associated with a log through the driver app the trailer name will be the trailer ID.
    /// </summary>
    [JsonPropertyName("trailerNames")]
    public IEnumerable<string>? TrailerNames { get; set; }

    /// <summary>
    /// List of vehicles associated with the driver for the day.
    /// </summary>
    [JsonPropertyName("vehicles")]
    public IEnumerable<VehicleResponseResponseBody>? Vehicles { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
