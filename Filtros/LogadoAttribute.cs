using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;

namespace admin_cms.Models.Infraestrutura.Autenticacao
{
  public class LogadoAttribute : ActionFilterAttribute
  {
    public override void OnActionExecuting(ActionExecutingContext filterContext)
    {
      if( string.IsNullOrEmpty(filterContext.HttpContext.Request.Cookies["smk_travel"]) ){
        filterContext.HttpContext.Response.Redirect("/login");
        return;
      }
      base.OnActionExecuting(filterContext);
    }
  }
}