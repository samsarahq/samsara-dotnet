using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Seatbelt Driver Status as read from the vehicle. `Buckled` or `Unbuckled`.
/// </summary>
[Serializable]
public record VehicleStatsSeatbeltDriver : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// Seatbelt Driver Status as read from the vehicle. `Buckled` or `Unbuckled`.
    /// </summary>
    [JsonPropertyName("value")]
    public required VehicleStatsSeatbeltDriverValue Value { get; set; }

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
