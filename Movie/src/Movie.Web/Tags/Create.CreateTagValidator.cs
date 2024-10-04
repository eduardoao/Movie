using Movie.Infrastructure.Data.Config;
using FastEndpoints;
using FluentValidation;
using Movie.Web.Tags;

namespace Movie.Web.Contributors;

/// <summary>
/// See: https://fast-endpoints.com/docs/validation
/// </summary>
public class CreateTagValidator : Validator<CreateTagRequest>
{
  public CreateTagValidator()
  {
    RuleFor(x => x.Title)
      .NotEmpty()
      .WithMessage("Title is required.")
      .MinimumLength(2)
      .MaximumLength(DataSchemaConstants.DEFAULT_NAME_LENGTH);
  }
}
