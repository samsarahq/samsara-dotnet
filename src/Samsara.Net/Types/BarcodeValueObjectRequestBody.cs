using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record BarcodeValueObjectRequestBody
{
    /// <summary>
    /// The barcode type that was scanned.
    /// </summary>
    [JsonPropertyName("barcodeType")]
    public string? BarcodeType { get; set; }

    /// <summary>
    /// The captured barcode value.
    /// </summary>
    [JsonPropertyName("barcodeValue")]
    public string? BarcodeValue { get; set; }

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
