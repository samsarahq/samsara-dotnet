using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record GetFunctionRunRequest
{
    /// <summary>
    /// The name of the Function.
    /// </summary>
    [JsonIgnore]
    public required string Name { get; set; }

    /// <summary>
    /// The unique correlationId of the Function run, returned by the start run endpoint.
    /// </summary>
    [JsonIgnore]
    public required string CorrelationId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
