using System.Diagnostics;

namespace EMeas_Exercise4_CSharpReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InputSwitch();
            ArraysAndLoops();
        }

        private static void InputSwitch()
        {
            Console.WriteLine("Input a WASD key");
            char inputKey = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            switch (inputKey)
            {
                case 'W':
                    Console.WriteLine("You moved up");
                    break;
                case 'S':
                    Console.WriteLine("You moved down");
                    break;
                case 'A':
                    Console.WriteLine("You moved left");
                    break;
                case 'D':
                    Console.WriteLine("You moved right");
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter W, A, S, or D.");
                    break;
            }
        }

        private static void ArraysAndLoops()
        {
            int[] intArray = { 100, 94, 159, -783, 132, 179, 47, 107, 135, 50 };

            // Starts the loop from the array length, and goes backwards, showing it in reverse order
            for (int i = intArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(intArray[i]);
            }

            Console.Write("Enter a whole number: ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int userInput))
                {
                    if (Array.Exists(intArray, num => num == userInput))
                    {
                        Console.WriteLine("Number found! Exiting loop...");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Number not found! Try again...");
                    }
                }

                else
                {
                    Console.WriteLine("Not a valid input. Try again...");
                }
            }

            int amount = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                amount += intArray[i];
            }
            float average = (float)amount / (float)intArray.Length;
            Console.WriteLine("The average of the array is: " + average);

            for (int i = 0; i < intArray.Length; i++)
            {
                if (i % 2 != 0) continue;
                Console.WriteLine(intArray[i]);
            }

            for (int i = 0; i < intArray.Length; i++)
            {
                if (i % 3 != 0) continue;
                Console.WriteLine(intArray[i]);
            }

            Console.Write("Enter an array size: ");
            int arraySize = int.Parse(Console.ReadLine());

            Console.Write("Enter a minimum range value: ");
            int rangeMin = int.Parse(Console.ReadLine());

            Console.Write("Enter a maximum range value: ");
            int rangeMax = int.Parse(Console.ReadLine());

            int[] randomArray = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                Random rnd = new Random();
                randomArray[i] = rnd.Next(rangeMin, rangeMax);
            }

            foreach (int num in randomArray)
            {
                Console.WriteLine(num);
            }
        }

        private static void OutputIntArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.WriteLine(num);
            }
        }

        private static void OutputArray(float[] array)
        {
            foreach (float num in array)
            {
                Console.WriteLine(num);
            }
        }

        private static void OutputArray(double[] array)
        {
            foreach (double num in array)
            {
                Console.WriteLine(num);
            }
        }

        private static float CalculateArrayAvg(int[] array)
        {
            int value = 0;
            for(int i = 0; i < array.Length; i++)
            {
                value += array[i];
            }
            return (float)value / array.Length;
        }

        private static float AverageArray(float[] array)
        {
            float value = 0;
            for (int i = 0; i < array.Length; i++)
            {
                value += array[i];
            }
            return value / array.Length;
        }

        private static double AverageArray(double[] array)
        {
            double value = 0;
            for (int i = 0; i < array.Length; i++)
            {
                value += array[i];
            }
            return value / array.Length;
        }

        private static int[] CreateRandomArray(int arraySize, int rangeMin, int rangeMax)
        {
            int[] randomArray = new int[arraySize];
            Random random = new Random();

            for (int i = 0; i < arraySize; i++)
            {
                randomArray[i] = random.Next(rangeMin, rangeMax);
            }
            return randomArray;
        }
    }
}
