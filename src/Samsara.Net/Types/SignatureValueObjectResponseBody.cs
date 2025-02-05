using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record SignatureValueObjectResponseBody
{
    /// <summary>
    /// Id of the signature field.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Name of the signee for a signature field.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Time the signature was captured in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("signedAtTime")]
    public DateTime? SignedAtTime { get; set; }

    /// <summary>
    /// Url of a signature field's PNG signature image.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
