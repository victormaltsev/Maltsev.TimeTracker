using Maltsev.TimeTracker.Application.ValueTypes;

namespace Maltsev.TimeTracker.Application.Repositories;

public interface IAssignmentsRepository
{
    Task<IEnumerable<Assignment>> GetAssignmentsAsync(AssignmentId assignmentId, CancellationToken cancellationToken = default);
    Task<AssignmentId> InsertAssignmentAsync(Assignment assignment, CancellationToken cancellationToken = default);
    Task UpdateAssignmentAsync(AssignmentId assignmentId, Assignment assignment, CancellationToken cancellationToken = default);
    Task DeleteAssignmentAsync(AssignmentId assignmentId, CancellationToken cancellationToken = default);
}

public record Assignment
{
    public required string Name { get; init; }
    public required string Description { get; init; }
    public required bool IsFavorite { get; init; }
}
