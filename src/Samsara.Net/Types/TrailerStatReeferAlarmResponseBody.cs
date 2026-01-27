using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record TrailerStatReeferAlarmResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The ID of the alarm.
    /// </summary>
    [JsonPropertyName("alarmCode")]
    public required string AlarmCode { get; set; }

    /// <summary>
    /// The description of the alarm.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; set; }

    /// <summary>
    /// The recommended operator action.
    /// </summary>
    [JsonPropertyName("operatorAction")]
    public required string OperatorAction { get; set; }

    /// <summary>
    /// The severity of the alarm. `1`: Ok to run, `2`: Check as specified, `3`: Take immediate action.
    /// </summary>
    [JsonPropertyName("severity")]
    public required long Severity { get; set; }

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
