using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Form Template approval configuration object.
/// </summary>
public record FormsApprovalConfigObjectResponseBody
{
    [JsonPropertyName("singleApprovalConfig")]
    public FormsSingleApprovalConfigObjectResponseBody? SingleApprovalConfig { get; set; }

    /// <summary>
    /// Type of approval.  Valid values: `singleApproval`
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "singleApproval";

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
