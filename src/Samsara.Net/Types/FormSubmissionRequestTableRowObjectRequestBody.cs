using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The value of a row in a table form input field.
/// </summary>
public record FormSubmissionRequestTableRowObjectRequestBody
{
    /// <summary>
    /// List of cells in the row.
    /// </summary>
    [JsonPropertyName("cells")]
    public IEnumerable<FormSubmissionRequestTableCellObjectRequestBody> Cells { get; set; } =
        new List<FormSubmissionRequestTableCellObjectRequestBody>();

    /// <summary>
    /// Unique identifier for the row.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

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
