using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Configuration of the Function.
/// </summary>
[Serializable]
public record FunctionConfigResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The handler entrypoint for the function code.
    /// </summary>
    [JsonPropertyName("handler")]
    public required string Handler { get; set; }

    /// <summary>
    /// Whether the run schedule is enabled.
    /// </summary>
    [JsonPropertyName("isScheduleEnabled")]
    public required bool IsScheduleEnabled { get; set; }

    /// <summary>
    /// Default parameters for the function.
    /// </summary>
    [JsonPropertyName("params")]
    public required FunctionConfigResponseBodyParams Params { get; set; }

    [JsonPropertyName("schedule")]
    public FunctionScheduleResponseBody? Schedule { get; set; }

    /// <summary>
    /// Secret names available to the function. Values are always empty.
    /// </summary>
    [JsonPropertyName("secrets")]
    public required FunctionConfigResponseBodySecrets Secrets { get; set; }

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
