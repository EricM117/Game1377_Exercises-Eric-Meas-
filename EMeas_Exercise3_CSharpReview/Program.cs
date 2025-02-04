using System.Collections;

namespace EMeas_Exercise3_CSharpReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OutputtingStrings();
            ArithmeticOutput();
            AssignmentOutput();
            ComparisonsAndConditionals();
        }

        private static void OutputtingStrings()
        {
            string sentence01 = "I’m in Game 1377: Scripting for Game Designers.";
            string sUpper = sentence01.ToUpper();
            string sLower = sentence01.ToLower();
            string sPartialWord01 = sentence01.Substring(8);
            string sPartialWord02 = sentence01.Substring(8, 11);
            char sLetter1 = sentence01[8];
            Console.WriteLine(sentence01);
            Console.WriteLine(sUpper);
            Console.WriteLine(sLower);
            Console.WriteLine(sPartialWord01);
            Console.WriteLine(sPartialWord02);
            Console.WriteLine(sLetter1);
        }

        private static void ArithmeticOutput()
        {
            Console.Write("Enter the 1st whole number: ");
            int intInput1 = Convert.ToInt32(Console.ReadLine()); // Using Convert class and the ToInt32 method to take in a integer input
            Console.Write("Enter the 2nd whole number: ");
            int intInput2 = Convert.ToInt32(Console.ReadLine());
            double division = (double)intInput1 / intInput2;
            Console.WriteLine(intInput1 + intInput2);
            Console.WriteLine(intInput1 - intInput2);
            Console.WriteLine(intInput1 * intInput2);
            Console.WriteLine(division);
            Console.WriteLine(intInput1 % intInput2);
        }

        private static void AssignmentOutput()
        {
            Console.Write("Enter the 1st number: ");
            float floatInput1 = float.Parse(Console.ReadLine()); // Using Parse method to take in a float input, looked it up
            Console.Write("Enter the 1st number: ");
            float floatInput2 = float.Parse(Console.ReadLine()); 
            floatInput2 = floatInput1 + floatInput2;
            Console.WriteLine(floatInput2);
            floatInput2 = floatInput2 - floatInput1;
            Console.WriteLine(floatInput2);
            floatInput2 = floatInput1 * floatInput2;
            Console.WriteLine(floatInput2);
            floatInput2 = floatInput2 / floatInput1;
            Console.WriteLine(floatInput2);
        }

        private static void ComparisonsAndConditionals()
        {
            Console.Write("Enter the 1st whole number: ");
            int intInput1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 2nd whole number: ");
            int intInput2 = Convert.ToInt32(Console.ReadLine());

            if (intInput1 > intInput2)
            {
                Console.WriteLine(intInput1 + " is greater than " + intInput2);
            }

            if (intInput1 < intInput2)
            {
                Console.WriteLine(intInput2 + " is greater than " + intInput1);
            }

            if (intInput1 == intInput2)
            {
                Console.WriteLine(intInput1 + " is equal to " + intInput2);
            }
        }
    }
}
