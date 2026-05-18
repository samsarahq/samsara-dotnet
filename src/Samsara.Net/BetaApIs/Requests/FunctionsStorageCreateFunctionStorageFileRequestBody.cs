using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record FunctionsStorageCreateFunctionStorageFileRequestBody
{
    /// <summary>
    /// The name of the file to create.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
