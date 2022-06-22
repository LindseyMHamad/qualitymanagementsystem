using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;
using CsvHelper;
using System.Globalization;
using System.IO;



namespace QualityManagementSystem
{
    public class Assmblies
    {
     //   [Name("Indentifier")]
        //[Index(0)]
        public int AssemblyId { get; set; }
      //  [Index(1)]
        public string AssemblyName { get; set; }
       // [Index(2)]
        public string Revision { get; set; }

        public void CreateAssembly()
        {
            Console.WriteLine("Enter the Assembly ID");
            AssemblyId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the assembly name.");
            AssemblyName = Console.ReadLine();

            Console.WriteLine("Enter the revision?");
            Revision = Console.ReadLine();
        }

        public void AddAssembliesToList()
        {
            List<Assmblies> assembly = new List<Assmblies>();
            assembly.Add(new Assmblies() { AssemblyId = AssemblyId, AssemblyName = AssemblyName, Revision = Revision });

            foreach (Assmblies assemblies in assembly)
            {
                Console.WriteLine(AssemblyId);
            }

            using (var writer = new StreamWriter(@"C:\Users\Lhamad\Desktop\QualityManagementSystem\assemblies.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(assembly);
            }
        }


    }
}
