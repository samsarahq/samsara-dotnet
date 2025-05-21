using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FieldObjectPostRequestBody
{
    /// <summary>
    /// The name of the field.
    /// </summary>
    [JsonPropertyName("label")]
    public required string Label { get; set; }

    /// <summary>
    /// The type of field.  Valid values: `photo`, `string`, `number`, `multipleChoice`, `signature`, `dateTime`, `scannedDocument`, `barcode`
    /// </summary>
    [JsonPropertyName("type")]
    public required FieldObjectPostRequestBodyType Type { get; set; }

    [JsonPropertyName("value")]
    public FieldObjectValueRequestBody? Value { get; set; }

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
