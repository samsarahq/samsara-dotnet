using Samsara.Net.Core;

namespace Samsara.Net.V1.Assets;

public record AssetsListCurrentLocationsRequest
{
    /// <summary>
    /// Pagination parameter indicating the cursor position to continue returning results after. Used in conjunction with the 'limit' parameter. Mutually exclusive with 'endingBefore' parameter.
    /// </summary>
    public string? StartingAfter { get; set; }

    /// <summary>
    /// Pagination parameter indicating the cursor position to return results before. Used in conjunction with the 'limit' parameter. Mutually exclusive with 'startingAfter' parameter.
    /// </summary>
    public string? EndingBefore { get; set; }

    /// <summary>
    /// Pagination parameter indicating the number of results to return in this request. Used in conjunction with either 'startingAfter' or 'endingBefore'.
    /// </summary>
    public long? Limit { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
