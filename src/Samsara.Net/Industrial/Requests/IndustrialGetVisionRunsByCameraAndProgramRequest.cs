using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Industrial;

public record IndustrialGetVisionRunsByCameraAndProgramRequest
{
    /// <summary>
    /// Include is a filter parameter. Accepts 'pass', 'reject' or 'no_read'.
    /// </summary>
    [JsonIgnore]
    public string? Include { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
