using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Carrier for a given organization.
/// </summary>
public record OrganizationInfoCarrierSettings
{
    /// <summary>
    /// Carrier for a given organization.
    /// </summary>
    [JsonPropertyName("carrierName")]
    public string? CarrierName { get; set; }

    /// <summary>
    /// Carrier US DOT Number for the organization.
    /// </summary>
    [JsonPropertyName("dotNumber")]
    public long? DotNumber { get; set; }

    /// <summary>
    /// Main office address for a given organization.
    /// </summary>
    [JsonPropertyName("mainOfficeAddress")]
    public string? MainOfficeAddress { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
