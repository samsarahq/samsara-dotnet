using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Base form submission metadata.
/// </summary>
[Serializable]
public record Dvir2FormSubmissionObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("assignedToPolymorphicUser")]
    public Dvir2AssignedToPolymorphicUserObjectResponseBody? AssignedToPolymorphicUser { get; set; }

    /// <summary>
    /// Time of when the form submission is due. UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("dueDate")]
    public string? DueDate { get; set; }

    /// <summary>
    /// Time when the form submission was last updated on the server. UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("serverUpdatedAt")]
    public required string ServerUpdatedAt { get; set; }

    /// <summary>
    /// The unique UUID of the form submission
    /// </summary>
    [JsonPropertyName("uuid")]
    public required string Uuid { get; set; }

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
