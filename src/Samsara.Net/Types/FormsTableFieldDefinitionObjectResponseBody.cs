using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Forms table field definition object.
/// </summary>
[Serializable]
public record FormsTableFieldDefinitionObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Indicates whether the field allows manual entry of a person. Only present for person fields.
    /// </summary>
    [JsonPropertyName("allowManualEntry")]
    public bool? AllowManualEntry { get; set; }

    /// <summary>
    /// Type of date/time entry allowed for this question. Only present for datetime fields.  Valid values: `datetime`, `date`, `time`
    /// </summary>
    [JsonPropertyName("allowedDateTimeValueType")]
    public FormsTableFieldDefinitionObjectResponseBodyAllowedDateTimeValueType? AllowedDateTimeValueType { get; set; }

    /// <summary>
    /// List of role IDs to filter org users by, representing which roles are selectable people for this field. Only present for person fields.
    /// </summary>
    [JsonPropertyName("filterByRoleIds")]
    public IEnumerable<string>? FilterByRoleIds { get; set; }

    /// <summary>
    /// Identifier of the field.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Indicates whether the field includes drivers as selectable people. Only present for person fields.
    /// </summary>
    [JsonPropertyName("includeDrivers")]
    public bool? IncludeDrivers { get; set; }

    /// <summary>
    /// Indicates whether the field includes users as selectable people. Only present for person fields.
    /// </summary>
    [JsonPropertyName("includeUsers")]
    public bool? IncludeUsers { get; set; }

    /// <summary>
    /// Label of the field.
    /// </summary>
    [JsonPropertyName("label")]
    public required string Label { get; set; }

    /// <summary>
    /// Number of decimal places allowed. Only present for number fields.
    /// </summary>
    [JsonPropertyName("numDecimalPlaces")]
    public long? NumDecimalPlaces { get; set; }

    /// <summary>
    /// List of select options for check boxes or multiple choice fields.
    /// </summary>
    [JsonPropertyName("options")]
    public IEnumerable<FormsSelectOptionObjectResponseBody>? Options { get; set; }

    /// <summary>
    /// Type of the field.  Valid values: `number`, `text`, `multiple_choice`, `check_boxes`, `media`, `datetime`, `signature`, `person`
    /// </summary>
    [JsonPropertyName("type")]
    public required FormsTableFieldDefinitionObjectResponseBodyType Type { get; set; }

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
