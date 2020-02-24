using System;
public class buricmarioprovjeraznjana2zadatak
{
    public static void Main()
    {
        int num1, num2, num3;
        Console.Write("\n\n");
        Console.Write("Pronadi najveci broj od 3 zadanih:\n");
        Console.Write("\n\n");

        Console.Write("unesi prvi broj :");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("unesi drugi broj :");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("unesi 3 broj :");
        num3 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
        {
            if (num1 > num3)
            {
                Console.Write("The 1st Number is the greatest among three. \n\n");
            }
            else
            {
                Console.Write("The 3rd Number is the greatest among three. \n\n");
            }
        }
        else if (num2 > num3)
            Console.Write("The 2nd Number is the greatest among three \n\n");
        else
            Console.Write("The 3rd Number is the greatest among three \n\n");
    }
}