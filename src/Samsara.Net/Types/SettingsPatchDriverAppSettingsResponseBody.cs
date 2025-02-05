using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record SettingsPatchDriverAppSettingsResponseBody
{
    [JsonPropertyName("data")]
    public required DriverAppSettingsResponseObjectResponseBody Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
