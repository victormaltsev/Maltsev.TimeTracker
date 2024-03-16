namespace Maltsev.TimeTracker.Application.Repositories;

public interface IAssignmentsRepository
{
    Task<AssignmentId> InsertAssignmentAsync(Assignment assignment, CancellationToken cancellationToken = default);
    Task UpdateAssignmentAsync(AssignmentId assignmentId, Assignment assignment, CancellationToken cancellationToken = default);
    Task DeleteAssignmentAsync(AssignmentId assignmentId, CancellationToken cancellationToken = default);
}

public readonly struct AssignmentId(Guid value) : IEquatable<AssignmentId>
{
    public Guid Value { get; } = value;

    public bool Equals(AssignmentId other) => Value.Equals(other.Value);

    public override bool Equals(object? obj) => obj is AssignmentId other && Equals(other);
    public override int GetHashCode() => Value.GetHashCode();
    public override string ToString() => Value.ToString();

    public static bool operator ==(AssignmentId left, AssignmentId right) => left.Equals(right);
    public static bool operator !=(AssignmentId left, AssignmentId right) => !(left == right);
}

public record Assignment
{
    public required string Name { get; init; }
    public required string Description { get; init; }
    public required string Comment { get; init; }
}
