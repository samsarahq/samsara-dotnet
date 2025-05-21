using System.Text.Json;
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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
