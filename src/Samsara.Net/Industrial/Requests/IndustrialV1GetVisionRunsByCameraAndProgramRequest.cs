using Samsara.Net.Core;

namespace Samsara.Net.Industrial;

public record IndustrialV1GetVisionRunsByCameraAndProgramRequest
{
    /// <summary>
    /// Include is a filter parameter. Accepts 'pass', 'reject' or 'no_read'.
    /// </summary>
    public string? Include { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
