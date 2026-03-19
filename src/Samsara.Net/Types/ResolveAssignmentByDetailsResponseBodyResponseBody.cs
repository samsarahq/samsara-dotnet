using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Response body containing the resolved driver information.
/// </summary>
[Serializable]
public record ResolveAssignmentByDetailsResponseBodyResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The resolved Samsara driver ID.
    /// </summary>
    [JsonPropertyName("driverId")]
    public required string DriverId { get; set; }

    /// <summary>
    /// The matched driver name.
    /// </summary>
    [JsonPropertyName("driverName")]
    public required string DriverName { get; set; }

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
