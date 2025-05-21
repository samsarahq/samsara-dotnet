using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1TrailerAssignmentResponse
{
    /// <summary>
    /// The ID of the driver associated with this trailer.
    /// </summary>
    [JsonPropertyName("driverId")]
    public long? DriverId { get; set; }

    /// <summary>
    /// The time at which the driver ended the assignment. If the assignment is current, this value will be omitted.
    /// </summary>
    [JsonPropertyName("endMs")]
    public long? EndMs { get; set; }

    /// <summary>
    /// The time at which the driver started the assignment
    /// </summary>
    [JsonPropertyName("startMs")]
    public long? StartMs { get; set; }

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
