using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A summary of this jurisdiction's IFTA data.
/// </summary>
[Serializable]
public record IftaJurisdictionSummaryObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
