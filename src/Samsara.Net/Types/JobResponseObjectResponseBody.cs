using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Job object to be passed back
/// </summary>
public record JobResponseObjectResponseBody
{
    [JsonPropertyName("address")]
    public required JobLocationResponseObjectResponseBody Address { get; set; }

    /// <summary>
    /// When the job was created
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required string CreatedAt { get; set; }

    /// <summary>
    /// Customer name for job
    /// </summary>
    [JsonPropertyName("customerName")]
    public required string CustomerName { get; set; }

    /// <summary>
    /// End date of job in RFC 3339 format
    /// </summary>
    [JsonPropertyName("endDate")]
    public required string EndDate { get; set; }

    /// <summary>
    /// fleet devices in this job (cannot have both industrial assets and fleet devices in the same job)
    /// </summary>
    [JsonPropertyName("fleetDevices")]
    public IEnumerable<FleetDeviceObjectResponseBody>? FleetDevices { get; set; }

    /// <summary>
    /// Job id
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Industrial Assets in this job (cannot have both industrial assets and fleet devices in the same job)
    /// </summary>
    [JsonPropertyName("industrialAssets")]
    public IEnumerable<IndustrialAssetObjectResponseBody>? IndustrialAssets { get; set; }

    /// <summary>
    /// When the job was last modified
    /// </summary>
    [JsonPropertyName("modifiedAt")]
    public required string ModifiedAt { get; set; }

    /// <summary>
    /// Job name
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Notes for the upcoming job
    /// </summary>
    [JsonPropertyName("notes")]
    public required string Notes { get; set; }

    /// <summary>
    /// Specifies the time window (in milliseconds) after a stop's scheduled arrival time during which the stop is considered 'on-time'.
    /// </summary>
    [JsonPropertyName("ontimeWindowAfterArrivalMs")]
    public long? OntimeWindowAfterArrivalMs { get; set; }

    /// <summary>
    /// Specifies the time window (in milliseconds) before a stop's scheduled arrival time during which the stop is considered 'on-time'.
    /// </summary>
    [JsonPropertyName("ontimeWindowBeforeArrivalMs")]
    public long? OntimeWindowBeforeArrivalMs { get; set; }

    /// <summary>
    /// Start date of job in RFC 3339 format
    /// </summary>
    [JsonPropertyName("startDate")]
    public required string StartDate { get; set; }

    /// <summary>
    /// The current job status  Valid values: `active`, `scheduled`, `completed`
    /// </summary>
    [JsonPropertyName("status")]
    public required JobResponseObjectResponseBodyStatus Status { get; set; }

    /// <summary>
    /// Samsara uuid
    /// </summary>
    [JsonPropertyName("uuid")]
    public required string Uuid { get; set; }

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
