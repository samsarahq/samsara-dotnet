using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Order task
/// </summary>
[Serializable]
public record OrderTaskResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The full address string for the order
    /// </summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    [JsonPropertyName("appointmentWindow")]
    public AppointmentWindowResponseBody? AppointmentWindow { get; set; }

    /// <summary>
    /// The customer-provided identifier of the location associated with the order
    /// </summary>
    [JsonPropertyName("customerLocationId")]
    public string? CustomerLocationId { get; set; }

    /// <summary>
    /// Latitude of the order. Optional if address is provided; the address will be geocoded to obtain coordinates.
    /// </summary>
    [JsonPropertyName("latitude")]
    public double? Latitude { get; set; }

    /// <summary>
    /// Longitude of the order. Optional if address is provided; the address will be geocoded to obtain coordinates.
    /// </summary>
    [JsonPropertyName("longitude")]
    public double? Longitude { get; set; }

    /// <summary>
    /// Any additional notes for the order
    /// </summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>
    /// Position constraint for the order task  Valid values: `first`, `last`, `any`
    /// </summary>
    [JsonPropertyName("position")]
    public OrderTaskResponseBodyPosition? Position { get; set; }

    /// <summary>
    /// Estimated service time for the order in seconds
    /// </summary>
    [JsonPropertyName("serviceTimeSeconds")]
    public int? ServiceTimeSeconds { get; set; }

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
