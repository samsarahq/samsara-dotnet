using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record AlertEventDvirDefectsItem
{
    /// <summary>
    /// ID of the defect
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Creation timestamp
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Type of defect
    /// </summary>
    [JsonPropertyName("defectType")]
    public string? DefectType { get; set; }

    /// <summary>
    /// Defect comment
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
