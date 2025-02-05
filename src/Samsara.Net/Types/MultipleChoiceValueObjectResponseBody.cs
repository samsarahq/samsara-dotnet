using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record MultipleChoiceValueObjectResponseBody
{
    /// <summary>
    /// Boolean representing if the choice has been selected.
    /// </summary>
    [JsonPropertyName("selected")]
    public bool? Selected { get; set; }

    /// <summary>
    /// Description of the choice.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
