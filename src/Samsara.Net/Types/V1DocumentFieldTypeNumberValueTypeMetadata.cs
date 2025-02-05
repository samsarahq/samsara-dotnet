using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1DocumentFieldTypeNumberValueTypeMetadata
{
    /// <summary>
    /// The number of decimal places allowed for this number field
    /// </summary>
    [JsonPropertyName("numDecimalPlaces")]
    public long? NumDecimalPlaces { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
