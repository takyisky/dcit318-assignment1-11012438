using System;
using System.Runtime.InteropServices;

// Variables
string input;
int age;
int regularticketPrice = 10;
int discountedticketPrice = 7;

// Initial prompt
Console.WriteLine("\n🎟️ Thank you for working with us...");
Console.WriteLine("To proceed with your billing please enter your age...");


while (true)
{
    Console.Write("Enter age here: ");
    input = Console.ReadLine() ?? "";

    // Try parsing the input safely
    if (int.TryParse(input, out age))
    {
        if (age > 0)
        {
            if (age >= 65 || age <= 12)
            {
                Console.WriteLine("\n🎉Hurrayy!! You qualify for a Discount.");
                Console.WriteLine("✅Please proceed to pay " + discountedticketPrice + ".00");
                break;
            }
            else
            {
                Console.WriteLine("\n✅Please proceed to pay " + regularticketPrice + ".00");
                break;
            }
        }
        else
        {
            Console.WriteLine("\n!!! Invalid response. Age must be greater than 0. Try again.");
        }
    }
    else
    {
        Console.WriteLine("\n!!! Invalid input. Please enter a valid number.");
    }
}