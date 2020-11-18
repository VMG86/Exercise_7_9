//Cleaning code exercise 2
//Code purpose: Calculates how many numbers of 1, 2, 3 or more digits are 
//entered by the user until he/she types “end”

using System;

class Digits
{
    static void Main()
    {
        string input;
        int inputConverted;
        int oneDigitCounter = 0, twoDigitsCounter = 0, threeDigitsCounter = 0;
        int moreDigitsCounter = 0;
        
        Console.Write("Insert a number: ");
        input = Console.ReadLine();
        
        while( input != "end" )
        {
            inputConverted = Convert.ToInt32(input);
            
            if(inputConverted != 0)
            {
                if( inputConverted / 10 == 0 )
                {
                    oneDigitCounter ++;
                }
                else 
                {
                    if ( inputConverted / 100 == 0 )
                    {
                        twoDigitsCounter ++;
                    }
                    else
                    {
                        if ( inputConverted / 1000 == 0 )
                        {
                            threeDigitsCounter ++;
                        }
                        else
                        {
                            moreDigitsCounter++;
                        }
                    }
                }
                input = Console.ReadLine();
                }
            }
            Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", 
                oneDigitCounter, twoDigitsCounter, threeDigitsCounter, 
                moreDigitsCounter); 
    }
}

