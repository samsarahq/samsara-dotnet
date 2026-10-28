using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record DeletePartPhotoRequest
{
    /// <summary>
    /// ID of the part the photo belongs to.
    /// </summary>
    [JsonIgnore]
    public required string PartId { get; set; }

    /// <summary>
    /// ID of the photo to delete.
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
