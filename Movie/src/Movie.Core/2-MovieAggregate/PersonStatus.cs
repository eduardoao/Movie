using Ardalis.SmartEnum;

namespace Movie.Core._2_MovieAggregate;

public class PersonStatus: SmartEnum<PersonStatus>
{
   public static readonly PersonStatus Character = new(nameof(Character), 1);
   public static readonly PersonStatus Director = new(nameof(Director), 1);

   protected PersonStatus(string name, int value) : base(name, value) { }
}
