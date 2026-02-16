using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApis;

[Serializable]
public record ReadingsPostReadingsRequestBody
{
    /// <summary>
    /// An array of readings data points to create.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<ReadingDatapointRequestBody> Data { get; set; } =
        new List<ReadingDatapointRequestBody>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
