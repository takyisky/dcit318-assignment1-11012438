using System;

//Varibles
int side1;
int side2;
int side3;

string input1;
string input2;
string input3;

// Intro Message
Console.WriteLine("\nI am here to help find the specific type of triangle based on the lengths given...");


// Pass the lengths entered through the algorithm, check the values and output results.
while (true)
{
    Console.Write("\nWhat is the length for side 1: ");
    input1 = Console.ReadLine() ?? "";

    Console.Write("What is the length for side 2: ");
    input2 = Console.ReadLine() ?? "";

    Console.Write("What is the length for side 3: ");
    input3 = Console.ReadLine() ?? "";


    if (int.TryParse(input1, out side1) && int.TryParse(input2, out side2) && int.TryParse(input3, out side3))
    {
        if (side1 > 0 && side2 > 0 && side3 > 0)
        {
            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("\nLoading...... ");
                Console.WriteLine("Based on your input: ( " + side1 + " : " + side2 + " : " + side3 + " )");
                Console.WriteLine("All 3 sides are equal so this is an Equilateral triangle. ");
                break;
            }

            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                Console.WriteLine("\nLoading...... ");
                Console.WriteLine("Based on your input: ( " + side1 + " : " + side2 + " : " + side3 + " )");
                Console.WriteLine("2 sides are equal so this is an Isosceles triangle. ");
                break;
            }

            else if (side1 != side2 && side2 != side3 && side1 != side3)
            {
                Console.WriteLine("\nLoading...... ");
                Console.WriteLine("Based on your input: ( " + side1 + " : " + side2 + " : " + side3 + " )");
                Console.WriteLine("None of the sides are equal so this is a Scalene triangle. ");
                break;
            }

        }
        else
        {
            Console.WriteLine("\n⚠️ Invalid Input! Length cannot be a negative number.");
        }

    }
    else
    {
        Console.WriteLine("\n⚠️ Invalid Input! Recheck input and enter a number.");
    }
}
