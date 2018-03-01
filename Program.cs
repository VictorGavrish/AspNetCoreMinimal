using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace AspnetcoreHelloworld
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            WebHost.CreateDefaultBuilder().Configure(app => app.Run(async (context) => await context.Response.WriteAsync("Hello World!"))).Build().Run();
        }
    }
}
