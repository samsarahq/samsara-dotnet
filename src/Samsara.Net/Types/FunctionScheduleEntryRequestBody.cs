using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A single schedule entry defining when a Function runs.
/// </summary>
[Serializable]
public record FunctionScheduleEntryRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Days of the week this entry applies to (7 elements, index 0 = Sunday).
    /// </summary>
    [JsonPropertyName("daysOfWeek")]
    public IEnumerable<bool> DaysOfWeek { get; set; } = new List<bool>();

    /// <summary>
    /// Time since midnight in milliseconds when the function runs.
    /// </summary>
    [JsonPropertyName("timeSinceMidnightMs")]
    public required long TimeSinceMidnightMs { get; set; }

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
