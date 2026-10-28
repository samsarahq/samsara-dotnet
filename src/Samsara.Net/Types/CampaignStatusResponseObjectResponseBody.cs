using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The customer-defined status of a campaign and the fixed state behind it.
/// </summary>
[Serializable]
public record CampaignStatusResponseObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// ID of the status definition.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Customer-facing name of the status.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Fixed system state behind the status. Campaigns created through the API start in `draft`. Defaults to `unknown` when the status definition no longer exists.  Valid values: `draft`, `active`, `onHold`, `complete`, `cancelled`, `unknown`
    /// </summary>
    [JsonPropertyName("state")]
    public required CampaignStatusResponseObjectResponseBodyState State { get; set; }

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
