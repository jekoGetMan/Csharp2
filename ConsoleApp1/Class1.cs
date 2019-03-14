using System;

public class Class1
{
	public class Number
	{
        private System.Random random = new System.Random();
        private int hiddenNumber;
        public Number()
        {
            hiddenNumber = random.Next();
        }
        public void higherOrLower(int hLGuess)
        {
            if (hLGuess == hiddenNumber)
            {
                System.Console.WriteLine("Holy shit you guessed it!");
            }
            else
            {
                if (hLGuess < hiddenNumber)
                {
                    System.Console.WriteLine("Higher");
                }
                else
                {
                    System.Console.WriteLine("Lower");
                }
            }
        }
        public int returnNumber()
        {
            return hiddenNumber;
        }
    }
	}



