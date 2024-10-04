using FastEndpoints;
using FluentValidation;
using Movie.Web.Tags;

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
