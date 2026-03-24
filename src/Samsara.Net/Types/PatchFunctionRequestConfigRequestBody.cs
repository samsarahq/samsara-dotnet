using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Configuration fields to update on the Function. All fields are optional; only provided fields are updated.
/// </summary>
[Serializable]
public record PatchFunctionRequestConfigRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The handler entrypoint for the function code (e.g. 'index.handler').
    /// </summary>
    [JsonPropertyName("handler")]
    public string? Handler { get; set; }

    /// <summary>
    /// Whether the run schedule is enabled.
    /// </summary>
    [JsonPropertyName("isScheduleEnabled")]
    public bool? IsScheduleEnabled { get; set; }

    /// <summary>
    /// Default parameter values for the function. Replaces all existing parameters.
    /// </summary>
    [JsonPropertyName("params")]
    public PatchFunctionRequestConfigRequestBodyParams? Params { get; set; }

    [JsonPropertyName("schedule")]
    public FunctionScheduleRequestBody? Schedule { get; set; }

    /// <summary>
    /// Secrets available to the function at runtime. Replaces all existing secrets.
    /// </summary>
    [JsonPropertyName("secrets")]
    public PatchFunctionRequestConfigRequestBodySecrets? Secrets { get; set; }

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
