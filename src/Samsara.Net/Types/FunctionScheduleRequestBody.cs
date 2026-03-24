using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Schedule configuration for a Function.
/// </summary>
[Serializable]
public record FunctionScheduleRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Schedule entries defining when the function runs.
    /// </summary>
    [JsonPropertyName("entries")]
    public IEnumerable<FunctionScheduleEntryRequestBody> Entries { get; set; } =
        new List<FunctionScheduleEntryRequestBody>();

    /// <summary>
    /// IANA timezone name for the schedule.
    /// </summary>
    [JsonPropertyName("timezone")]
    public required string Timezone { get; set; }

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
