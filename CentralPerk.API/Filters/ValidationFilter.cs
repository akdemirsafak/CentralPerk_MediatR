using CentralPerk.API.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CentralPerk.API.Filters;

public class ValidationFilter : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        if (!context.ModelState.IsValid)
        {
            var errors = context.ModelState.Values.SelectMany(x => x.Errors)
                .Select(x => x.ErrorMessage).ToList();
            context.Result = new BadRequestObjectResult(ResponseDto<NoContentDto>.Fail(errors, 400));
        }

        base.OnActionExecuting(context);
    }
}