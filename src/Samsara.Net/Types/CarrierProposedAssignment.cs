using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A carrier proposed assignment object
/// </summary>
public record CarrierProposedAssignment
{
    [JsonPropertyName("acceptedTime")]
    public string? AcceptedTime { get; set; }

    [JsonPropertyName("activeTime")]
    public required string ActiveTime { get; set; }

    [JsonPropertyName("driver")]
    public CarrierProposedAssignmentDriver? Driver { get; set; }

    [JsonPropertyName("firstSeenTime")]
    public string? FirstSeenTime { get; set; }

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("rejectedTime")]
    public string? RejectedTime { get; set; }

    [JsonPropertyName("shippingDocs")]
    public string? ShippingDocs { get; set; }

    [JsonPropertyName("trailers")]
    public IEnumerable<CarrierProposedAssignmentTrailer>? Trailers { get; set; }

    [JsonPropertyName("vehicle")]
    public CarrierProposedAssignmentVehicle? Vehicle { get; set; }

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
