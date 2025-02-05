using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record CreateDriverRequestAttributes
{
    /// <summary>
    /// The samsara id of the attribute object.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Name of attribute.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Number values that are associated with this attribute.
    /// </summary>
    [JsonPropertyName("numberValues")]
    public IEnumerable<double>? NumberValues { get; set; }

    /// <summary>
    /// String values that are associated with this attribute.
    /// </summary>
    [JsonPropertyName("stringValues")]
    public IEnumerable<string>? StringValues { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
