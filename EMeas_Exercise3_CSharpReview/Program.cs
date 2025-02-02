namespace EMeas_Exercise3_CSharpReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence01 = "I’m in Game 1377: Scripting for Game Designers.";
            string sUpper = sentence01.ToUpper();
            string sLower = sentence01.ToLower();
            string sPartialWord01 = sentence01.Substring(8);
            string sPartialWord02 = sentence01.Substring(8, 11);
            Console.WriteLine(sentence01);
            Console.WriteLine(sUpper);
            Console.WriteLine(sLower);
            Console.WriteLine(sPartialWord01);
            Console.WriteLine(sPartialWord02);
        }
    }
}
