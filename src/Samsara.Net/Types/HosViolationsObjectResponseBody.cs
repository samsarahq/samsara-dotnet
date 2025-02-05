using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record HosViolationsObjectResponseBody
{
    /// <summary>
    /// List of violations and their associated drivers
    /// </summary>
    [JsonPropertyName("violations")]
    public IEnumerable<HosViolationObjectResponseBody> Violations { get; set; } =
        new List<HosViolationObjectResponseBody>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
