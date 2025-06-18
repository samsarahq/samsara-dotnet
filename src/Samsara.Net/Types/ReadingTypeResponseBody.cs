using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Type information for the reading.
/// </summary>
public record ReadingTypeResponseBody
{
    /// <summary>
    /// The data type of the reading.  Valid values: `integer`, `float`, `string`
    /// </summary>
    [JsonPropertyName("dataType")]
    public required ReadingTypeResponseBodyDataType DataType { get; set; }

    [JsonPropertyName("unit")]
    public UnitResponseBody? Unit { get; set; }

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
