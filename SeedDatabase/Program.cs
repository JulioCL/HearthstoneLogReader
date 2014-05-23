using HearthstoneLogData.DAL;
using HearthstoneLogData.Models;
using HearthstoneLogReader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeedDatabase
{
    class Program
    {
        static void Main(string[] args)
        {

            //Open up our database
            HearthstoneLogDataContext context = new HearthstoneLogDataContext();

            Console.WriteLine("DB initialized and open.");
            Console.WriteLine("");

            //var match = new Match { MatchStart = DateTime.Now, MatchEnd = DateTime.Now };

            //context.Matches.Add(match);
            //context.SaveChanges();

            //Console.WriteLine("New match added.");
            //Console.WriteLine("");

            //Console.WriteLine("All matches in the db:");

            //var query = from b in context.Matches
            //                orderby b.MatchStart
            //                select b;

            //foreach (var item in query)
            //{
            //    Console.WriteLine(String.Format("Start Time: {0} End Time: {1}", item.MatchStart, item.MatchEnd));
            //}

            LogReader lr = new LogReader();
            lr.FilePath = @"C:\Users\jakez834\Documents\GitHub\HearthstoneLogReader\HearthstoneLogReader\sample_data\output_log.txt";

            lr.StartReadLog();

            Console.WriteLine("");
            Console.WriteLine("Press enter to exit...");

            Console.ReadLine();
        }
    }
}
