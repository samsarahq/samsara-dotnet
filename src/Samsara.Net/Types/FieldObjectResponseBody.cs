using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FieldObjectResponseBody
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
    public required FieldObjectResponseBodyType Type { get; set; }

    [JsonPropertyName("value")]
    public required FieldObjectValueResponseBody Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
