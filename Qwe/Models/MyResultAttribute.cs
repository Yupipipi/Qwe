using System.Web.Mvc;

namespace Qwe.Models
{
    public class MyResultAttribute : FilterAttribute, IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext filterContext)
        {

            filterContext.HttpContext.Response.Write("Время текущего запроса HTTP: " + filterContext.HttpContext.Timestamp);
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {

            filterContext.HttpContext.Response.Write("Текущий пользователь" + filterContext.HttpContext.Request.UserHostAddress);
        }
    }
}