using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record HosDailyLogsUpdateShippingDocsRequestBody
{
    /// <summary>
    /// A start date in yyyy-mm-dd format. Required.
    /// </summary>
    [JsonIgnore]
    public required string HosDate { get; set; }

    /// <summary>
    /// ID of the driver for whom the duty status is being set.
    /// </summary>
    [JsonIgnore]
    public required string DriverId { get; set; }

    /// <summary>
    /// ShippingDocs associated with the driver for the day.
    /// </summary>
    [JsonPropertyName("shippingDocs")]
    public required string ShippingDocs { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
