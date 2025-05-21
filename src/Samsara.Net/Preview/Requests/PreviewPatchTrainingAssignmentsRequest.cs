using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Preview;

public record PreviewPatchTrainingAssignmentsRequest
{
    /// <summary>
    /// String of comma separated assignments IDs. Max value for this value is 100 objects .Example: `ids=a4db8702-79d5-4396-a717-e301d52ecc11,c6490f6a-d84e-49b5-b0ad-b6baae304075`
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> Ids { get; set; } = new List<string>();

    /// <summary>
    /// Due date of the training assignment in RFC 3339 format. Millisecond precision and timezones are supported.
    /// </summary>
    [JsonIgnore]
    public required string DueAtTime { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
