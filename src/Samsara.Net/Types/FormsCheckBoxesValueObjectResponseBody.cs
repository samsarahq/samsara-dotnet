using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The value of a check boxes form input field.
/// </summary>
public record FormsCheckBoxesValueObjectResponseBody
{
    /// <summary>
    /// List of selected options.
    /// </summary>
    [JsonPropertyName("value")]
    public IEnumerable<string> Value { get; set; } = new List<string>();

    /// <summary>
    /// List of selected option IDs.
    /// </summary>
    [JsonPropertyName("valueIds")]
    public IEnumerable<string> ValueIds { get; set; } = new List<string>();

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
