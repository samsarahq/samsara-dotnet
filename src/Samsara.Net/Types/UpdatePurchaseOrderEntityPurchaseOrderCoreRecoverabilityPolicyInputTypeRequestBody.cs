using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// UpdatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyInput object
/// </summary>
[Serializable]
public record UpdatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyInputTypeRequestBody
    : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Absolute deadline for core return.
    /// </summary>
    [JsonPropertyName("fixedRecoverableUntilTime")]
    public string? FixedRecoverableUntilTime { get; set; }

    /// <summary>
    /// Recoverability policy type.  Valid values: `Unknown`, `RelativeToReceipt`, `FixedDate`, `NoDeadline`
    /// </summary>
    [JsonPropertyName("policyType")]
    public required UpdatePurchaseOrderEntityPurchaseOrderCoreRecoverabilityPolicyInputTypeRequestBodyPolicyType PolicyType { get; set; }

    /// <summary>
    /// Duration after receipt when the core must be returned. Measured in milliseconds.
    /// </summary>
    [JsonPropertyName("relativeWindowDuration")]
    public long? RelativeWindowDuration { get; set; }

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
