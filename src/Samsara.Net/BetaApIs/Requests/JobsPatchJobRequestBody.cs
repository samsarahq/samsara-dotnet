using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

public record JobsPatchJobRequestBody
{
    /// <summary>
    /// A jobId or uuid in STRING format. JobId must be prefixed with `jobId:`(Examples: `"8d218e6c-7a16-4f9f-90f7-cc1d93b9e596"`, `"jobId:98765"`).
    /// </summary>
    public required string Id { get; set; }

    public required PatchJobObjectRequestBody Job { get; set; }

    /// <summary>
    /// Defaults to true if user does not want to overwrite entire history for an active job (irrelevant for scheduled/completed jobs)
    /// </summary>
    public bool? KeepHistory { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
