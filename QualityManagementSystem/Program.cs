﻿using System;

namespace QualityManagementSystem
{
    class Program
    {
        static void Main(string[] args)

        {
            string userinput;
            string UppercaseUserInput;
            bool endApp = false;

            Console.WriteLine("Please enter the number to the option you would like to do!");
            Console.WriteLine("Enter Part to enter a new part,  Enter employee to enter a new employee, enter tool to enter a new tool or break to exit.", Environment.NewLine);
            
            //User Inputs: 
            userinput = Console.ReadLine();
            UppercaseUserInput = userinput.ToUpper();


            {
                while (!endApp)
                {
                    if (UppercaseUserInput == "PART")
                    {
                        Console.WriteLine("You picked Part");
                        
                    }
                    else if (UppercaseUserInput == "EMPLOYEE")
                    {
                        Console.WriteLine("You picked Employee!");
                    }
                    else if (UppercaseUserInput == "TOOL")
                    {
                        Console.WriteLine("You picked Employee!");
                    }
                    else if (UppercaseUserInput == "ASSEMBLY")
                    {
                      

                        Assmblies program = new Assmblies();
                        program.CreateAssembly();
                        program.AddAssembliesToList();

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
