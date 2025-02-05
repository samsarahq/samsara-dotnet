using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<FormsFieldDefinitionObjectResponseBodyAllowedAssetTypesItem>))]
public enum FormsFieldDefinitionObjectResponseBodyAllowedAssetTypesItem
{
    [EnumMember(Value = "Vehicle")]
    Vehicle,

    [EnumMember(Value = "Trailer")]
    Trailer,

    [EnumMember(Value = "Equipment")]
    Equipment,

    [EnumMember(Value = "UnpoweredAsset")]
    UnpoweredAsset,
}
