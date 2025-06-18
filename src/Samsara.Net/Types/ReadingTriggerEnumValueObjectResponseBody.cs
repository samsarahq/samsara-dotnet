using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Enum value to alert on if reading is discrete, either enum or continuous threshold may be set.
/// </summary>
public record ReadingTriggerEnumValueObjectResponseBody
{
    /// <summary>
    /// The numeric representation of the enum value.
    /// </summary>
    [JsonPropertyName("number")]
    public long? Number { get; set; }

    /// <summary>
    /// The symbol representation of the enum value.
    /// </summary>
    [JsonPropertyName("symbol")]
    public string? Symbol { get; set; }

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
