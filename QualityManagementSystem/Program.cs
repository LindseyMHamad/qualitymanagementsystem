using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QualityManagementSystem
{
    class Program
    {
        static void Main(string[] args)

        {
            string userinput;
            string UppercaseUserInput;
            bool endApp = false;
            string sparePartsUserInput;
            double metricConversion = 0.0254;
            DateTime scheduleMaintenance;

            Console.WriteLine("Please enter the number to the option you would like to do!");
            Console.WriteLine("Enter Part to enter a new part,  Enter employee to enter a new employee, enter tool to enter a new tool or break to exit.", Environment.NewLine);
            
            //User Inputs: 
            userinput = Console.ReadLine();
            UppercaseUserInput = userinput.ToUpper();
            


            var sparepartslist = new Machine("name", 0, 0, 0, DateTime.Today);

            {
                while (!endApp)
                {
                    if (UppercaseUserInput == "LIST")
                    {



                        Console.WriteLine("Enter ADD to add item to list or STOP to exit program.");

                        sparePartsUserInput = Console.ReadLine();
                        while (sparePartsUserInput != "STOP")
                        {
                            Console.WriteLine("Enter ADD to add item to list or STOP to exit program.");
                            sparePartsUserInput = Console.ReadLine();
                            if (sparePartsUserInput == "ADD")
                            {

                                Console.WriteLine("Enter Qty");
                                var quantity = decimal.Parse(Console.ReadLine());

                                Console.WriteLine("Enter the Name");
                                var nameofpart = Console.ReadLine();

                                Console.WriteLine("Enter the precision in inches");
                                var precision = double.Parse(Console.ReadLine());

                                var percisionMetric = precision * metricConversion;

                                scheduleMaintenance = DateTime.Today.AddDays(90);

                                sparepartslist.addToList(quantity, nameofpart, precision, percisionMetric, DateTime.Today, scheduleMaintenance);
                            }

                            else if (sparePartsUserInput == "STOP")
                            { break; }


                            
                        }

                        
                    }
                    else if (UppercaseUserInput == "EMPLOYEE")
                    {


                        Console.WriteLine(sparepartslist.listofSparePartsPrint());

                    }
                    else if (UppercaseUserInput == "TOOL")
                    {
                        Console.WriteLine("U picked tool");
                    }
                    
                    else if (UppercaseUserInput == "READ")
                    {
                        Parts.ReadAssembliesFromList();

                    }
                    else if (UppercaseUserInput == "BREAK")
                    {
                        break;
                    }
                    Console.WriteLine("Enter Part to enter a new part,  Enter employee to enter a new employee, enter tool to enter a new tool or break to exit.");
                    userinput = Console.ReadLine();
                    UppercaseUserInput = userinput.ToUpper();
                    if (UppercaseUserInput == "BREAK")
                    { break; }


                }

            }






        }
    }
}
