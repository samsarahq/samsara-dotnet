using global::System.Text.Json.Serialization;

namespace Samsara.Net.Core;

public interface IStringEnum : IEquatable<string>
{
    public string Value { get; }
}
