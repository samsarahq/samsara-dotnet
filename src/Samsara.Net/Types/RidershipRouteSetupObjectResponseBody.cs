using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A ridership route setup representing planned passenger assignments.
/// </summary>
[Serializable]
public record RidershipRouteSetupObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The Samsara UUID of the ridership account.
    /// </summary>
    [JsonPropertyName("accountId")]
    public required string AccountId { get; set; }

    /// <summary>
    /// List of passenger assignments.
    /// </summary>
    [JsonPropertyName("passengers")]
    public IEnumerable<RidershipRouteSetupPassengerObjectResponseBody> Passengers { get; set; } =
        new List<RidershipRouteSetupPassengerObjectResponseBody>();

    /// <summary>
    /// The route ID.
    /// </summary>
    [JsonPropertyName("routeId")]
    public required string RouteId { get; set; }

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
