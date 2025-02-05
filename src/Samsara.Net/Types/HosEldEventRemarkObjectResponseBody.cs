using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record HosEldEventRemarkObjectResponseBody
{
    /// <summary>
    /// The content of the remark.
    /// </summary>
    [JsonPropertyName("comment")]
    public required string Comment { get; set; }

    /// <summary>
    /// The location description entered by the user
    /// </summary>
    [JsonPropertyName("locationDescription")]
    public required string LocationDescription { get; set; }

    /// <summary>
    /// The time in RFC 3339 format at which the remark was created.
    /// </summary>
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
