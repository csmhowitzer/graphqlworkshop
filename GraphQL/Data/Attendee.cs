using System.ComponentModel.DataAnnotations;

namespace ConferencePlanner.GraphQL.Data;

public sealed class Attendee
{
    public int Id { get; init; }
    [StringLength(200)]
    public required string FirstName { get; init; }
    [StringLength(200)]
    public required string LastName { get; init; }
    [StringLength(200)]
    public required string UserName { get; init; }
    [StringLength(256)]
    public string? EmailAddress { get; init; }
    
    public ICollection<SessionAttendee> SessionAttendees { get; init; } = 
        new List<SessionAttendee>();
}
