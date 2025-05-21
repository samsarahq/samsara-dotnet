using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Job object with fields to update. If a field is not provided, it will not be updated
/// </summary>
public record PatchJobObjectRequestBody
{
    [JsonPropertyName("address")]
    public PatchJobObjectjobLocationRequestObjectRequestBody? Address { get; set; }

    /// <summary>
    /// Customer name for job
    /// </summary>
    [JsonPropertyName("customerName")]
    public string? CustomerName { get; set; }

    /// <summary>
    /// End date of job in RFC 3339 format. Must be greater than or equal to the start date
    /// </summary>
    [JsonPropertyName("endDate")]
    public string? EndDate { get; set; }

    /// <summary>
    /// Fleet devices to be added to this job (cannot have both industrial assets and fleet devices in the same job)
    /// </summary>
    [JsonPropertyName("fleetDeviceIds")]
    public IEnumerable<long>? FleetDeviceIds { get; set; }

    /// <summary>
    /// Job Id
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// IndustrialAssets to be added to this job (cannot have both industrial assets and fleet devices in the same job)
    /// </summary>
    [JsonPropertyName("industrialAssetIds")]
    public IEnumerable<string>? IndustrialAssetIds { get; set; }

    /// <summary>
    /// Job name
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

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
    public string? StartDate { get; set; }

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
