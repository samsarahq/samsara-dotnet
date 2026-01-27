using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record V1VehicleMaintenanceJ1939DiagnosticTroubleCodes : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("fmiId")]
    public required long FmiId { get; set; }

    [JsonPropertyName("fmiText")]
    public required string FmiText { get; set; }

    [JsonPropertyName("occurrenceCount")]
    public required long OccurrenceCount { get; set; }

    [JsonPropertyName("spnDescription")]
    public required string SpnDescription { get; set; }

    [JsonPropertyName("spnId")]
    public required long SpnId { get; set; }

    [JsonPropertyName("txId")]
    public required long TxId { get; set; }

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
