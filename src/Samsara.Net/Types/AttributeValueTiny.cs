using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record AttributeValueTiny
{
    /// <summary>
    /// The samsara id of this value object.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The human-readable string for this value.
    /// </summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
