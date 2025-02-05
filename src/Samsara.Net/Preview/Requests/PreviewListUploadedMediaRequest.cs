using Samsara.Net.Core;

namespace Samsara.Net.Preview;

public record PreviewListUploadedMediaRequest
{
    /// <summary>
    /// A filter on the data based on this comma-separated list of vehicle IDs and externalIds. Example: `vehicleIds=1234,5678,samsara.vin:1HGBH41JXMN109186`
    /// </summary>
    public string? VehicleIds { get; set; }

    /// <summary>
    /// A list of desired camera inputs for which to return captured media. If empty, media for all available inputs will be returned.
    /// </summary>
    public IEnumerable<PreviewListUploadedMediaRequestInputsItem> Inputs { get; set; } =
        new List<PreviewListUploadedMediaRequestInputsItem>();

    /// <summary>
    /// A list of desired media types for which to return captured media. If empty, media for all available media types will be returned.
    /// </summary>
    public IEnumerable<string> MediaTypes { get; set; } = new List<string>();

    /// <summary>
    /// A list of desired trigger reasons for which to return captured media. If empty, media for all available trigger reasons will be returned.
    /// </summary>
    public IEnumerable<PreviewListUploadedMediaRequestTriggerReasonsItem> TriggerReasons { get; set; } =
        new List<PreviewListUploadedMediaRequestTriggerReasonsItem>();

    /// <summary>
    /// A filter on the data based on this comma-separated list of tag IDs. Example: `tagIds=1234,5678`
    /// </summary>
    public string? TagIds { get; set; }

    /// <summary>
    /// A filter on the data based on this comma-separated list of parent tag IDs, for use by orgs with tag hierarchies. Specifying a parent tag will implicitly include all descendent tags of the parent tag. Example: `parentTagIds=345,678`
    /// </summary>
    public string? ParentTagIds { get; set; }

    /// <summary>
    /// A start time in RFC 3339 format. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    public required string StartTime { get; set; }

    /// <summary>
    /// An end time in RFC 3339 format. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    public required string EndTime { get; set; }

    /// <summary>
    /// A timestamp in RFC 3339 format that can act as a cursor to track which media has previously been retrieved; only media whose availableAtTime comes after this parameter will be returned. Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00
    /// </summary>
    public string? AvailableAfterTime { get; set; }

    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    public string? After { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
