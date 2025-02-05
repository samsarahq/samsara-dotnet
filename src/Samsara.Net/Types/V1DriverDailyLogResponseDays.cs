using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1DriverDailyLogResponseDays
{
    /// <summary>
    /// Hours spent on duty or driving, rounded to two decimal places.
    /// </summary>
    [JsonPropertyName("activeHours")]
    public double? ActiveHours { get; set; }

    /// <summary>
    /// Milliseconds spent on duty or driving.
    /// </summary>
    [JsonPropertyName("activeMs")]
    public long? ActiveMs { get; set; }

    /// <summary>
    /// Whether this HOS day chart was certified by the driver.
    /// </summary>
    [JsonPropertyName("certified")]
    public bool? Certified { get; set; }

    /// <summary>
    /// Unix epoch time (in ms) of time when this chart was certified. If this chart is uncertified, 0.
    /// </summary>
    [JsonPropertyName("certifiedAtMs")]
    public long? CertifiedAtMs { get; set; }

    /// <summary>
    /// Distance driven in miles, rounded to two decimal places.
    /// </summary>
    [JsonPropertyName("distanceMiles")]
    public double? DistanceMiles { get; set; }

    /// <summary>
    /// End of the HOS day, specified in milliseconds UNIX time.
    /// </summary>
    [JsonPropertyName("endMs")]
    public int? EndMs { get; set; }

    /// <summary>
    /// List of customer shipping document IDs associated with the driver for the day.
    /// </summary>
    [JsonPropertyName("shippingDocIds")]
    public IEnumerable<string>? ShippingDocIds { get; set; }

    /// <summary>
    /// Start of the HOS day, specified in milliseconds UNIX time.
    /// </summary>
    [JsonPropertyName("startMs")]
    public int? StartMs { get; set; }

    /// <summary>
    /// List of trailer ID's associated with the driver for the day.
    /// </summary>
    [JsonPropertyName("trailerIds")]
    public IEnumerable<string>? TrailerIds { get; set; }

    /// <summary>
    /// List of vehicle ID's associated with the driver for the day.
    /// </summary>
    [JsonPropertyName("vehicleIds")]
    public V1DriverDailyLogResponseDaysVehicleIds? VehicleIds { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
