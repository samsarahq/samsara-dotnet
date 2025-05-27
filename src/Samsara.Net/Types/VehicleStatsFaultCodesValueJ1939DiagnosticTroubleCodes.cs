using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Diagnostic trouble code for J1939 vehicles.
/// </summary>
public record VehicleStatsFaultCodesValueJ1939DiagnosticTroubleCodes
{
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
