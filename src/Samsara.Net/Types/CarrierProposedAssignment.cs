using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A carrier proposed assignment object
/// </summary>
[Serializable]
public record CarrierProposedAssignment : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
