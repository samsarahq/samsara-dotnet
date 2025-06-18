using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Single approval configuration object.
/// </summary>
public record FormsSingleApprovalConfigObjectResponseBody
{
    /// <summary>
    /// Indicates whether approver can be manually selected. True by default.
    /// </summary>
    [JsonPropertyName("allowManualApproverSelection")]
    public required bool AllowManualApproverSelection { get; set; }

    [JsonPropertyName("requirements")]
    public required SingleApprovalRequirementsObjectResponseBody Requirements { get; set; }

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
