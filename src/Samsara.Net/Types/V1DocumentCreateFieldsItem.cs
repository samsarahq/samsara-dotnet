using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1DocumentCreateFieldsItem
{
    /// <summary>
    /// The date time value to populate the field. Use with ValueType_DateTime. Cannot be ommited or set to null
    /// </summary>
    [JsonPropertyName("dateTimeValue")]
    public V1DocumentCreateFieldsItemDateTimeValue? DateTimeValue { get; set; }

    /// <summary>
    /// label of the field
    /// </summary>
    [JsonPropertyName("label")]
    public required string Label { get; set; }

    /// <summary>
    /// The multiple choice value to populate the field. Use with ValueType_MultipleChoice. Cannot be ommited or set to null
    /// </summary>
    [JsonPropertyName("multipleChoiceValue")]
    public IEnumerable<V1DocumentCreateFieldsItemMultipleChoiceValueItem>? MultipleChoiceValue { get; set; }

    /// <summary>
    /// The number value to populate the field. Use with ValueType_Number. Can be ommited or set to null
    /// </summary>
    [JsonPropertyName("numberValue")]
    public double? NumberValue { get; set; }

    /// <summary>
    /// The string value to populate the field. Use with ValueType_String. Can be ommited or set to null
    /// </summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// DEPRECATED. Please use one of the type-specific parameters.
    /// </summary>
    [JsonPropertyName("value")]
    public object? Value { get; set; }

    /// <summary>
    /// The valueType of the field. Use with the corresponding {type of field}Value attribute. Signature and photo fields do not support values added via API. Their values must be omitted or set to null. For example:
    ///
    /// ```
    ///
    /// "fields": [
    ///
    ///   {
    ///
    ///     "label": "Signature",
    ///
    ///     "valueType": "ValueType_Signature"
    ///
    ///   },
    ///
    ///   ... more fields
    ///
    /// ]
    ///
    /// ```
    /// </summary>
    [JsonPropertyName("valueType")]
    public required string ValueType { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
