class ChapterFourSolution
{
    static void Main(string[]args)
    {
        // Question1();
        // Question2();
        // Question3();
        // Question4();
        // Question5();
        // Question6();
        // Question7();
        // Question8();
        // Question9();
        // Question10();
        // Question11();
        // Question12();
    }
    static void Question1()
    {
        // 1. Write a program that reads from the console three numbers of type int and prints their sum.
        Console.WriteLine("=====Question 1 - Sum of Three Numbers=====");
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine()!);
        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine()!);
        Console.Write("Enter the third number: ");
        int num3 = int.Parse(Console.ReadLine()!);
        int sum = num1 + num2 + num3;
        Console.WriteLine("The sum of the three numbers is: " + sum);
    }
    static void Question2()
    {
        // 2. Write a program that reads from the console the radius "r" of a circle and prints its perimeter and area.
        Console.WriteLine("=====Question 2 - Perimeter and Area of a Circle=====");
        Console.Write("Enter the radius of the circle: ");
        double radius = double.Parse(Console.ReadLine()!);
        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * radius * radius;
        Console.WriteLine("Perimeter of the circle: " + perimeter);
        Console.WriteLine("Area of the circle: " + area);
    }
    static void Question3()
    {
        // 3. A given company has name, address, phone number, fax number, web site and manager. The manager has name, surname and phone number. Write a program that reads information about the company and its manager and then prints it on the console.
        Console.WriteLine("=====Question 3 - Company Information=====");
        Console.Write("Enter company name: ");
        string companyName = Console.ReadLine()!;
        Console.Write("Enter company address: ");
        string companyAddress = Console.ReadLine()!;
        Console.Write("Enter company phone number: ");
        string companyPhoneNumber = Console.ReadLine()!;
        Console.Write("Enter company fax number: ");
        string companyFaxNumber = Console.ReadLine()!;
        Console.Write("Enter company website: ");
        string companyWebsite = Console.ReadLine()!;
        Console.Write("Enter manager name: ");
        string managerName = Console.ReadLine()!;
        Console.Write("Enter manager surname: ");
        string managerSurname = Console.ReadLine()!;
        Console.Write("Enter manager phone number: ");
        string managerPhoneNumber = Console.ReadLine()!;
        Console.WriteLine($"Company Information:\nName: {companyName} \nAddress: {companyAddress} \nPhone Number: {companyPhoneNumber}\nFax Number: {companyFaxNumber}\nWebsite: {companyWebsite}");
        Console.WriteLine($"\nManager Information:\nName: {managerName}\nSurname: {managerSurname}\nPhone Number:: {managerPhoneNumber}");
    }
    static void Question4()
    {
        // 4. Write a program that prints three numbers in three virtual columns on the console. Each column should have a width of 10 characters and the numbers should be left aligned. The first number should be an integer in hexadecimal; the second should be fractional positive; and the third – a negative fraction. The last two numbers have to be rounded to the second decimal place.
        Console.WriteLine("=====Question 4 - Number Format=====");
        int num1 = 42;
        double num2 = 123.456;
        double num3 = -87.123;
        Console.WriteLine($"{num1,-10:X}{num2,-10:F2}{num3,-10:F2}");
    }
    static void Question5()
    {
        // 5. Write a program that reads from the console two integer numbers (int) and prints how many numbers between them exist, such that the remainder of their division by 5 is 0. Example: in the range (14, 25) there are 3 such numbers: 15, 20 and 25.
        Console.WriteLine("=====Question 5 - Counting of Numbers Divisible by 5=====");
        Console.Write("Enter starting numbers:");
        int start = int.Parse(Console.ReadLine()!);
        Console.Write("Enter ending numbers:");
        int end = int.Parse(Console.ReadLine()!);
        // int count = (end / 5) - ((start - 1) / 5);
        int count = 0;
        for(int num = start; num <= end; num++)
        {
            if (num % 5 == 0)
            {
                count++;
            }
        }
        Console.WriteLine("Count: " + count);
    }
    static void Question6()
    {
        // 6. Write a program that reads two numbers from the console and prints the greater of them. Solve the problem without using conditional statements.
        Console.WriteLine("=====Question 6 - Print out the Greatest Number=====");
        Console.Write("Enter the first number: ");
        float num1 = float.Parse(Console.ReadLine()!);
        Console.Write("Enter the second number: ");
        float num2 = float.Parse(Console.ReadLine()!);
        float greater = Math.Max(num1, num2);
        Console.WriteLine("Greater Number: " + greater);
    }
    static void Question7()
    {
        // 7. Write a program that reads five integer numbers and prints their sum. If an invalid number is entered the program should prompt the user to enter another number.
        Console.WriteLine("=====Question 7 - Program that reads five integer numbers and prints their sum=====");
        long sum = 0;
        int count = 0;
        while(count < 5)
        {
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                sum += number;
                count++;
            }
            else
            {
                Console.WriteLine("Invalid number. Please enter a valid integer.");
            }
        }
        Console.WriteLine("Sum: " + sum);
    }
    static void Question8()
    {
        // 8. Write a program that reads five numbers from the console and prints the greatest of them.
        Console.WriteLine("=====Question 8 -Program to find the greatest of five numbers=====");
        double max = double.MinValue;
        for (double i = 1; i <= 5; i++)
        {
            Console.Write("Enter number " + i + ": ");
            double number = double.Parse(Console.ReadLine()!);
            if (number > max)
            max = number;
        }
        Console.WriteLine ("Greatest number is: " + max);
    }
    static void Question9()
    {
        // 9. Write a program that reads an integer number n from the console. After that reads n numbers from the console and prints their sum.
        Console.WriteLine("=====Question 9 - Print Sum of n Numbers=====");
        Console.Write("Enter the number of integer (n): ");
        int n = int.Parse(Console.ReadLine()!);
        long sum = 0;
        for (int num = 0; num <= n; num++)
        {
            // Console.Write("Enter an Integer: ");
            // int num = int.Parse(Console.ReadLine()!);
            sum += num;
        }
        Console.WriteLine (" The sum of the entered N integer is: "  + sum);
    }
    static void Question10()
    {
        // 10. Write a program that reads an integer number n from the console and prints all numbers in the range [1…n], each on a separate line.
        Console.WriteLine("=====Question 10 - Printing Numbers in a Range=====");
        Console.Write("Enter the number of integer (n): ");
        int n = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Numbers in the range [1…n]: ");
        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
    static void Question11()
    {
        // 11. Write a program that prints on the console the first 100 numbers in the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …
        Console.WriteLine("=====Question 11 - Printing First 100 Fibonacci Sequence=====");
        int n = 100;
        ulong a = 0, b =1;
        Console.WriteLine("The First " + n + " Fibonacci numbers are: ");
        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine(a);
            ulong temp = a;
            a = b;
            b = temp + b;
        }
    }
    static void Question12()
    {
        // 12. Write a program that calculates the sum (with precision of 0.001) of the following sequence: 1 + 1/2 - 1/3 + 1/4 - 1/5 + …
        Console.WriteLine("=====Question 12 - Calculating Sequence Precision Sum=====");
        double sum = 1.0;
        double term = 1.0;
        int sign = 1;
        int i = 2;
        Console.Write(term); // Output the  first term
        while (Math.Abs(term) >= 0.001)
        {
            term = sign / (double)i;
            sum += term;
            sign *= -1;
            i++;
            Console.Write(" + " + term); // Output the term
        }
        sum = Math.Round(sum, 3);
        Console.WriteLine("\nThe sum of the sequence is: " + sum);
    }
}