using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record GetFunctionStorageFileRequest
{
    /// <summary>
    /// The name of the file.
    /// </summary>
    [JsonIgnore]
    public required string Name { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
