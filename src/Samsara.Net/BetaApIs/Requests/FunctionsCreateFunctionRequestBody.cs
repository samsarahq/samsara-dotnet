using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record FunctionsCreateFunctionRequestBody
{
    [JsonPropertyName("config")]
    public required CreateFunctionRequestConfigRequestBody Config { get; set; }

    /// <summary>
    /// A description of the Function.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Unique name for the Function.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
