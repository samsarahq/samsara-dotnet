using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// How much tax is applied to a work order. Either money or basisPoints are specified.
/// </summary>
[Serializable]
public record WorkOrderTaxObjectRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The tax in basis points. 100 basis points = 1%.
    /// </summary>
    [JsonPropertyName("basisPoints")]
    public long? BasisPoints { get; set; }

    [JsonPropertyName("money")]
    public WorkOrderMoneyObjectRequestBody? Money { get; set; }

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
