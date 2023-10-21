class ChapterFiveSolution
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
        Question11();
    }
    static void Question1()
    {
        // 1. Write an if-statement that takes two integer variables and exchanges their values if the first one is greater than the second one.
        Console.WriteLine("=====Question 1 - Number Swapping=====");
        Console.WriteLine("Enter two numbers.");
        Console.Write("Enter First Number: ");
        int firstNum = int.Parse(Console.ReadLine()!);
        Console.Write("Enter Second Number: ");
        int secondNum = int.Parse(Console.ReadLine()!);

        if (firstNum > secondNum)
        {
            Console.WriteLine("First number is: " + secondNum);
            Console.WriteLine("Second number is: " + firstNum);
        }
        else
        { 
            Console.WriteLine("First Number is less than second number");
        }
    }
    static void Question2()
    {
        // 2. Write a program that shows the sign (+ or -) of the product of three real numbers, without calculating it. Use a sequence of if operators.
        Console.WriteLine("=====Question 2 - Product of Numbers=====");
        Console.WriteLine("Enter three numbers.");
        Console.Write("Enter First Number: ");
        int firstNum = int.Parse(Console.ReadLine()!);
        Console.Write("Enter Second Number: ");
        int secondNum = int.Parse(Console.ReadLine()!);
        Console.Write("Enter Third Number: ");
        int thirdNum = int.Parse(Console.ReadLine()!);

        if (firstNum == 0 || secondNum == 0 || thirdNum == 0)
        {
            Console.WriteLine("The product is zero {0}.");
        }
        else if ((firstNum > 0 && secondNum > 0 && thirdNum > 0) || (firstNum < 0 && secondNum < 0 && thirdNum < 0) || (firstNum < 0 && secondNum > 0 && thirdNum < 0) || (firstNum > 0 && secondNum < 0 && thirdNum < 0))
        {
            Console.WriteLine("The product is (+).");
        }
        else
        {
            Console.WriteLine("The product is (-)");
        }
    }
    static void Question3()
    {
        // 3. Write a program that finds the biggest of three integers, using nested if statements.
        Console.WriteLine("=====Question 3 - =====");
        Console.WriteLine("Enter three numbers.");
        Console.Write("Enter First Number: ");
        int firstNum = int.Parse(Console.ReadLine()!);
        Console.Write("Enter Second Number: ");
        int secondNum = int.Parse(Console.ReadLine()!);
        Console.Write("Enter Third Number: ");
        int thirdNum = int.Parse(Console.ReadLine()!);
        int greatest;

        if (firstNum >= secondNum)
        {
            if (firstNum >= thirdNum)
            {
                greatest = firstNum;
            }
            else
            {
                greatest = thirdNum;
            }
        }
        else
        {
            if ( secondNum >= thirdNum)
            {
                greatest = secondNum;
            }
            else
            {
                greatest = thirdNum;
            }
        }
        Console.WriteLine("Greatest of the three number is: " + greatest);
    }
    static void Question4()
    {
        // 4. Sort 3 real numbers in descending order. Use nested if statements.
        Console.WriteLine("=====Question 4 - Number Sorting=====");
        Console.WriteLine("Enter three numbers.");
        Console.Write("Enter First Number: ");
        int firstNum = int.Parse(Console.ReadLine()!);
        Console.Write("Enter Second Number: ");
        int secondNum = int.Parse(Console.ReadLine()!);
        Console.Write("Enter Third Number: ");
        int thirdNum = int.Parse(Console.ReadLine()!);
        int greatest, greater, great;

        if (firstNum >= secondNum) 
        {
            if (firstNum >= thirdNum)
            {
                if (secondNum >= thirdNum)
                {
                    greatest = firstNum;
                    greater = secondNum;
                    great = thirdNum;
                }
                else
                {
                    greatest = firstNum;
                    greater = thirdNum;
                    great = secondNum;
                }
            }
            else
                {
                    greatest = thirdNum;
                    greater = secondNum;
                    great = firstNum;
                }
        }
        else
        {
            if (secondNum >= thirdNum)
            {
                if (firstNum >= thirdNum)
                {
                    greatest = secondNum;
                    greater = firstNum;
                    great = thirdNum;
                }
                else
                {
                    greatest = secondNum;
                    greater = thirdNum;
                    great = firstNum;
                }
            }
            else
            {
                greatest = thirdNum;
                greater = secondNum;
                great = firstNum;
            }
        }
        Console.WriteLine("The number in descending order are: {0}, {1}, {2}", greatest,greater,great);
    }
    static void Question5()
    {
        // 5. Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English). Use a switch statement.
        Console.WriteLine("=====Question 5 - Program tha show input digit (0-9) as word=====");
        Console.Write("Enter a digit (0 - 9): ");
        int digit = int.Parse(Console.ReadLine()!);
        string word;

        switch(digit)
        {
            case 0:
            word = "Zero";
            break;
            case 1:
            word = "One";
            break;
            case 2:
            word = "Two";
            break;
            case 3:
            word = "Three";
            break;
            case 4:
            word = "Four";
            break;
            case 5:
            word = "Five";
            break;
            case 6:
            word = "Six";
            break;
            case 7:
            word = "Seven";
            break;
            case 8:
            word = "Eight";
            break;
            case 9:
            word = "Nine";
            break;
            default:
            word = "Invalid digit";
            break;
        }
        Console.WriteLine("The digit as a word is: " + word);
    }
    static void Question6()
    {
        // 6. Write a program that gets the coefficients a, b and c of a quadratic equation: ax^2 + bx + c, calculates and prints its real roots (if they exist). Quadratic equations may have 0, 1 or 2 real roots.
        Console.WriteLine("=====Question 6 - Quadratic Equation Solver=====");
        Console.WriteLine("<<<><>><<><>>><<<><>><>>");
        Console.WriteLine("Enter the Coefficients of the Quadratic Equation: ");
        Console.Write("a: ");
        double a = double.Parse(Console.ReadLine()!);
        Console.Write("b: ");
        double b = double.Parse(Console.ReadLine()!);
        Console.Write("c: ");
        double c = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Calculating the roots");
        Console.WriteLine("<<<><>><<><>>><<<><>><>>");
        double discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("Two distinct real roots:");
            Console.WriteLine($"First Root: {root1,-10:F2}");
            Console.WriteLine($"Second Root: {root2,-10:F2}");
        }
        else if (discriminant == 0)
        {
            double root = -b / (2 * a);
            Console.WriteLine("one real root:");
            Console.WriteLine("Root: " + root);
        }
        else
        {
            Console.WriteLine("<<<<<<No real root exist>>>>>>");
        }
    }
    static void Question7()
    {
        // 7. Write a program that finds the greatest of given 5 numbers.
        Console.WriteLine("=====Question 7 - Numbers=====");
        Console.WriteLine("Enter Five Numbers.");
        Console.Write("Enter the First Number: ");
        double firstNum = double.Parse(Console.ReadLine()!);
        Console.Write("Enter the Second Number: ");
        double secondNum = double.Parse(Console.ReadLine()!);
        Console.Write("Enter the Third Number: ");
        double thirdNum = double.Parse(Console.ReadLine()!);
        Console.Write("Enter the Fourth Number: ");
        double fourthNum = double.Parse(Console.ReadLine()!);
        Console.Write("Enter the Fifth Number: ");
        double fifthNum = double.Parse(Console.ReadLine()!);
        double greatest = firstNum;

        if (secondNum > greatest)
        {
            greatest = secondNum;
        }
        if (thirdNum > greatest)
        {
            greatest = thirdNum;
        }
        if (fourthNum > greatest)
        {
            greatest = fourthNum;
        }
        if (fifthNum > greatest)
        {
            greatest = fifthNum;
        }
        Console.WriteLine("The Greatest Number is: " + greatest);
    }
    static void Question8()
    {
        // 8. Write a program that, depending on the user’s choice, inputs int, double or string variable. If the variable is int or double, the program increases it by 1. If the variable is a string, the program appends "*" at the end. Print the result at the console. Use switch statement.
        Console.WriteLine("=====Question 8 - Numbers=====");
        Console.WriteLine("Enter your choice.");
        Console.WriteLine("1. Integer\n2. Double\n3. String");
        int choice = int.Parse(Console.ReadLine()!);

        switch(choice)
        {
            case 1:
            Console.Write("Enter an Integer: ");
            int intValue = int.Parse(Console.ReadLine()!);
            intValue ++;
            Console.WriteLine("Result: " + intValue);
            break;

            case 2:
            Console.Write("Enter a Double: ");
            double intDouble = double.Parse(Console.ReadLine()!);
            intDouble ++;
            Console.WriteLine("Result: " + intDouble);
            break;

            case 3:
            Console.Write("Enter a String: ");
            string stringValue = (Console.ReadLine()!);
            stringValue += "*";
            Console.WriteLine("Result: " + stringValue);
            break;

            default:
            Console.WriteLine("Invalid input");
            break;
        }
    }
    static void Question9()
    {
        /* 9. We are given 5 integer numbers. Write a program that finds those subsets whose sum is 0. Examples:
        - If we are given the numbers {3, -2, 1, 1, 8}, the sum of -2, 1 and 1 is 0.
        - If we are given the numbers {3, 1, -7, 35, 22}, there are no subsets with sum 0.*/
        Console.WriteLine("=====Question 9 - Numbers=====");
    }
    static void Question10()
    {
        /* 10. Write a program that applies bonus points to given scores in the range [1…9] by the following rules:
        - If the score is between 1 and 3, the program multiplies it by 10.
        - If the score is between 4 and 6, the program multiplies it by 100.
        - If the score is between 7 and 9, the program multiplies it by 1000.
        - If the score is 0 or more than 9, the program prints an error message.*/
        Console.WriteLine("=====Question 10 - Numbers=====");
        int[] scores = { 2, 5, 8, 0, 10 };

        foreach (int score in scores)
        {
            int bonusScore;

            if (score >= 1 && score <= 3)
            {
                bonusScore = score * 10;
            }
            else if (score >= 4 && score <= 6)
            {
                bonusScore = score * 100;
            }
            else if (score >= 7 && score <= 9)
            {
                bonusScore = score * 1000;
            }
            else
            {
                Console.WriteLine("Error: Invalid score. Score should be between 1 and 9.");
                continue;
            }
            Console.WriteLine($"Score: {score}, Bonus Score: {bonusScore}");
        }
    }
    static void Question11()
    {
        /* 11. * Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation. Examples:
        - 0 --> "Zero"
        - 12 --> "Twelve"
        - 98 --> "Ninety eight"
        - 273 --> "Two hundred seventy three"
        - 400 --> "Four hundred"
        - 501 --> "Five hundred and one"
        - 711 --> "Seven hundred and eleven"*/
        Console.WriteLine("=====Question 11 - Numbers=====");
        int[] numbers = { 0, 12, 98, 273, 400, 501, 711 };

        string[] units = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        foreach (int number in numbers)
        {
            string words;
            if (number < 20)
            {
                words = units[number];
            }
            else if (number < 100)
            {
                int tensDigit = number / 10;
                int unitsDigit = number % 10;
                if (unitsDigit == 0)
                {
                    words = tens[tensDigit];
                }
                else
                {
                    words = tens[tensDigit] + " " + units[unitsDigit];
                }
            }
            else if (number < 1000)
            {
                int hundredsDigit = number / 100;
                int tensAndUnits = number % 100;
                if (tensAndUnits == 0)
                {
                    words = units[hundredsDigit] + " Hundred";
                }
                else
                {
                    words = units[hundredsDigit] + " Hundred and " + units[tensAndUnits];
                }
            }
            else
            {
                words = "Invalid number. Number should be between 0 and 999.";
            }
            Console.WriteLine($"{number} --> \"{words}\"");
        }
    }
}