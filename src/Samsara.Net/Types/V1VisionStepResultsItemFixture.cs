using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1VisionStepResultsItemFixture
{
    [JsonPropertyName("coordinates")]
    public V1VisionStepResultsItemFixtureCoordinates? Coordinates { get; set; }

    [JsonPropertyName("found")]
    public bool? Found { get; set; }

    [JsonPropertyName("rotationDegrees")]
    public long? RotationDegrees { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
