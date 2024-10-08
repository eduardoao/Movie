using FastEndpoints;
using FluentValidation;

namespace Movie.Web.Tags;

/// <summary>
/// See: https://fast-endpoints.com/docs/validation
/// </summary>
public class GetTagValidator : Validator<GetTagByIdRequest>
{
  public GetTagValidator()
  {
    RuleFor(x => x.TagId)
      .GreaterThan(0);
  }
}
