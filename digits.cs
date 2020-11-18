

using System;

class digits
{
    static void Main()
    {
        int oneDigitCounter = 0, twoDigitsCounter = 0, threeDigitsCounter = 0;
        int moreDigitsCounter = 0;
        
        Console.Write("Insert a number: ");
        string input = Console.ReadLine();
        
        while( input != "end" )
        {
            int inputConverted = Convert.ToInt32(input);
            
            if(inputConverted != 0)
            {
                if( inputConverted / 10 == 0 )
                {
                    oneDigitCounter ++;  // it only has one digit
                }
                else 
                {
                    if ( inputConverted / 100 == 0 )
                    {
                        twoDigitsCounter ++;  // the number has 2 digits
                    }
                    else
                    {
                        if ( inputConverted / 1000 == 0 )
                        {
                            threeDigitsCounter ++;  // the number has 3 digits
                        }
                        else
                        {
                            moreDigitsCounter++;  // the number has more than 3 digits
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

