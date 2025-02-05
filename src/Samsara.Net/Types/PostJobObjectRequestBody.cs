using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record PostJobObjectRequestBody
{
    [JsonPropertyName("address")]
    public PostJobObjectjobLocationRequestObjectRequestBody? Address { get; set; }

    /// <summary>
    /// Customer name for job
    /// </summary>
    [JsonPropertyName("customerName")]
    public string? CustomerName { get; set; }

    /// <summary>
    /// End date of job in RFC 3339 format. Must be greater than or equal to the start date
    /// </summary>
    [JsonPropertyName("endDate")]
    public required string EndDate { get; set; }

    /// <summary>
    /// Fleet devices to be added to this job (cannot have both industrial assets and fleet devices in the same job)
    /// </summary>
    [JsonPropertyName("fleetDeviceIds")]
    public IEnumerable<long>? FleetDeviceIds { get; set; }

    /// <summary>
    /// Job Id
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// IndustrialAssets to be added to this job (cannot have both industrial assets and fleet devices in the same job)
    /// </summary>
    [JsonPropertyName("industrialAssetIds")]
    public IEnumerable<string>? IndustrialAssetIds { get; set; }

    /// <summary>
    /// Job name
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Notes for the upcoming job
    /// </summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>
    /// Specifies the time window (in milliseconds) after a stop's scheduled arrival time during which the stop is considered 'on-time'.
    /// </summary>
    [JsonPropertyName("ontimeWindowAfterArrivalMs")]
    public int? OntimeWindowAfterArrivalMs { get; set; }

    /// <summary>
    /// Specifies the time window (in milliseconds) before a stop's scheduled arrival time during which the stop is considered 'on-time'.
    /// </summary>
    [JsonPropertyName("ontimeWindowBeforeArrivalMs")]
    public int? OntimeWindowBeforeArrivalMs { get; set; }

    /// <summary>
    /// Start date of job in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("startDate")]
    public required string StartDate { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
