using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using coreWithSqlLite.Model;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace coreWithSqlLite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //using (var db = new BloggingContext())
            //{
            //    db.Blogs.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
            //    var count = db.SaveChanges();
            //    Console.WriteLine("{0} records saved to database", count);

            //    Console.WriteLine();
            //    Console.WriteLine("All blogs in database:");
            //    foreach (var blog in db.Blogs)
            //    {
            //        Console.WriteLine(" - {0}", blog.Url);
            //    }
            //}
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                 .UseKestrel((context, options) =>
                 {
                     var port = Environment.GetEnvironmentVariable("PORT");
                     if (!string.IsNullOrEmpty(port))
                     {
                         options.ListenAnyIP(int.Parse(port));
                     }
                 });


    }
}
