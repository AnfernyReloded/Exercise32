using System;
using System.Linq;

namespace Ex32_finding_and_comparing_values
{
    class Program
    {

        static public int Compare_to(int cc)
        {
            int[] arr = { 2, 8, 0, 24, 51 };

            
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == cc)
                    {
                        return i;
                    }
                }
             
                return -1;
            
        }


        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a number ");
                string userinput = Console.ReadLine();


                int passnum;



                if (!int.TryParse(userinput, out passnum))
                {
                    Console.WriteLine("That value cannot be found in the array");
                    continue;
                }

                int num_out = passnum;
                var final_output = Compare_to(passnum);

                //if (passnum == false) then return " That value cannot be found in the array"
                if (final_output == -1)
                {
                    Console.WriteLine("That value cannot be found in the array");
                }

                else
                    
                {
                    Console.WriteLine("The value " + num_out + " can be found at index " + final_output);
                }






                Console.WriteLine("Would you like to continue Y or N?");
                string user_choice = Console.ReadLine().ToLower();

                if (user_choice != "y")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
            }
        }
    }
}
