class Solution
{
    public static void Main(string[] args)
    {
        int n;
        Console.WriteLine("Lütfen değer giriniz : ");
        n = Convert.ToInt32(Console.ReadLine().Trim());
        Result.fizzBuzz(n);
        Console.ReadKey();
    }
}
class Result
{
    public static void fizzBuzz(int value)
    {
      
        for (int i = 1; i <=value; i++)
        {
            if (i%3 == 0 && i % 5==0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0 && i % 5 != 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0 &&  i % 3 != 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (i % 3 != 0 &&i % 5 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }

}
