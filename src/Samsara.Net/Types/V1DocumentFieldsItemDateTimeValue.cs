using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1DocumentFieldsItemDateTimeValue
{
    /// <summary>
    /// Date time value in milliseconds.
    /// </summary>
    [JsonPropertyName("dateTimeMs")]
    public double? DateTimeMs { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
