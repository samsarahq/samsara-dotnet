using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Diagnostic trouble code for J1939 vehicles.
/// </summary>
[Serializable]
public record VehicleStatsFaultCodesValueJ1939DiagnosticTroubleCodes : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A short description of the FMI identifier, if available.
    /// </summary>
    [JsonPropertyName("fmiDescription")]
    public string? FmiDescription { get; set; }

    /// <summary>
    /// The FMI identifier.
    /// </summary>
    [JsonPropertyName("fmiId")]
    public required int FmiId { get; set; }

    /// <summary>
    /// The MIL status, indicating a check engine light.
    /// </summary>
    [JsonPropertyName("milStatus")]
    public required int MilStatus { get; set; }

    /// <summary>
    /// The number of times this fault has triggered.
    /// </summary>
    [JsonPropertyName("occurrenceCount")]
    public required int OccurrenceCount { get; set; }

    /// <summary>
    /// The source address name corresponding to the txId
    /// </summary>
    [JsonPropertyName("sourceAddressName")]
    public string? SourceAddressName { get; set; }

    /// <summary>
    /// A short description of the SPN identifier, if available.
    /// </summary>
    [JsonPropertyName("spnDescription")]
    public string? SpnDescription { get; set; }

    /// <summary>
    /// The SPN identifier.
    /// </summary>
    [JsonPropertyName("spnId")]
    public required int SpnId { get; set; }

    /// <summary>
    /// The TX identifier.
    /// </summary>
    [JsonPropertyName("txId")]
    public required int TxId { get; set; }

    [JsonPropertyName("vendorSpecificFields")]
    public VehicleStatsFaultCodesValueJ1939VendorSpecificFields? VendorSpecificFields { get; set; }

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
