using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1VisionStepResultsItemCaliperAngleRange
{
    [JsonPropertyName("high")]
    public int? High { get; set; }

    [JsonPropertyName("low")]
    public int? Low { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
