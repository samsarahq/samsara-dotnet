using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Configuration for the new Function.
/// </summary>
[Serializable]
public record CreateFunctionRequestConfigRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The handler entrypoint for the function code (e.g. 'index.handler').
    /// </summary>
    [JsonPropertyName("handler")]
    public required string Handler { get; set; }

    /// <summary>
    /// Whether the run schedule is enabled.
    /// </summary>
    [JsonPropertyName("isScheduleEnabled")]
    public bool? IsScheduleEnabled { get; set; }

    /// <summary>
    /// Default parameter values for the function.
    /// </summary>
    [JsonPropertyName("params")]
    public CreateFunctionRequestConfigRequestBodyParams? Params { get; set; }

    [JsonPropertyName("schedule")]
    public FunctionScheduleRequestBody? Schedule { get; set; }

    /// <summary>
    /// Secrets available to the function at runtime.
    /// </summary>
    [JsonPropertyName("secrets")]
    public CreateFunctionRequestConfigRequestBodySecrets? Secrets { get; set; }

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
