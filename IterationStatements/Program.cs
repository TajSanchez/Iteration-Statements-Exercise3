namespace IterationStatements
{
    public class Program
    {
        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            MyNumbers();
            CountByThree();
            TwoNumbers(3,3);
            EvOrOdd(79);
            PosOrNeg(46);
            GiveMeANumber();
            Multiply();
            OldEnough();
        }

        //LukeWarm Section: Create methods below
        // step 1 Write a method
        // step 2 that will print to the console all numbers
        // step 3 -1000 through +1000

        static void MyNumbers()
        {
            for (int i = -1000; i <= 1000 ; i++) 
            {
                Console.WriteLine(i);
            }
        }

        // Step 1 Write a method
        // Step 2 That will print to the console numbers 3 through 999
        // Step 3 By 3 each time
        static void CountByThree()
        {
            for(int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        // Step 1 Write a method
        // Step 2 To accept two integers as parameterss
        // Step 3 And check whether they are equal or not
          
        static void TwoNumbers(int x, int y)
        {
            if (x == y)
            {
                Console.WriteLine($"{x} and {y} are equal");
            }
            else
            {
                Console.WriteLine($"{x} and {y} are not equal");
            }
        }

        //Write a method to check whether a given number is even or odd
        static void EvOrOdd(int a)
        {
            if (a % 2 == 0)
            {
              Console.WriteLine($" {a} is even");

            }
            else 
            {
                Console.WriteLine($"{a} is NOT even");
            }
        }

        //Write a method to check whether a given number is positive or negative
        static void PosOrNeg(int c)
        {
            if (c > 0)
            {
                Console.WriteLine($"{c} is positive.");
            }
            else if (c < 0)
            {
                Console.WriteLine($"{c} is negative.");

            }
            else
            {
                Console.WriteLine($"{c} is zero.");
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        static void OldEnough()
        {
            Console.WriteLine("Tell me your age.");
            int num = int.Parse(Console.ReadLine());

            if(num >= 18)
            {
                Console.WriteLine($" You are {num} years old. You are old enough to vote!");
            }

            else
            {
                Console.WriteLine($" You are {num} years old. Sorry you are NOT old enough to vote.");
            }
        }



        //Heatin Up Section:
        //Write a method
        //to check if an integer(from the user)
        //is in the range -10 to 10

        static void GiveMeANumber()
        {
            Console.WriteLine("Give me a number!");
            int num = int.Parse(Console.ReadLine());

            if (num <= 10 && num >= -10)
            {
                Console.WriteLine($"{num} is in the range!");
            }
            else
            {
                Console.WriteLine($"{num} is NOT in the range, please try again.");
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        static void Multiply()
        {
            int d = 15;

            for (int i = 1; i <= 12; i++)
            {
                int result = d * i;
                Console.WriteLine($"{d} x {i} = {result}");
            }
        }


      
    }
}
