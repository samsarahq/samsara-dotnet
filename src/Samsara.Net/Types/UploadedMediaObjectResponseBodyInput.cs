using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<UploadedMediaObjectResponseBodyInput>))]
public enum UploadedMediaObjectResponseBodyInput
{
    [EnumMember(Value = "dashcamForwardFacing")]
    DashcamForwardFacing,

    [EnumMember(Value = "dashcamInwardFacing")]
    DashcamInwardFacing,

    [EnumMember(Value = "dashcamRearFacing")]
    DashcamRearFacing,
}
