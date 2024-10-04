using Movie.Infrastructure.Data.Config;
using FastEndpoints;
using FluentValidation;

namespace Movie.Web.Tags;

/// <summary>
/// See: https://fast-endpoints.com/docs/validation
/// </summary>
public class UpdateContributorValidator : Validator<UpdateTagRequest>
{
  public UpdateContributorValidator()
  {
    RuleFor(x => x.Title)
      .NotEmpty()
      .WithMessage("Title is required.")
      .MinimumLength(2)
      .MaximumLength(DataSchemaConstants.DEFAULT_NAME_LENGTH);
    RuleFor(x => x.TagId)
      .Must((args, contributorId) => args.Id == contributorId)
      .WithMessage("Route and body Ids must match; cannot update Id of an existing resource.");
  }
}
