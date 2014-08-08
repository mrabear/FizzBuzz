using System.Diagnostics;

class FizzBuzz
{
    static void Main()
    {
        Debug.WriteLine("\n############## Starting FizzBuzz ##############");

        for (int lc = 1; lc <= 100; lc++)
        {
            if (lc % 3 == 0 && lc % 5 == 0)
                Debug.WriteLine("FizzBuzz");
            else if (lc % 3 == 0 )
                Debug.WriteLine("Fizz");
            else if (lc % 5 == 0)
                Debug.WriteLine("Buzz");
            else
                Debug.WriteLine(lc);
        }

        Debug.WriteLine("############## Done with FizzBuzz, sucka ##############\n");
    }
}
