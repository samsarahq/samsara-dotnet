using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Action to take.
/// </summary>
public record ActionObjectResponseBody
{
    [JsonPropertyName("actionParams")]
    public ActionParamsObjectResponseBody? ActionParams { get; set; }

    /// <summary>
    /// The id of the of the action type. Reference the following list for the ids:
    /// The following action types are in Beta:
    /// Driver App Push = 5
    /// The following action types are Stable:
    /// Notification (Email, Text, Samsara Fleet Push) = 1
    /// Dashboard Notification = 3
    /// Webhook = 4
    /// Slack = 6
    /// </summary>
    [JsonPropertyName("actionTypeId")]
    public required int ActionTypeId { get; set; }

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
