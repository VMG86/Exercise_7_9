//Cleaning code exercise 1
//Code purpose: calculate the average of a set of marks, until the user types
//“end”.

using System;

public class Average
{
    public static void Main()
    {
        string input;
        double sumInput = 0, countInput = 0, inputConverted, result;
        
        Console.Write("Insert a mark: ");
        input = Console.ReadLine();
        
        while( input != "end" )
        {
            inputConverted = Convert.ToDouble(input);
            countInput++;
            sumInput += inputConverted;
            Console.Write("Insert a mark: ");
            input = Console.ReadLine();
        }
        
        if( countInput != 0 )
        {
            result = sumInput / countInput;
            Console.WriteLine("The average is {0}.", result);
        }
        
    }
}
