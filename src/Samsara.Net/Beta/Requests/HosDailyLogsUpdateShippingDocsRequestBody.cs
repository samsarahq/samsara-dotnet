using Samsara.Net.Core;

namespace Samsara.Net.Beta;

public record HosDailyLogsUpdateShippingDocsRequestBody
{
    /// <summary>
    /// A start date in yyyy-mm-dd format. Required.
    /// </summary>
    public required string HosDate { get; set; }

    /// <summary>
    /// ID of the driver for whom the duty status is being set.
    /// </summary>
    public required string DriverId { get; set; }

    /// <summary>
    /// ShippingDocs associated with the driver for the day.
    /// </summary>
    public required string ShippingDocs { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
