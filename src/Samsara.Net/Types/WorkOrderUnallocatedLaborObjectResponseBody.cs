using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Unallocated labor from time entries not associated with any service task.
/// </summary>
[Serializable]
public record WorkOrderUnallocatedLaborObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("cost")]
    public required WorkOrderMoneyObjectResponseBody Cost { get; set; }

    /// <summary>
    /// The total unallocated labor time in minutes.
    /// </summary>
    [JsonPropertyName("timeMinutes")]
    public required long TimeMinutes { get; set; }

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
