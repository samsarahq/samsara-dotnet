using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The details of a form approval. Only valid for forms that require approvals.
/// </summary>
[Serializable]
public record FormSubmissionRequestApprovalDetailsRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Comment for the approval decision. Sometimes required when updating status to 'changesRequested'. Only valid when requesting changes or approving a form submission.
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

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
