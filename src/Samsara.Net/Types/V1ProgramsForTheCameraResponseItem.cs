using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1ProgramsForTheCameraResponseItem
{
    [JsonPropertyName("programId")]
    public long? ProgramId { get; set; }

    [JsonPropertyName("programName")]
    public string? ProgramName { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
