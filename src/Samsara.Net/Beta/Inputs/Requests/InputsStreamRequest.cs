using Samsara.Net.Core;

namespace Samsara.Net.Beta.Inputs;

public record InputsStreamRequest
{
    /// <summary>
    /// Comma-separated list of asset IDs. Limited to 100 ID's for each request.
    /// </summary>
    public IEnumerable<string> Ids { get; set; } = new List<string>();

    /// <summary>
    /// Input stat type to query for.  Valid values: `auxInput1`, `auxInput2`, `auxInput3`, `auxInput4`, `auxInput5`, `auxInput6`, `auxInput7`, `auxInput8`, `auxInput9`, `auxInput10`, `auxInput11`, `auxInput12`, `auxInput13`, `analogInput1Voltage`, `analogInput2Voltage`, `analogInput1Current`, `analogInput2Current`, `batteryVoltage`
    /// </summary>
    public required InputsStreamRequestType Type { get; set; }

    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    public string? After { get; set; }

    /// <summary>
    /// A start time in RFC 3339 format. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    public required string StartTime { get; set; }

    /// <summary>
    /// An end time in RFC 3339 format. Defaults to never if not provided; if not provided then pagination will not cease, and a valid pagination cursor will always be returned. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    public string? EndTime { get; set; }

    /// <summary>
    /// Optional boolean indicating whether to return external IDs on supported entities
    /// </summary>
    public bool? IncludeExternalIds { get; set; }

    /// <summary>
    /// Optional boolean indicating whether to return tags on supported entities
    /// </summary>
    public bool? IncludeTags { get; set; }

    /// <summary>
    /// Optional boolean indicating whether to return attributes on supported entities
    /// </summary>
    public bool? IncludeAttributes { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
