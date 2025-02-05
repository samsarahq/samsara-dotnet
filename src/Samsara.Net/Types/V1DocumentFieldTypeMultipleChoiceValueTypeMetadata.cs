using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1DocumentFieldTypeMultipleChoiceValueTypeMetadata
{
    /// <summary>
    /// Array of the multiple choice option labels for the field
    /// </summary>
    [JsonPropertyName("multipleChoiceOptionLabels")]
    public IEnumerable<V1DocumentFieldTypeMultipleChoiceValueTypeMetadataMultipleChoiceOptionLabels>? MultipleChoiceOptionLabels { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
