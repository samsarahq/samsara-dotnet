using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record GetCampaignRollupsRequest
{
    /// <summary>
    /// Unique ID of the campaign.
    /// </summary>
    [JsonIgnore]
    public required string CampaignId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
