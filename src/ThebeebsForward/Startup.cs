using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;

namespace ThebeebsForward
{
    public class Startup
    {
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IApplicationBuilder app)
        {
            app.Run(async (context) =>
            {
                context.Response.Redirect("https://blogs.msdn.microsoft.com/thebeebs/");
                await context.Response.WriteAsync("Forwarding to blog https://blogs.msdn.microsoft.com/thebeebs/");
            });
        }
    }
}
