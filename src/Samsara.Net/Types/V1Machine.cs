using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1Machine
{
    /// <summary>
    /// ID of the machine.
    /// </summary>
    [JsonPropertyName("id")]
    public required long Id { get; set; }

    /// <summary>
    /// Name of the machine.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Notes about the machine
    /// </summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
