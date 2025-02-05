using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record IftaJurisdictionSummaryObjectResponseBody
{
    /// <summary>
    /// Jurisdiction code.
    /// </summary>
    [JsonPropertyName("jurisdiction")]
    public required string Jurisdiction { get; set; }

    /// <summary>
    /// Liters purchased for all qualified vehicles.
    /// </summary>
    [JsonPropertyName("taxPaidLiters")]
    public double? TaxPaidLiters { get; set; }

    /// <summary>
    /// Distance in meters traveled on public roads in an IFTA jurisdiction.
    /// </summary>
    [JsonPropertyName("taxableMeters")]
    public required double TaxableMeters { get; set; }

    /// <summary>
    /// Total meters driven in this jurisdiction, taxable and non-taxable.
    /// </summary>
    [JsonPropertyName("totalMeters")]
    public required double TotalMeters { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
