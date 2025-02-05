using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1DocumentFieldsItemSignatureValue
{
    /// <summary>
    /// Name of the signee for a signature field
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Date time value in milliseconds of the time a signature was captured.
    /// </summary>
    [JsonPropertyName("signedAtMs")]
    public double? SignedAtMs { get; set; }

    /// <summary>
    /// Url of a signature field's PNG signature image.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// Uuid of a signature field
    /// </summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
