using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record EngineImmobilizerGetEngineImmobilizerStatesResponseBody
{
    /// <summary>
    /// A list of engine immobilizer states in ascending order of happenedAtTime.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<EngineImmobilizerStateResponseBody> Data { get; set; } =
        new List<EngineImmobilizerStateResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
