using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApis;

[Serializable]
public record FunctionsStartFunctionRunRequestBody
{
    /// <summary>
    /// Parameter overrides for the Function execution. Can be an empty object but must be provided.
    /// </summary>
    [JsonPropertyName("paramsOverride")]
    public required FunctionsStartFunctionRunRequestBodyParamsOverride ParamsOverride { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
