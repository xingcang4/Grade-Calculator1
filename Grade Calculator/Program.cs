int num1, num2, num3, num4, avg = 0;
string grade;

Console.WriteLine("Grade Calculator Program ");
Console.Write("Enter #1 Grade: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter #2 Grade: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter #3 Grade: ");
num3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter #4 Grade: ");
num4 = Convert.ToInt32(Console.ReadLine());

if (num1 > 100 || num2 > 100 || num3 > 100 | num4 > 100) grade = "Error";
else if (num1 < 0 || num2 < 0 || num3 < 0 | num4 > 100) grade = "Error";
else
{
    avg = (num1 + num2 + num3 + num4) / 4;

    if (avg > 100) grade = "Error";
    else if (avg < 0) grade = "Error";
    else if (avg > 79) grade = "A";
    else if (avg > 69) grade = "B";
    else if (avg > 59) grade = "C";
    else if (avg > 49) grade = "D";
    else grade = "F";
    Console.WriteLine("Your average grade is {0}", avg);

    switch (grade)
    {
        case "A":
            Console.WriteLine("Excellent! Your grade is A");
            break;
        case "B":
            Console.WriteLine("Good! Your grade is B");
            break;
        case "C":
            Console.WriteLine("Satisfactory. Your grade is C");
            break;
        case "D":
            Console.WriteLine("Pass. Your grade is D");
            break;
        case "F":
            Console.WriteLine("Fail. Your grade is F");
            break;
    }
}