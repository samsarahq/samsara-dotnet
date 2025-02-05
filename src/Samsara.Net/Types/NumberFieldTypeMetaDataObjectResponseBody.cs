using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record NumberFieldTypeMetaDataObjectResponseBody
{
    /// <summary>
    /// The number of decimal places allowed for the field.
    /// </summary>
    [JsonPropertyName("numberOfDecimalPlaces")]
    public long? NumberOfDecimalPlaces { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
