using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SqlData;

namespace SqlData
{
    public static class DbAccess
    {
        public static void getContext()
        {
            string constring = File.ReadAllText("/Revature/Sql/connectionstring.txt");

            using var logStream = new StreamWriter("ef-logs.txt", append: false) { AutoFlush = true };

            DbContextOptions<project0Context> options = new DbContextOptionsBuilder<project0Context>().UseSqlServer(constring).LogTo(logStream.WriteLine, minimumLevel: LogLevel.Information).Options;

            using var context = new project0Context(options);
        }



    }
}
