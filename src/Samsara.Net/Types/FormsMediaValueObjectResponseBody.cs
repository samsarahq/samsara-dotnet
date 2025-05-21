using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The value of a media form input field.
/// </summary>
public record FormsMediaValueObjectResponseBody
{
    /// <summary>
    /// List of forms media record objects.
    /// </summary>
    [JsonPropertyName("mediaList")]
    public IEnumerable<FormsMediaRecordObjectResponseBody> MediaList { get; set; } =
        new List<FormsMediaRecordObjectResponseBody>();

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
