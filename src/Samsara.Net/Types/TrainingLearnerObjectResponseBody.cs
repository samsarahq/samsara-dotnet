using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Learner that is associated with the training assignment. Only driver learners are supported currently.
/// </summary>
public record TrainingLearnerObjectResponseBody
{
    /// <summary>
    /// ID of the polymorphic user.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The type of the polymorphic user.  Valid values: `driver`
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "driver";

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
