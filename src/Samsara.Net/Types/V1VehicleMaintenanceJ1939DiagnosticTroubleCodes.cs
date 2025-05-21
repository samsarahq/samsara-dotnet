using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1VehicleMaintenanceJ1939DiagnosticTroubleCodes
{
    [JsonPropertyName("fmiId")]
    public required int FmiId { get; set; }

    [JsonPropertyName("fmiText")]
    public required string FmiText { get; set; }

    [JsonPropertyName("occurrenceCount")]
    public required int OccurrenceCount { get; set; }

    [JsonPropertyName("spnDescription")]
    public required string SpnDescription { get; set; }

    [JsonPropertyName("spnId")]
    public required int SpnId { get; set; }

    [JsonPropertyName("txId")]
    public required int TxId { get; set; }

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
