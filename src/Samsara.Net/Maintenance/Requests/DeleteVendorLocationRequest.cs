using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Maintenance;

[Serializable]
public record DeleteVendorLocationRequest
{
    /// <summary>
    /// Unique identifier for the vendor location record.
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
