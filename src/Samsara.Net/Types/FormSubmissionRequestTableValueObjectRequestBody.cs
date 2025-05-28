using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The value of a table form input field. Only valid for table form input fields.
/// </summary>
public record FormSubmissionRequestTableValueObjectRequestBody
{
    /// <summary>
    /// List of rows in the table.
    /// </summary>
    [JsonPropertyName("rows")]
    public IEnumerable<FormSubmissionRequestTableRowObjectRequestBody> Rows { get; set; } =
        new List<FormSubmissionRequestTableRowObjectRequestBody>();

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
