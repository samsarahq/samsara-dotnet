using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record SafetySettingsGetSafetySettingsResponseBody
{
    /// <summary>
    /// Safety settings for a single organization.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<SafetySettingsObjectResponseBody> Data { get; set; } =
        new List<SafetySettingsObjectResponseBody>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
