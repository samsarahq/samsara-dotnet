using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

public record BetaApIsPostFormSubmissionsPdfExportsRequest
{
    /// <summary>
    /// ID of the form submission to create a PDF export from.
    /// </summary>
    public required string Id { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
