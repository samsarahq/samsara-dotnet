using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record TinyWidgetObjectResponseBody
{
    /// <summary>
    /// ID of the widget.
    /// </summary>
    [JsonPropertyName("widgetId")]
    public required string WidgetId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
