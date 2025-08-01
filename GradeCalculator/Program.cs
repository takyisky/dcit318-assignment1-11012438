using System;
using System.ComponentModel;

string input;
int grade;

// Keep looping until right numerical grade is entered.
while (true)
{
    Console.Write("\nEnter your grade (0-100): ");
    input = Console.ReadLine() ?? "";

    if (int.TryParse(input, out grade))
    {
        if (grade >= 0 && grade <= 100)
        {
            break;
        }
        else
        {
            Console.WriteLine("!!Grade must be between 0 and 100. Try again.");
        }
    }
    else
    {
        Console.WriteLine("!!Invalid input. Please enter a number.");
    }
}

// Variable for the letter grade
string letterGrade;

// Logic to determine the letter grade
if (grade >= 90)
{
    letterGrade = "A";
}
else if (grade >= 80)
{
    letterGrade = "B";
}
else if (grade >= 70)
{
    letterGrade = "C";
}
else if (grade >= 60)
{
    letterGrade = "D";
}
else
{
    letterGrade = "F";
}

// Final code output based on logic
Console.WriteLine("\nThe Letter grade for " + grade + " is " + letterGrade);


