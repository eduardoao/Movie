using Ardalis.GuardClauses;
using Ardalis.SharedKernel;

namespace Movie.Core._2_MovieAggregate;

public class PersonPaper(string name) : EntityBase, IAggregateRoot
{
  public string Name { get; private set; } = Guard.Against.NullOrEmpty(name, nameof(name));
  public string? Biography { get; private set; }

  
}
