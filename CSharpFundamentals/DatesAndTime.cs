using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    public class DatesAndTime
    {
        public void DatesNTime()
        {
            //DateTime examples
            var datetime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine(now.Hour);
            Console.WriteLine(now.Minute);


            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));

            //TimeSpan examples
            var timespan = new TimeSpan(1, 2, 3);
            var timespan1 = new TimeSpan(1, 0, 0);
            var timespan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration " + duration);

            //Properties
            Console.WriteLine("Minutes " + timespan.Minutes);
            Console.WriteLine("Minutes " + timespan.TotalMinutes);

            //Add
            Console.WriteLine("Add Examples: " + timespan.Add(TimeSpan.FromMinutes(8)));

            //Subtract
            Console.WriteLine("Add Examples: " + timespan.Subtract(TimeSpan.FromMinutes(2)));

            //ToString
            Console.WriteLine("ToString " + timespan.ToString());

            //Parse
            Console.WriteLine("Parse " + TimeSpan.Parse("01:02:03"));
        }
    }
}
