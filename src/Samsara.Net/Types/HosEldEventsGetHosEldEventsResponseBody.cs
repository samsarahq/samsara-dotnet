using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record HosEldEventsGetHosEldEventsResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// List of drivers and their ELD event objects data.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<HosDriversEldEventObjectResponseBody> Data { get; set; } =
        new List<HosDriversEldEventObjectResponseBody>();

    [JsonPropertyName("pagination")]
    public GoaPaginationResponseResponseBody? Pagination { get; set; }

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
