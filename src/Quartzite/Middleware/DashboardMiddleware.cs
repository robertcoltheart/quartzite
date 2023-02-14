using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Quartzite.Middleware;

public class DashboardMiddleware : IMiddleware
{
    public Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        throw new System.NotImplementedException();
    }
}
