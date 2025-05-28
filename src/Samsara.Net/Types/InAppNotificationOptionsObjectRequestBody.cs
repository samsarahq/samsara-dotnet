using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Options for in-app notifications
/// </summary>
public record InAppNotificationOptionsObjectRequestBody
{
    /// <summary>
    /// Whether the alert will dictate the title of the alert. Both canDictateAlertTitle and canPlayAlertSound should be enabled or disabled together.
    /// </summary>
    [JsonPropertyName("canDictateAlertTitle")]
    public bool? CanDictateAlertTitle { get; set; }

    /// <summary>
    /// Whether the alert will play a sound. Both canDictateAlertTitle and canPlayAlertSound should be enabled or disabled together.
    /// </summary>
    [JsonPropertyName("canPlayAlertSound")]
    public bool? CanPlayAlertSound { get; set; }

    /// <summary>
    /// Custom text to display in the notification (320 character max).
    /// </summary>
    [JsonPropertyName("customText")]
    public string? CustomText { get; set; }

    /// <summary>
    /// Whether in-app notifications are enabled.
    /// </summary>
    [JsonPropertyName("isEnabled")]
    public required bool IsEnabled { get; set; }

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
