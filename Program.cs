using System;

namespace First_Script
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///////////// Types \\\\\\\\\\\\\\
            // string --> AmIrReZa           |
            // char --> A                    |
            // int --> 1,2,3,4,5,6,7,8,9     |
            // float --> 1,2,3,4,5,6,7,8,9   |
            // double --> 1.1, 2.2, 3.3, ... |
            // decimal --> 1,2,3,4,5,6,7,8,9 |
            // bool --> true or false        |
            ////////////////\\\\\\\\\\\\\\\\\\


            ////////////// String \\\\\\\\\\\\\\
            string example = "Example";                      // --> Defult string
            Console.WriteLine(example.Length);               // --> Get count                --> Output : 7
            Console.WriteLine(example.ToUpper());            // --> Upper case               --> Output : EXAMPLE
            Console.WriteLine(example.ToLower());            // --> Lower case               --> Output : example
            Console.WriteLine(example.Contains("Example"));  // --> Find string              --> Output : True
            Console.WriteLine(example[0]);                   // --> Index of string          --> Output : E
            Console.WriteLine(example.IndexOf("E"));         // --> Find index               --> Output : 0
            Console.WriteLine(example.Substring(4));         // --> Cut string               --> Output : ple 
            Console.WriteLine(example.Substring(4, 3));      // --> Cut string by numer      --> Output : ple 


            ////////////// Numbers \\\\\\\\\\\\\\
            Console.WriteLine(5 + 8);                     // --> Addition                 --> Output : 13
            Console.WriteLine(5 - 8);                     // --> Subtraction              --> Output : -3
            Console.WriteLine(5 / 8);                     // --> Division                 --> Output : 0
            Console.WriteLine(5 * 8);                     // --> Multiplication           --> Output : 40
            Console.WriteLine(5 % 8);                     // --> Percentage               --> Output : 5


            ////////////// Input \\\\\\\\\\\\\\
            Console.WriteLine("Hi,");
            Console.Write("Enter your name : ");

            string name = Console.ReadLine();             // --> Get input (Name)
            Console.WriteLine("Hello " + name);           // --> Say Hi
            Console.Write("Enter your age : ");

            string age = Console.ReadLine();              // --> Get input (Age)
            Console.WriteLine("Oh your are " + age);      // --> Say age of input
            Console.ReadLine();

            ////////////// try & catch & finally \\\\\\\\\\\\\\
            try {
                Console.Write("Don't Enter Number :");
                int user_text = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(user_text);             // --> Print your number          --> Output : your text
            } catch (Exception error) {
                Console.WriteLine(error.Message);         // --> Print error message        --> Output : Input string was not in a correct format.
            } finally {
                Console.WriteLine("Your Answer Sent !");
            }

            ////////////// Arrays \\\\\\\\\\\\\\
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };      // --> Tables
            //                0  1  2  3  4  5  6
            Console.WriteLine(numbers[6]);                // Output : 7

            int[,] new_numbers = { // 2D
                {1, 2},
                {3, 4},
                {4, 5},
            };

            Console.WriteLine(new_numbers[2, 1]);      // Output :  3
            ////////////// Run Functions \\\\\\\\\\\\\\
            SayInformation(name, Convert.ToInt16(age));  // --> Age need to convert because (In past is string, but now we need int)
            int F_Cube = Cube(5);
            Console.WriteLine(F_Cube);                    // --> Cube Of 5                --> Output : 125


            ////////////// if \\\\\\\\\\\\\\
            bool status = true;
            if (status) {
                Console.WriteLine("Status is true !");
            } else {
                Console.WriteLine("Status is false !");
            }

            ///////////// States \\\\\\\\\\\\\
            // && --> and                    |
            // || --> or                     |
            // ! --> not                     |
            ////////////////\\\\\\\\\\\\\\\\\\


            ////////////// Switch \\\\\\\\\\\\\\
            string get_number = GetNumber(1);
            Console.WriteLine(get_number);               // --> Choose number text        --> Output : first number !


            ////////////// While \\\\\\\\\\\\\\
            int index = 6;
            do
            {
                Console.WriteLine(index);               // --> Check then while          --> Output : 6
                index++;
            } while (index <= 5);

            ////////////// For \\\\\\\\\\\\\\
            int[] numtables = { 4, 8, 9, 78, 65, 35, 60, 83 };
            for(int i = 0; i <= numtables.Length; i++)                // --> Print numbers
            {
                Console.WriteLine(numtables[i]);
            }

        }


        ////////////// Functions \\\\\\\\\\\\\\

        /// <summary>
        /// This is for information
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        static void SayInformation(string name, int age)           // --> Function Say Information
        {
            Console.WriteLine("\nName: "+ name +"\nAge: "+ age +"\nThis Line Write With Function !");
        }

        /// <summary>
        /// This is for cube
        /// </summary>
        /// <param name="number"></param>
        static int Cube(int number)                                // --> Function To Cube Number
        {
            int result = number * number * number;
            return result;
        }

        /// <summary>
        /// This is for get number text
        /// </summary>
        /// <param name="number"></param>
        static string GetNumber(int number)                       // --> Function To Get Number Text
        {
            string result;
            switch (number)
            {
                case 1:
                    result = "first number !";
                break;
                case 2:
                    result = "secend number !";
                break;
                default:
                    result = "wrong !";
                break;
            }
            return result;
        }    
    }
}
