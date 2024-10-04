using FastEndpoints;
using FluentValidation;


public class DeleteTagValidator : Validator<DeleteTagRequest>
{
  public DeleteTagValidator()
  {
    RuleFor(x => x.TagId).GreaterThan(0);
  }
}
