using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace Api_Layer.Filters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class ExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            if (context.Exception is ValidationException)
            {
                context.HttpContext.Response.ContentType = "application/json";
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                context.Result = new JsonResult(context.Exception as ValidationException);
                return;
            }

            var code = HttpStatusCode.InternalServerError;

            //if (context.Exception is NotFoundException)
            //{
            //    code = HttpStatusCode.OK;
            //}
            //else if (context.Exception is UnauthorizedAccessException)
            //{
            //    code = HttpStatusCode.Unauthorized;
            //}
            //else if (context.Exception is DuplicatedException)
            //{
            //    code = HttpStatusCode.OK;
            //}
            //else if (context.Exception is NoticeException)
            //{
            //    code = HttpStatusCode.OK;
            //}
            //else if (context.Exception is InfoException)
            //{
            //    context.HttpContext.Response.ContentType = "application/json";
            //    context.HttpContext.Response.StatusCode = (int)HttpStatusCode.OK;
            //    context.Result = new JsonResult(new
            //    {
            //        ResultCode = 100,
            //        ResultMessage = context.Exception.Message,
            //        ResultObject = new JsonResult(new
            //        {
            //            ApprovedName = context.Exception.Source
            //        }).Value
            //    });
            //    return;
            //}

            context.HttpContext.Response.ContentType = "application/json";
            context.HttpContext.Response.StatusCode = (int)code;
            context.Result = new JsonResult(new
            {
                ResultCode = -1,
                ResultMessage = context.Exception.Message,
                ResultObject = new List<string>()
            });
        }
    }
}
