using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record GetAempEquipmentListRequest
{
    /// <summary>
    /// The number corresponding to a specific page of paginated results, defaulting to the first page if not provided. The default page size is 100 records.
    /// </summary>
    [JsonIgnore]
    public required string PageNumber { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
