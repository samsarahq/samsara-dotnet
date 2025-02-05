using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record SettingsPatchComplianceSettingsResponseBody
{
    [JsonPropertyName("data")]
    public required SettingsComplianceResponseObjectResponseBody Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
