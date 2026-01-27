using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Forms input field request body object.
/// </summary>
[Serializable]
public record FormSubmissionRequestFieldInputObjectRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("assetValue")]
    public FormSubmissionRequestAssetValueObjectRequestBody? AssetValue { get; set; }

    [JsonPropertyName("checkBoxesValue")]
    public FormSubmissionRequestCheckBoxesValueObjectRequestBody? CheckBoxesValue { get; set; }

    [JsonPropertyName("dateTimeValue")]
    public FormSubmissionRequestDateTimeValueObjectRequestBody? DateTimeValue { get; set; }

    [JsonPropertyName("geofenceValue")]
    public FormSubmissionRequestGeofenceValueObjectRequestBody? GeofenceValue { get; set; }

    /// <summary>
    /// ID of the forms input field object.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("multipleChoiceValue")]
    public FormSubmissionRequestMultipleChoiceValueObjectRequestBody? MultipleChoiceValue { get; set; }

    [JsonPropertyName("numberValue")]
    public FormSubmissionRequestNumberValueObjectRequestBody? NumberValue { get; set; }

    [JsonPropertyName("personValue")]
    public FormSubmissionRequestPersonValueObjectRequestBody? PersonValue { get; set; }

    [JsonPropertyName("tableValue")]
    public FormSubmissionRequestTableValueObjectRequestBody? TableValue { get; set; }

    [JsonPropertyName("textValue")]
    public FormSubmissionRequestTextValueObjectRequestBody? TextValue { get; set; }

    /// <summary>
    /// Type of the field.  Valid values: `number`, `text`, `multiple_choice`, `check_boxes`, `datetime`, `asset`, `person`, `table`, `geofence`
    /// </summary>
    [JsonPropertyName("type")]
    public required FormSubmissionRequestFieldInputObjectRequestBodyType Type { get; set; }

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
