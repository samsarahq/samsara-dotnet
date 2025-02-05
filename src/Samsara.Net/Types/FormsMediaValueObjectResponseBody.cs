using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FormsMediaValueObjectResponseBody
{
    /// <summary>
    /// List of forms media record objects.
    /// </summary>
    [JsonPropertyName("mediaList")]
    public IEnumerable<FormsMediaRecordObjectResponseBody> MediaList { get; set; } =
        new List<FormsMediaRecordObjectResponseBody>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
