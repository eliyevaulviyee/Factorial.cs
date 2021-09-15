using System;
public class Program
{
	public static void Main()
	{
	    int factorial=1;
	    Console.Write("Enter number: ");
	    int a=int.Parse(Console.ReadLine());
        if(a<=0)
        {
            Console.WriteLine("An Error Ocurred!");
            Console.ReadLine();
        }
        else
        {
            for(int i=1;i<=a;i++)
            {
                factorial=factorial*i;
            }
            Console.WriteLine(factorial);
            Console.ReadLine();
            Console.WriteLine("Factroial Calculated Successfully!");
            Console.ReadLine();
        }
	}
}
