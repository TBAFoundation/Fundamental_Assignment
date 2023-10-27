class ChapterSixSolution
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
        Question17();
        Question18();
    }
    static void Question1()
    {
        // 1. Write a program that prints on the console the numbers from 1 to N. The number N should be read from the standard input.
        Console.WriteLine("=====Question 1 - Printing Number from one to N=====");
        Console.Write("Enter the (N) number you want to print: ");
        int N = int.Parse(Console.ReadLine()!);
        Console.Write("The entered (N) numbers are: ");
        for(int i = 1; i <= N; i++)
        {
            Console.Write($"{i} ");
        }
    }
    static void Question2()
    {
        // 2. Write a program that prints on the console the numbers from 1 to N, which are not divisible by 3 and 7 simultaneously. The number N should be read from the standard input.
        Console.WriteLine("=====Question 2 - Printing Number from 1 to N that are not divisible by 3 and 7=====");
        Console.Write("Enter the (N) number you want to print: ");
        int N = int.Parse(Console.ReadLine()!);
        Console.Write("The entered (N) numbers which are not divisible by 3 and 7 simultaneously are: ");
        for(int i = 1; i <= N; i++)
        {
            if (i % 21 == 0)
            {
                i++;
            }
            Console.Write($"{i} ");
        }
    }
    static void Question3()
    {
        // 3. Write a program that reads from the console a series of integers and prints the smallest and largest of them.
        Console.WriteLine("=====Question 3 - Printing smallest ant largest numbers of a series=====");
        int smallest = int.MaxValue;
        int largest = int.MinValue;
        Console.WriteLine("Enter a series of integers (enter any non-integer to stop): ");
        while(true)
        {
            string input = Console.ReadLine()!;
            int number;
            if (int.TryParse(input, out number))
            {
                smallest = Math.Min(smallest, number);
                largest = Math.Max(largest, number);
            }
            else
            {
                break;
            }
        }
        if (smallest != int.MaxValue && largest != int.MinValue)
        {
            Console.WriteLine($"Smallest number: {smallest}");
            Console.WriteLine($"Largest number: {largest}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
    static void Question4()
    {
        // 4. Write a program that prints all possible cards from a standard deck of cards, without jokers (there are 52 cards: 4 suits of 13 cards).
        Console.WriteLine("=====Question 5 - Program Printing all Possible Cards=====");

        for (int cardNumber = 1; cardNumber <= 52; cardNumber++)
        {
            int suit = (cardNumber - 1) / 13;
            int rank = (cardNumber - 1) % 13 + 1;

            string suitName = suit switch
            {
                0 => "Spades",
                1 => "Hearts",
                2 => "Diamonds",
                3 => "Clubs",
                _ => throw new ArgumentException("Invalid card number")
            };

            string rankName = rank switch
            {
                1 => "Ace",
                11 => "Jack",
                12 => "Queen",
                13 => "King",
                _ => rank.ToString()
            };

            string card = $"{rankName} of {suitName}";
            Console.WriteLine(card);
        }
    }
    static void Question5()
    {
        // 5. Write a program that reads from the console number N and print the sum of the first N members of the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
        Console.WriteLine("=====Question 5 - first N member of Fibonacci sequence=====");
        Console.Write("Enter N member of the Fibonacci Sequence: ");
        int numTerms = int.Parse(Console.ReadLine()!); 
        int prev1 = 0;
        int prev2 = 1;
        int current;
        Console.WriteLine(prev1);
        Console.WriteLine(prev2);

        for (int i = 2; i < numTerms; i++)
        {
            current = prev1 + prev2;
            Console.Write(current + ", ");
            prev1 = prev2;
            prev2 = current;
        }
    }
    static void Question6()
    {
        // 6. Write a program that calculates N!/K! for given N and K (1<K<N).
        Console.WriteLine("=====Question 5 - program that calculates N!/K! for given N and K (1<K<N)=====");
        Console.Write("Enter the value of N: ");
        int N = int.Parse(Console.ReadLine()!);

        Console.Write("Enter the value of K: ");
        int K = int.Parse(Console.ReadLine()!);

        if (K <= 1 || K >= N)
        {
            Console.WriteLine("Invalid values! K must be greater than 1 and less than N.");
            return;
        }
        long factorialNK = 1;
        // long factorialK = 1;

        for (int i = K + 1; i <= N; i++)
        {
            factorialNK *= i;
        }

        long result = factorialNK;
        Console.WriteLine($"N!/K! = {result}");
    }
    static void Question7()
    {
        // 7. Write a program that calculates N!*K!/(N-K)! for given N and K (1<K<N).
        Console.WriteLine("=====Question 7 - program that calculates N!*K!/(N-K)! for given N and K (1<K<N)=====");
        Console.Write("Enter the value of N: ");
        int N = int.Parse(Console.ReadLine()!);
        Console.Write("Enter the value of K: ");
        int K = int.Parse(Console.ReadLine()!);

        if (K <= 0 || K >= N)
        {
            Console.WriteLine("Invalid values! K must be greater than 0 and less than N.");
            return;
        }
        long result = 1;

        for (int i = 1; i <= N; i++)
        {
            result *= i;

            if (i <= K)
            {
                result *= i;
            }

            if (i <= N - K)
            {
                result /= i;
            }
        }
        Console.WriteLine($"N!*K!/(N-K)! = {result}");
    }
    static void Question8()
    {
        // 8. In combinatorics, the Catalan numbers are calculated by the following formula:Cn = (2n)!/((n+1)!n!) for n ≥ 0. Write a program that calculates the nth Catalan number by given n.
        Console.WriteLine("=====Question 8 - Program for calculating N Catalan Numbers=====");
        Console.Write("Enter the value of N: ");
        int n = int.Parse(Console.ReadLine()!);

        if (n < 0)
        {
            Console.WriteLine("Invalid values! N must not be less than Zero.");
            return;
        }
        long numerator = 1;
        long denominator = 1;

        for (int i = 1; i <= n; i++)
        {
            numerator *= (2 * n) - i + 1;
            denominator *= i + 1;
        }

        long catalan = numerator / denominator;
        Console.WriteLine($"The {n}th Catalan number is: {catalan}");
    }
    static void Question9()
    {
        // 9. Write a program that for a given integers n and x, calculates the sum: S = 1 + (1!/x) + (2!/x^2) + ... + (n!/x^n)
        Console.WriteLine("=====Question 9 - program that for a given integers n and x, calculates the sum=====");
        Console.Write("Enter a positive integer n: ");
        int n = int.Parse(Console.ReadLine()!);

        Console.Write("Enter a real number x: ");
        double x = double.Parse(Console.ReadLine()!);

        double sum = 0;
        double factorial = 1;
        int i = 0;

        do
        {
            if (i != 0)
            {
                factorial *= i;
            }

            double term = factorial / Math.Pow(x, i);
            sum += term;

            i++;
        } while (i <= n);

        Console.WriteLine($"The sum S is: {sum}");
    }
    static void Question10()
    {
        // 10. Write a program that reads from the console a positive integer number N (N < 20) and prints a matrix of numbers as on the figures below: N = 3 N = 4
        Console.WriteLine("=====Question 10 - Program that print the matrix of a given N number for (N < 20)=====");
        Console.Write("Enter a positive integer N (N < 20): ");
        int N = int.Parse(Console.ReadLine()!);

        if (N >= 20)
        {
            Console.WriteLine("N should be less than 20.");
            return;
        }

        int[,] matrix = new int[N, N];

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matrix[i, j] = i + j + 1;
            }
        }

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    static void Question11()
    {
        // 11. Write a program that calculates with how many zeroes the factorial of a given number ends. Examples: N = 10 -> N! = 3628800 -> 2 N = 20 -> N! = 2432902008176640000 -> 4
        Console.WriteLine("=====Question 11 - Calculate trailing zeroes in factorial=====");
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine()!);

        int trailingZeroes = 0;
        int factor = 5;
        while (n / factor >= 1)
        {
            trailingZeroes += n / factor;
            factor *= 5;
        }
        Console.WriteLine($"Number of trailing zeroes in {n}! = {trailingZeroes}");
    }
    static void Question12()
    {
        // 12. Write a program that converts a given number from decimal to binary notation (numeral system).
        Console.WriteLine("=====Question 12 - Convert decimal to binary=====");
        Console.Write("Enter a decimal number: ");
        int decimalNumber = int.Parse(Console.ReadLine()!);

        string binaryNumber = "";
        while (decimalNumber > 0)
        {
            int remainder = decimalNumber % 2;
            binaryNumber = remainder.ToString() + binaryNumber;
            decimalNumber /= 2;
        }
        Console.WriteLine($"Binary representation: {binaryNumber}");
    }
    static void Question13()
    {
        // 13. Write a program that converts a given number from binary to decimal notation.
        Console.WriteLine("=====Question 13 - Convert binary to decimal=====");
        Console.Write("Enter a binary number: ");
        string binaryString = Console.ReadLine()!;

        int decimalValue = 0;
        int power = 0;
        for (int i = binaryString.Length - 1; i >= 0; i--)
        {
            int bit = int.Parse(binaryString[i].ToString());
            decimalValue += bit * (int)Math.Pow(2, power);
            power++;
        }
        Console.WriteLine($"Decimal representation: {decimalValue}");
    }
    static void Question14()
    {
        // 14. Write a program that converts a given number from decimal to hexadecimal notation.
        Console.WriteLine("=====Question 14 - Convert decimal to hexadecimal=====");
        Console.Write("Enter a decimal number: ");
        int decimalNum = int.Parse(Console.ReadLine()!);

        string hexadecimalNum = "";
        while (decimalNum > 0)
        {
            int remainder = decimalNum % 16;
            hexadecimalNum = remainder.ToString() + hexadecimalNum;
            decimalNum /= 16;
        }
        Console.WriteLine($"Hexadecimal representation: {hexadecimalNum}");
    }
    static void Question15()
    {
        // 15. Write a program that converts a given number from hexadecimal to decimal notation.
        Console.WriteLine("=====Question 15 - Convert hexadecimal to decimal=====");
        Console.Write("Enter a hexadecimal number: ");
        string hexadecimalString = Console.ReadLine()!;

        int decimalValue = 0;
        int power = 0;
        for (int i = hexadecimalString.Length - 1; i >= 0; i--)
        {
            char digit = hexadecimalString[i];
            int digitValue;

            if (char.IsDigit(digit))
            {
                digitValue = int.Parse(digit.ToString());
            }
            else
            {
                digitValue = digit - 'A' + 10;
            }

            decimalValue += digitValue * (int)Math.Pow(16, power);
            power++;
        }

        Console.WriteLine($"Decimal representation: {decimalValue}");
    }
    static void Question16()
    {
        // 16. Write a program that by a given integer N prints the numbers from 1 to N in random order.
        Console.WriteLine("=====Question 16 - Print numbers from 1 to N in random order=====");
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine()!);

        int[] numbers = new int[num];
        for (int i = 0; i < num; i++)
        {
            numbers[i] = i + 1;
        }

        Random random = new Random();
        for (int i = 0; i < num; i++)
        {
            int randomIndex = random.Next(i, num);
            int temp = numbers[i];
            numbers[i] = numbers[randomIndex];
            numbers[randomIndex] = temp;
        }

        Console.WriteLine("Numbers in random order:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
    static void Question17()
    {
        // 17. Write a program that given two numbers finds their greatest common divisor (GCD) and their least common multiple (LCM). You may use the formula LCM(a, b) = |a*b| / GCD(a, b).
        Console.WriteLine("=====Question 17 - Find GCD and LCM=====");
        Console.WriteLine("Enter two numbers:");
        int a = int.Parse(Console.ReadLine()!);
        int b = int.Parse(Console.ReadLine()!);

        int gcd = 1;
        for (int i = 1; i <= a && i <= b; i++)
        {
            if (a % i == 0 && b % i == 0)
            {
                gcd = i;
            }
        }

        int lcm = Math.Abs(a * b) / gcd;
        Console.WriteLine($"GCD: {gcd}");
        Console.WriteLine($"LCM: {lcm}");
    }
    static void Question18()
    {
        // 18. * Write a program that for a given number n, outputs a matrix in the form of a spiral: Example for n=4:
        Console.WriteLine("=====Question 18 - Print matrix in spiral order=====");
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine()!);

        int[,] matrix = new int[n, n];
        int rowStart = 0, rowEnd = n - 1;
        int colStart = 0, colEnd = n - 1;
        int numToAdd = 1;

        while (numToAdd <= n * n)
        {
            for (int i = colStart; i <= colEnd; i++)
            {
                matrix[rowStart, i] = numToAdd;
                numToAdd++;
            }
            rowStart++;

            for (int i = rowStart; i <= rowEnd; i++)
            {
                matrix[i, colEnd] = numToAdd;
                numToAdd++;
            }
            colEnd--;

            for (int i = colEnd; i >= colStart; i--)
            {
                matrix[rowEnd, i] = numToAdd;
                numToAdd++;
            }
            rowEnd--;

            for (int i = rowEnd; i >= rowStart; i--)
            {
                matrix[i, colStart] = numToAdd;
                numToAdd++;
            }
            colStart++;
        }

        Console.WriteLine("Matrix in spiral order:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
