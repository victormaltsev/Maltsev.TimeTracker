namespace Maltsev.TimeTracker.Application.ValueTypes;

public readonly struct AssignmentId(Guid value) : IEquatable<AssignmentId>
{
    private readonly Guid _value = value;

    public bool Equals(AssignmentId other) => _value.Equals(other._value);

    public override bool Equals(object? obj) => obj is AssignmentId other && Equals(other);
    public override int GetHashCode() => _value.GetHashCode();
    public override string ToString() => _value.ToString();

    public static bool operator ==(AssignmentId left, AssignmentId right) => left.Equals(right);
    public static bool operator !=(AssignmentId left, AssignmentId right) => !(left == right);

    public static implicit operator Guid(AssignmentId assignmentId) => assignmentId._value;
    public static explicit operator AssignmentId(Guid value) => new(value);
}
