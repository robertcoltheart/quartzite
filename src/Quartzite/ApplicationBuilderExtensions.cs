using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Quartzite.Middleware;

namespace Quartzite;

public static class ApplicationBuilderExtensions
{
    public static void UseQuartzite(this IApplicationBuilder builder, string prefix = "")
    {
        builder.Map(new PathString(prefix), x => x.UseMiddleware<DashboardMiddleware>());
    }
}
