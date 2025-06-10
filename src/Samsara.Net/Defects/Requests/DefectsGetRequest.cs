using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Defects;

public record DefectsGetRequest
{
    /// <summary>
    /// Optional boolean indicating whether to return external IDs on supported entities
    /// </summary>
    [JsonIgnore]
    public bool? IncludeExternalIds { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
