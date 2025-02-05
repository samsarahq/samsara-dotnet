using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record UpdateDriverRequestHosSetting
{
    [JsonPropertyName("heavyHaulExemptionToggleEnabled")]
    public bool? HeavyHaulExemptionToggleEnabled { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
