using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApis;

[Serializable]
public record QualificationsUnarchiveQualificationRecordRequestBody
{
    /// <summary>
    /// ID of the qualification record to unarchive.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
