using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The value of a barcode form input field. Only valid for barcode form input fields.
/// </summary>
[Serializable]
public record FormSubmissionRequestBarcodeValueObjectRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// List of barcode entries.
    /// </summary>
    [JsonPropertyName("barcodes")]
    public IEnumerable<FormSubmissionRequestBarcodeObjectRequestBody> Barcodes { get; set; } =
        new List<FormSubmissionRequestBarcodeObjectRequestBody>();

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
