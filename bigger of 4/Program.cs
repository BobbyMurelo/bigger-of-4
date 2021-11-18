using System;

class TheBiggestOfFourNumbers
{
    static void Main()
    {
        Console.WriteLine("Please write 4 numbers:");
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        decimal c = decimal.Parse(Console.ReadLine());
        decimal d = decimal.Parse(Console.ReadLine());
        

        if ((a >= b) && (a >= c) && (a >= d))
        {
            Console.WriteLine("The biggest number is: {0}", a);
            return;
        }
        if ((b >= a) && (b >= c) && (b >= d) && (b >= c))
        {
            Console.WriteLine("The biggest number is: {0}", b);
            return;
        }
        if ((c >= a) && (c >= b) && (c >= d))
        {
            Console.WriteLine("The biggest number is: {0}", c);
            return;
        }
        if ((d >= a) && (d >= b) && (d >= c))
        {
            Console.WriteLine("The biggest number is: {0}", d);
            return;
        }
     
    }
}
