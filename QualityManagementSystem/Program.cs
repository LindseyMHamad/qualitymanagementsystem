using System;
using System.Collections.Generic;

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
            string listUserInput;

            Console.WriteLine("Please enter the number to the option you would like to do!");
            Console.WriteLine("Enter Part to enter a new part,  Enter employee to enter a new employee, enter tool to enter a new tool or break to exit.", Environment.NewLine);
            
            //User Inputs: 
            userinput = Console.ReadLine();
            UppercaseUserInput = userinput.ToUpper();
            


            var sparepartslist = new Machine("name", 0, 0);

            {
                while (!endApp)
                {
                    if (UppercaseUserInput == "LIST")
                    {
                       
                        


                        
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
                                var precision = decimal.Parse(Console.ReadLine());


                                sparepartslist.addToList(quantity, nameofpart, precision, DateTime.Now);
                            }

                            else if (sparePartsUserInput == "STOP")
                            { break; }

                            

                        }

                        
                    }
                    else if (UppercaseUserInput == "EMPLOYEE")
                    {
                        
                        Console.WriteLine(sparepartslist.listofspareparts);

                       
                    }
                    else if (UppercaseUserInput == "TOOL")
                    {
                        Console.WriteLine("You picked Tool!");
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
