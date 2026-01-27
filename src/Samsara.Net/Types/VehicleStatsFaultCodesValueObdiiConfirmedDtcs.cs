using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Passenger vehicle DTC information
/// </summary>
[Serializable]
public record VehicleStatsFaultCodesValueObdiiConfirmedDtcs : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The DTC description, if available.
    /// </summary>
    [JsonPropertyName("dtcDescription")]
    public string? DtcDescription { get; set; }

    /// <summary>
    /// The DTC identifier.
    /// </summary>
    [JsonPropertyName("dtcId")]
    public required int DtcId { get; set; }

    /// <summary>
    /// The DTC short code, if available.
    /// </summary>
    [JsonPropertyName("dtcShortCode")]
    public string? DtcShortCode { get; set; }

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
