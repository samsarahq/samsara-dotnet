using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Defect type data.
/// </summary>
public record DefectTypesResponseDataResponseBody
{
    /// <summary>
    /// Time when defect type was created in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public required string CreatedAtTime { get; set; }

    /// <summary>
    /// The unique ID of the DVIR defect type.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// DVIR defect type label.
    /// </summary>
    [JsonPropertyName("label")]
    public required string Label { get; set; }

    /// <summary>
    /// Section for DVIR defect type.  Valid values: `exteriorFront`, `exteriorRear`, `exteriorSideUnderneath`, `interiorDriverCab`, `interiorPassengerArea`, `other`, `unknown`
    /// </summary>
    [JsonPropertyName("sectionType")]
    public required DefectTypesResponseDataResponseBodySectionType SectionType { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
