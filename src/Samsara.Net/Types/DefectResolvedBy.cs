using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DefectResolvedBy
{
    /// <summary>
    /// ID of the entity that resolved this defect. If the defect was resolved by a driver, this will be a Samsara Driver ID. If the defect was resolved by a mechanic, this will be the Samsara Dashboard User ID of the mechanic.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Name of the person who resolved this defect.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Indicates whether this defect was resolved by a `driver` or a `mechanic`.
    /// </summary>
    [JsonPropertyName("type")]
    public DefectResolvedByType? Type { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
