using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<FormsFieldDefinitionObjectResponseBodyAllowedAssetTypesItem>))]
public enum FormsFieldDefinitionObjectResponseBodyAllowedAssetTypesItem
{
    [EnumMember(Value = "vehicle")]
    Vehicle,

    [EnumMember(Value = "trailer")]
    Trailer,

    [EnumMember(Value = "equipment")]
    Equipment,

    [EnumMember(Value = "unpoweredAsset")]
    UnpoweredAsset,
}
