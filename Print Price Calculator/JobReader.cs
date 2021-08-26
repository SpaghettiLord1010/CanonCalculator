using CsvHelper;
using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Price_Calculator
{
    class JobReader
    {
        public static List<JobRecord> ReadJobs(string[] filenames)
        {

            List<JobRecord> output = new List<JobRecord>();

            foreach (string file in filenames)
            {

                using (var reader = new StreamReader(file))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    output.AddRange(csv.GetRecords<JobRecord>().ToList());
                }
            }

            return output;
        }
    }

    public class JobRecord
    {
        [Name("Cost")]
        public string TotalCost { get; set; }

        [Name("Paper Cost")]
        public string PaperCost { get; set; }

        [Name("Total Ink Cost")]
        public string InkCost { get; set; }

        [Name("Total of Other Costs")]
        public string OtherCost { get; set; }

        [Name("Printing Results")]
        public string Results { get; set; }

        [Name("Media Type")]
        public string Paper { get; set; }

        [Name("Paper Consumed [square meter]")]
        public string PaperUsed { get; set; }

        [Name("Print Quality")]
        public string Quality { get; set; }

        [Name("Ink Consumed [ml]")]
        public string InkUsed { get; set; }

        [Name("Ink Consumption Details(Matte Black)")]
        public string InkUsed_MB { get; set; }

        [Name("Ink Consumption Details(Photo Black)")]
        public string InkUsed_PB { get; set; }

        [Name("Ink Consumption Details(Gray)")]
        public string InkUsed_G { get; set; }

        [Name("Ink Consumption Details(Photo Gray)")]
        public string InkUsed_PG { get; set; }

        [Name("Ink Consumption Details(Cyan)")]
        public string InkUsed_C { get; set; }

        [Name("Ink Consumption Details(Magenta)")]
        public string InkUsed_M { get; set; }

        [Name("Ink Consumption Details(Yellow)")]
        public string InkUsed_Y { get; set; }

        [Name("Ink Consumption Details(Photo Cyan)")]
        public string InkUsed_PC { get; set; }

        [Name("Ink Consumption Details(Photo Magenta)")]
        public string InkUsed_PM { get; set; }

        [Name("Ink Consumption Details(Red)")]
        public string InkUsed_R { get; set; }

        [Name("Ink Consumption Details(Blue)")]
        public string InkUsed_B { get; set; }

        [Name("Ink Consumption Details(Chroma Optimizer)")]
        public string InkUsed_CO { get; set; }

        [Name("Ink Cost Details(Matte Black)")]
        public string InkCost_MB { get; set; }

        [Name("Ink Cost Details(Photo Black)")]
        public string InkCost_PB { get; set; }

        [Name("Ink Cost Details(Gray)")]
        public string InkCost_G { get; set; }

        [Name("Ink Cost Details(Photo Gray)")]
        public string InkCost_PG { get; set; }

        [Name("Ink Cost Details(Cyan)")]
        public string InkCost_C { get; set; }

        [Name("Ink Cost Details(Magenta)")]
        public string InkCost_M { get; set; }

        [Name("Ink Cost Details(Yellow)")]
        public string InkCost_Y { get; set; }

        [Name("Ink Cost Details(Photo Cyan)")]
        public string InkCost_PC { get; set; }

        [Name("Ink Cost Details(Photo Magenta)")]
        public string InkCost_PM { get; set; }

        [Name("Ink Cost Details(Red)")]
        public string InkCost_R { get; set; }

        [Name("Ink Cost Details(Blue)")]
        public string InkCost_B { get; set; }

        [Name("Ink Cost Details(Chroma Optimizer)")]
        public string InkCost_CO { get; set; }

    }
}
