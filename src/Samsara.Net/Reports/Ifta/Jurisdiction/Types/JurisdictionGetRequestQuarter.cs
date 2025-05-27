using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Reports.Ifta.Jurisdiction;

[JsonConverter(typeof(EnumSerializer<JurisdictionGetRequestQuarter>))]
public enum JurisdictionGetRequestQuarter
{
    [EnumMember(Value = "Q1")]
    Q1,

    [EnumMember(Value = "Q2")]
    Q2,

    [EnumMember(Value = "Q3")]
    Q3,

    [EnumMember(Value = "Q4")]
    Q4,
}
