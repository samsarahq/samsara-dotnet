using System;
using System.Runtime.Serialization;
using System.Reflection;

namespace Samsara.Net.Core;

internal static class Extensions
{
    public static string Stringify(this Enum value)
    {
        var field = value.GetType().GetField(value.ToString());
        var attribute = field.GetCustomAttribute<EnumMemberAttribute>();
        return attribute?.Value ?? value.ToString();
    }
}
