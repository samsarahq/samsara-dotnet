using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record MultipleChoiceFieldTypeMetaDataObjectResponseBody
{
    /// <summary>
    /// The option choice label.
    /// </summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
