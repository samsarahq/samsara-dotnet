using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Documents;

[JsonConverter(typeof(EnumSerializer<DocumentsPostDocumentRequestBodyState>))]
public enum DocumentsPostDocumentRequestBodyState
{
    [EnumMember(Value = "submitted")]
    Submitted,

    [EnumMember(Value = "required")]
    Required,
}
