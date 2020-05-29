using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCoreJwt.Framework
{
    public class DefaultValueFilterAttribute : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            // TO DO ...
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            foreach(var model in context.ActionArguments)
            {
                if(model.Value is IHasCreateTime temp)
                {
                    temp.CreateTime = DateTime.Now;
                }
            }
        }
    }
}
