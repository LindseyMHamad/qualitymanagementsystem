using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;
using CsvHelper;
using System.Globalization;
using System.IO;
using CsvHelper.Configuration;

namespace QualityManagementSystem
{
    public class Parts
    {

       

        public string AssemblyId { get; set; }
        //  [Index(1)]
        public string AssemblyName { get; set; }
        // [Index(2)]
        public string Revision { get; set; }



        

        public static void ReadAssembliesFromList()
        {
            var lines = System.IO.File.ReadAllLines(@"assemblies.csv");

            //var lines = File.ReadAllLines("assemblies.csv");
            var list = new List<Parts>(); // this will be the list of out assemblies
            foreach (var line in lines)
            {
                var values = line.Split(',');
                var assembly = new Parts() { AssemblyId = values[0], AssemblyName = values[1], Revision = values[2] }; // mapping back to the class
                list.Add(assembly); //adding the assemblies to the list

            }
            list.ForEach(x => Console.WriteLine($"{x.AssemblyId}\t{x.AssemblyName}\t{x.Revision}")); //print the list of all of our records from our assemblies object
        }


    }
}
