using System;
using Ardalis.GuardClauses;
using Ardalis.SharedKernel;

namespace Movie.Core._2_MovieAggregate;

public class Trailler (string title): EntityBase, IAggregateRoot
{
  public string Title { get; private set; }  = Guard.Against.NullOrEmpty(title, nameof(title));
  public string? Path { get;  private set; }
  public bool Enable { get; private set; } = true; 
  public DateTime CreatedAt { get; private set; }

}
