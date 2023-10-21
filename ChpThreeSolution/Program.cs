class ChapterThreeSolution
{
    static void Main(string[]args)
    {
        Question1();
        Question2();
        Question3();
        Question4();
        Question5();
        Question6();
        Question7();
        Question8();
        Question9();
        Question10();
        Question11();
        Question12();
        Question13();
        Question14();
        Question15();
        Question16();
    }
    static void Question1()
    {
        // 1. write an expression that checks whether an integer is odd or even.
        Console.WriteLine("=====Question 1 - Expression Checking Odd or Even Number=====");
        int number = 35;
        string result = (number % 2 == 0) ? "even" : "odd";
        Console.WriteLine("The number " + number + " is " + result + ".");       
    }
    static void Question2()
    {
        // 2. Write a Boolean expression that checks whether a given integer is divisible by both 5 and 7, without a remainder.
        Console.WriteLine("=====Question 2 - Expression Checking Number Divisible by 5 and 7=====");
        int number = 353;
        string result = (number % 5 == 0 && number % 7 == 0) ? "Divisible by 5 and 7" : "not Divisible by 5 and 7";
        Console.WriteLine("The number " + number + " is " + result + ".");
    }
    static void Question3()
    {
        // 3. Write an expression that looks for a given integer if its third digit (right to left) is 7.
        Console.WriteLine("=====Question 3 - Expression Checking if the Remainder has 7 as Third Digit =====");
        int number = 12347;
        int thirdDigitFromRight = (number / 100) % 10;
        bool isThirdDigitSeven = (thirdDigitFromRight == 7);
        Console.WriteLine($"Is the third digit (right to left) of {number} equal to 7? {isThirdDigitSeven}");
    }
    static void Question4()
    {
        // 4. Write an expression that checks whether the third bit in a given integer is 1 or 0.
        Console.WriteLine("=====Question 4 - Expression Checking Whether the Third Bit is 1 or 0=====");
        int number = 10;
        int thirdBit = (number >> 2) & 1;
        Console.WriteLine($"The third bit in the number {number} is: {thirdBit}");
    }
    static void Question5()
    {
        // 5. Write an expression that calculates the area of a trapezoid by given sides a, b and height h.
        Console.WriteLine("=====Question 5 - Expression that Calculate the Area of a Trapezoid=====");
        double a = 5;
        double b = 7;
        double h = 10;
        double area = 0.5 * (a + b) * h;
        Console.WriteLine("The area of the trapezoid is: " + area);
    }
    static void Question6()
    {
        // 6. Write a program that prints on the console the perimeter and the area of a rectangle by given side and height entered by the user.
        Console.WriteLine("=====Question 6 - Program that Calculate the Perimeter and the Area of Rectangle=====");
        Console.Write("Enter the length of the rectangle: ");
        double length = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the width of the rectangle: ");
        double width = Convert.ToDouble(Console.ReadLine());
        double perimeter = 2 * (length + width);
        double area = length * width;
        Console.WriteLine("Perimeter of the rectangle: " + perimeter);
        Console.WriteLine("Area of the rectangle: " + area);
    }
    static void Question7()
    {
        // 7. The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
        Console.WriteLine("=====Question 7 - Program that Calculate the Weight of Man on the Moon=====");
        Console.Write("Enter the weight of Earth (kg): ");
        double weightOnEarth = Convert.ToDouble(Console.ReadLine());
        double moonWeight = 0.17 * weightOnEarth;
        Console.WriteLine("Weight of man on the moon is : " + moonWeight + "kg");
    }
    static void Question8()
    {
        // 8. Write an expression that checks for a given point {x, y} if it is within the circle K({0, 0}, R=5). Explanation: the point {0, 0} is the center of the circle and 5 is the radius.
        Console.WriteLine("=====Question 8 - Expression that Calculate a given Point within the Circle=====");
        double x = 3;
        double y = 4;
        double radius = 5;
        double distance = Math.Sqrt(x * x + y * y);
        bool isInsideCircle = distance <= radius;
        Console.WriteLine("Is the point ({0}, {1}) inside the Circle? {2}", x, y, isInsideCircle);
    }
    static void Question9()
    {
        // 9. Write an expression that checks for given point {x, y} if it is within the circle K({0, 0}, R=5) and out of the rectangle [{-1, 1}, {5, 5}]. Clarification: for the rectangle the lower left and the upper right corners are given.
        Console.WriteLine("=====Question 9 - Expression that Calculate a given Point within the Circle and Outside Rectangle=====");
        double x = 2;
        double y = 3;
        double circleRadius = 5;
        double distanceFromOrigin = Math.Sqrt(x * x + y * y);
        bool isInsideCircle = distanceFromOrigin <= circleRadius;
        bool isOutsideRectangle = (x < -1 || x > 5 || y < 1 || y > 5);
        bool meetCondition = isInsideCircle && isOutsideRectangle;
        Console.WriteLine("Is the point ({0}, {1}) inside the Circle and outside the Rectangle? {2}", x, y, meetCondition);
    }
    static void Question10()
    {
        /* 10. Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following actions:
        - Calculates the sum of the digits (in our example 2+0+1+1 = 4).
        - Prints on the console the number in reversed order: dcba (in our example 1102).
        - Puts the last digit in the first position: dabc (in our example 1201).
        - Exchanges the second and the third digits: acbd (in our example 2101).*/
        Console.WriteLine("=====Question 10 - Program that take four-digit as input and perform some task=====");
        Console.Write("Enter a four-digit number: ");
        int number = int.Parse(Console.ReadLine()!);
        int sumDigit = (number % 10) + ((number / 10) % 10) + ((number / 100) % 10) + ((number / 1000) % 10);
        Console.WriteLine("Sum of Digits: " + sumDigit);
        int reversedNumber = (number % 10) * 1000 + ((number / 10) % 10) * 100 + ((number / 100) % 10) * 10 + (number / 1000);
        Console.WriteLine("Reversed Number: " + reversedNumber);
        int lastDigitFirst = (number % 10) * 1000 + (number / 10);
        Console.WriteLine("Last Digits in the First Position: " + lastDigitFirst);
        int exchangeDigits = (number / 1000) * 1000 + ((number / 100) % 10) * 100 + ((number / 10) % 10) * 10 + ((number % 10) * 100);
        Console.WriteLine("Exchange Second and Third Digits: " + exchangeDigits);
    }
    static void Question11()
    {
        // 11. We are given a number n and a position p. Write a sequence of operations that prints the value of the bit on the position p in the number (0 or 1). Example: n=35, p=5 -> 1. Another example: n=35, p=6 -> 0.
        Console.WriteLine("=====Question 11 - Sequence of Operation that prints the value of the Bit=====");
        int n = 35;
        int p = 5;
        int bitValue = (n >> p) & 1;
        Console.WriteLine("The bit at position " + p + " in the number " + n + " is: " + bitValue);
    }
    static void Question12()
    {
        // 12. Write a Boolean expression that checks if the bit on position p in the integer v has the value 1. Example v=5, p=1 -> false.
        Console.WriteLine("=====Question 12 - Boolean Expression that Checks if the Bit on a Position is an Integer=====");
        int v = 5;
        int p = 1;
        bool isBitOne = (v & (1 << p)) != 0;
        Console.WriteLine("Is the Bit at Position " + p + " in " + v + " equals to 1? " + isBitOne);
    }
    static void Question13()
    {
        // 13. We are given the number n, the value v (v = 0 or 1) and the position p. write a sequence of operations that changes the value of n, so the bit on the position p has the value of v. Example: n=35, p=5, v=0 -> n=3. Another example: n=35, p=2, v=1 -> n=39.
        Console.WriteLine("=====Question 13 - Sequence of Operation that Changes Value Position=====");
        int n = 35;
        int p = 5;
        int v = 0;
        int clearedBit = n & ~(1 << p);
        int result = clearedBit | (v << p);
        Console.WriteLine("Original number " + n);
        Console.WriteLine("Number after changing bit at position " + p +" to " + v + ": " + result);
    }
    static void Question14()
    {
        // 14. Write a program that checks if a given number n (1 < n < 100) is a prime number (i.e. it is divisible without remainder only to itself and 1).
        Console.WriteLine("=====Question 14 - Program that Checks if the Prime Number within a Specify Range is Divisible Only to itself without Remainder=====");
        Console.Write("Enter a prime number (1 < n < 100): ");
        int n = int.Parse(Console.ReadLine()!);
        bool isPrime = (n > 1) && (n == 2 || n % 2 != 0) && (n == 3 || n % 3 != 0) && (n == 5 || n % 5 != 0) && (n == 7 || n % 7 != 0) && (n == 11 || n % 11 != 0) && (n == 13 || n % 13 != 0) && (n == 17 || n % 17 != 0) && (n == 19 || n % 19 != 0) && (n == 21 || n % 21 != 0) && (n == 23 || n % 23 != 0) && (n == 27 || n % 27 != 0) && (n == 29 || n % 29 != 0) && (n == 31 || n % 31 != 0) && (n == 37 || n % 37 != 0) && (n == 41 || n % 41 != 0) && (n == 43 || n % 43 != 0) && (n == 47 || n % 47 != 0) && (n == 53 || n % 53 != 0) && (n == 57 || n % 57 != 0) && (n == 59 || n % 59 != 0) && (n == 61 || n % 61 != 0) && (n == 63 || n % 63 != 0) && (n == 67 || n % 67 != 0) && (n == 69 || n % 69 != 0) && (n == 71 || n % 71 != 0) && (n == 73 || n % 73 != 0) && (n == 79 || n % 79 != 0) && (n == 83 || n % 83 != 0) && (n == 85 || n % 85 != 0) && (n == 87 || n % 87 != 0) && (n == 89 || n % 89 != 0) && (n == 91 || n % 91 != 0) && (n == 93 || n % 93 != 0) && (n == 95 || n % 95 != 0) && (n == 97 || n % 97 != 0);
        Console.WriteLine("Is " + n + " a prime number? " + isPrime);
    }
    static void Question15()
    {
        // 15. * Write a program that exchanges the values of the bits on positions 3, 4 and 5 with bits on positions 24, 25 and 26 of a given 32-bit unsigned integer.
        Console.WriteLine("=====Question 15 - Program that Exchange Values of the bits=====");
        uint number = 1234567890;
        int p = 3;  //starting position of the first bit sequence
        int q = 24; //starting position of the second bit sequence
        int k = 3; //length of the bit sequence to exchange
        p = Math.Max(0, Math.Min(p, 31));
        q = Math.Max(0, Math.Min(q, 31));
        uint bitsP = (number >> p) & ((1u << k) - 1);
        uint bitsQ = (number >> q) & ((1u << k) - 1);
        number &= ~(((1u << k) - 1) << p);
        number &= ~(((1u << k) - 1) << q);
        number |= bitsQ << p;
        number |= bitsP << q;
        Console.WriteLine("Original number: " + 1234567890);
        Console.WriteLine("Number after exchanging bits: " + number);
    }
    static void Question16()
    {
        // 16. * Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
        Console.WriteLine("=====Question 16 - Program that Exchange Values of the bits+=====");
        uint number = 1234567890; // Replace with the given 32-bit unsigned integer
        int p = 3; // Starting position for the first set of bits
        int q = 24; // Starting position for the second set of bits
        int k = 3; // Number of bits to exchange
        p = Math.Max(0, Math.Min(p, 31));
        q = Math.Max(0, Math.Min(q, 31));
        for (int i = 0; i < k; i++)
        {
            uint maskP = (1u << (p + i)); // Mask for the ith bit at position p
            uint maskQ = (1u << (q + i)); // Mask for the ith bit at position q
            uint bitP = (number & maskP);
            uint bitQ = (number & maskQ);
            number &= ~maskP;
            number &= ~maskQ;
            number |= (bitQ >> (q - p)) << (p + i);
            number |= (bitP >> (p - q)) << (q + i);
        }
        Console.WriteLine("Original number: " + 1234567890);
        Console.WriteLine("Number after exchanging bits: " + number);
    }
}