using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FormsCheckBoxesValueObjectResponseBody
{
    /// <summary>
    /// List of selected options.
    /// </summary>
    [JsonPropertyName("value")]
    public IEnumerable<string> Value { get; set; } = new List<string>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
