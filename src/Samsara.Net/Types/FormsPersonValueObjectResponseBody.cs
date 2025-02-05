using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FormsPersonValueObjectResponseBody
{
    [JsonPropertyName("person")]
    public required FormsPersonObjectResponseBody Person { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
