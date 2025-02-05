using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1DocumentFieldsItemBarcodeValueItem
{
    /// <summary>
    /// The barcode type that was scanned
    /// </summary>
    [JsonPropertyName("barcodeType")]
    public string? BarcodeType { get; set; }

    /// <summary>
    /// The captured barcode value
    /// </summary>
    [JsonPropertyName("barcodeValue")]
    public string? BarcodeValue { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
