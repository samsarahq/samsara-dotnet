using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1DocumentBase
{
    /// <summary>
    /// ID of the Samsara dispatch job for which the document is submitted.
    /// </summary>
    [JsonPropertyName("dispatchJobId")]
    public required long DispatchJobId { get; set; }

    /// <summary>
    /// Custom name of the document. If no custom name is given to the document, the admin dashboard and driver app will display the template name as the default document name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Notes submitted with this document.
    /// </summary>
    [JsonPropertyName("notes")]
    public required string Notes { get; set; }

    /// <summary>
    /// The condition of the document created for the driver. Can be either `Required` or `Submitted`. If no value is specified, `state` defaults to `Required`. `Required` documents are pre-populated documents for the Driver to fill out in the Driver App and have not yet been submitted. `Submitted` documents have been submitted by the driver in the Driver App. `Archived` documents have been archived by the admin in the cloud dashboard.
    /// </summary>
    [JsonPropertyName("state")]
    public V1DocumentBaseState? State { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
