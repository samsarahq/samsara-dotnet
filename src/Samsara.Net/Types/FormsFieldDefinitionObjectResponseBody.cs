using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Forms field definition object.
/// </summary>
[Serializable]
public record FormsFieldDefinitionObjectResponseBody : IJsonOnDeserialized
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
    /// List of allowed asset types that can be selected for this field. Only present for asset fields.
    /// </summary>
    [JsonPropertyName("allowedAssetTypes")]
    public IEnumerable<FormsFieldDefinitionObjectResponseBodyAllowedAssetTypesItem>? AllowedAssetTypes { get; set; }

    /// <summary>
    /// Type of date/time entry allowed for this question. Only present for datetime fields.  Valid values: `datetime`, `date`, `time`
    /// </summary>
    [JsonPropertyName("allowedDateTimeValueType")]
    public FormsFieldDefinitionObjectResponseBodyAllowedDateTimeValueType? AllowedDateTimeValueType { get; set; }

    /// <summary>
    /// Identifier of the field that will optionally autofill the current field. Only present for fields that have been configured to be autofilled by a source media field.
    /// </summary>
    [JsonPropertyName("autofillFromId")]
    public string? AutofillFromId { get; set; }

    /// <summary>
    /// List of columns in the table field.
    /// </summary>
    [JsonPropertyName("columns")]
    public IEnumerable<FormsTableFieldDefinitionObjectResponseBody>? Columns { get; set; }

    /// <summary>
    /// List of conditional actions.
    /// </summary>
    [JsonPropertyName("conditionalActions")]
    public IEnumerable<FormsConditionalActionObjectResponseBody>? ConditionalActions { get; set; }

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
    /// Indicates whether the current field is enabled to autofill other fields. Only present for media fields that have autofill enabled.
    /// </summary>
    [JsonPropertyName("isAutofillSource")]
    public bool? IsAutofillSource { get; set; }

    /// <summary>
    /// Indicates whether the form field is required to be filled out by the user.
    /// </summary>
    [JsonPropertyName("isRequired")]
    public required bool IsRequired { get; set; }

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
    /// The maximum possible score weight for this field. For multiple choice fields, this number is the highest option score weight of the given options. For check boxes fields, this number is the sum of the score weights for all scored options. Only present for multiple choice or check boxes fields that have scoring.
    /// </summary>
    [JsonPropertyName("questionWeight")]
    public long? QuestionWeight { get; set; }

    /// <summary>
    /// Type of the field.  Valid values: `number`, `text`, `multiple_choice`, `check_boxes`, `media`, `datetime`, `signature`, `asset`, `person`, `geofence`, `instruction`, `media_instruction`, `table`
    /// </summary>
    [JsonPropertyName("type")]
    public required FormsFieldDefinitionObjectResponseBodyType Type { get; set; }

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
