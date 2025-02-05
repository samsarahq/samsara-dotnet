using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record ActionObjectRequestBody
{
    [JsonPropertyName("actionParams")]
    public ActionParamsObjectRequestBody? ActionParams { get; set; }

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
