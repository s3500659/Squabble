using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Squabble.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squabble.Server.UnitTests
{
    public static class Utilities
    {
        public static IConfigurationRoot GetIConfiguration()
        {
            var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            return config;
        }

        public static SquabbleContext GetDbContext()
        {
            // change this to your testing database.
            var url = "Data Source=VINH-PC;Initial Catalog=SquabbleTest;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            var options = new DbContextOptionsBuilder<SquabbleContext>()
                .UseSqlServer(url)
                .Options;
            var context = new SquabbleContext(options);

            return context;
        }
    }
}
