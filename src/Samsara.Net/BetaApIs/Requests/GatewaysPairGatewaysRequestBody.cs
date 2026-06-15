using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record GatewaysPairGatewaysRequestBody
{
    /// <summary>
    /// Gateway-device pairs to apply.
    /// </summary>
    [JsonPropertyName("pairs")]
    public IEnumerable<PairGatewayPairObjectRequestBody> Pairs { get; set; } =
        new List<PairGatewayPairObjectRequestBody>();

    /// <summary>
    /// When true, devices that the reassigned gateways were previously linked to are moved to the unassigned group and have their tags cleared as a side-effect of the pairing. The previousDevice fields in the response describe each orphaned device as it existed immediately before the pairing was applied, so they remain stable regardless of this flag. Defaults to false.
    /// </summary>
    [JsonPropertyName("removeOrphanDevices")]
    public bool? RemoveOrphanDevices { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
