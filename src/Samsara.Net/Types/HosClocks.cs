using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Remaining durations and start times (where applicable) for various HOS rules. See [this page](https://www.samsara.com/fleet/eld-compliance/hours-of-service) for more information on HOS rules.
/// </summary>
[Serializable]
public record HosClocks : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("break")]
    public HosBreak? Break { get; set; }

    [JsonPropertyName("cycle")]
    public HosCycle? Cycle { get; set; }

    [JsonPropertyName("drive")]
    public HosDrive? Drive { get; set; }

    [JsonPropertyName("shift")]
    public HosShift? Shift { get; set; }

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
