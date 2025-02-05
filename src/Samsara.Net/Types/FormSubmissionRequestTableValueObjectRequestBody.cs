using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FormSubmissionRequestTableValueObjectRequestBody
{
    /// <summary>
    /// List of rows in the table.
    /// </summary>
    [JsonPropertyName("rows")]
    public IEnumerable<FormSubmissionRequestTableRowObjectRequestBody> Rows { get; set; } =
        new List<FormSubmissionRequestTableRowObjectRequestBody>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
