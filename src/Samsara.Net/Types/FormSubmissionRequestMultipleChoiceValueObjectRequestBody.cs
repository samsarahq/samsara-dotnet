using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FormSubmissionRequestMultipleChoiceValueObjectRequestBody
{
    [JsonPropertyName("valueId")]
    public required string ValueId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
