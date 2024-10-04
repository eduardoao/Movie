using Movie.Infrastructure.Data.Config;
using FastEndpoints;
using FluentValidation;

namespace Movie.Web.Tags;

/// <summary>
/// See: https://fast-endpoints.com/docs/validation
/// </summary>
public class CreateTagValidator : Validator<CreateTagRequest>
{
  public CreateTagValidator()
  {
    RuleFor(x => x.Title)
      .NotEmpty()
      .WithMessage("Tag is required.")
      .MinimumLength(3)
      .MaximumLength(DataSchemaConstants.DEFAULT_NAME_LENGTH);
  }
}



