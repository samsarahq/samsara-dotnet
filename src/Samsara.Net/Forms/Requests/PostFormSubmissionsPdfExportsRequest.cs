using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Forms;

[Serializable]
public record PostFormSubmissionsPdfExportsRequest
{
    /// <summary>
    /// ID of the form submission to create a PDF export from.
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
