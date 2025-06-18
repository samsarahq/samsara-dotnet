using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Forms table field definition object.
/// </summary>
public record FormsTableFieldDefinitionObjectResponseBody
{
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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
