namespace Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number to convert to words");
            string number = Console.ReadLine();
            number = NumbersToWords.ConvertAmount(double.Parse(number));

            Console.WriteLine("Number in words is \n{0}", number);
            Console.ReadKey();
        }  
     
    }
}
