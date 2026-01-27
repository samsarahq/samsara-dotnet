using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record HosEldEventRemarkObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
