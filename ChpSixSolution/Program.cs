class ChapterSixSolution
{
    static void Main(string[]args)
    {
        // Question1();
        // Question2();
        // Question3();
        // Question4();
<<<<<<< HEAD
        // Question5();
=======
        Question5();
>>>>>>> 812e9e6ce588415ed551d005b764429f5fc2180e
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
<<<<<<< HEAD
        Console.WriteLine("=====Question 5 - Program Printing all Possible Cards=====");
=======
>>>>>>> 812e9e6ce588415ed551d005b764429f5fc2180e
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
<<<<<<< HEAD
=======

>>>>>>> 812e9e6ce588415ed551d005b764429f5fc2180e
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
<<<<<<< HEAD
        Console.WriteLine("=====Question 5 - first N member of Fibonacci sequence=====");
        Console.Write("Enter N member of Fibonacci Sequence: ");
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
=======
>>>>>>> 812e9e6ce588415ed551d005b764429f5fc2180e
    }
    static void Question6()
    {
        // 6. Write a program that calculates N!/K! for given N and K (1<K<N).
<<<<<<< HEAD
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
        long factorialK = 1;

        for (int i = K + 1; i <= N; i++)
        {
            factorialNK *= i;
        }

        long result = factorialNK;
        Console.WriteLine($"N!/K! = {result}");
=======
>>>>>>> 812e9e6ce588415ed551d005b764429f5fc2180e
    }
    static void Question7()
    {
        // 7. Write a program that calculates N!*K!/(N-K)! for given N and K (1<K<N).
<<<<<<< HEAD
        Console.WriteLine("=====Question 6 - program that calculates N!*K!/(N-K)! for given N and K (1<K<N)=====");
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
=======
>>>>>>> 812e9e6ce588415ed551d005b764429f5fc2180e
    }
    static void Question8()
    {
        // 8. In combinatorics, the Catalan numbers are calculated by the following formula: for n ≥ 0. Write a program that calculates the nth Catalan number by given n.
    }
    static void Question9()
    {
        // 9. Write a program that for a given integers n and x, calculates the sum: S
    }
    static void Question10()
    {
        // 10. Write a program that reads from the console a positive integer number N (N < 20) and prints a matrix of numbers as on the figures below: N = 3 N = 4
    }
    static void Question11()
    {
        // 11. Write a program that calculates with how many zeroes the factorial of a given number ends. Examples: N = 10 -> N! = 3628800 -> 2 N = 20 -> N! = 2432902008176640000 -> 4
    }
    static void Question12()
    {
        // 12. Write a program that converts a given number from decimal to binary notation (numeral system).
    }
    static void Question13()
    {
        // 13. Write a program that converts a given number from binary to decimal notation.
    }
    static void Question14()
    {
        // 14. Write a program that converts a given number from decimal to hexadecimal notation.
    }
    static void Question15()
    {
        // 15. Write a program that converts a given number from hexadecimal to decimal notation.
    }
    static void Question16()
    {
        // 16. Write a program that by a given integer N prints the numbers from 1 to N in random order.
    }
    static void Question17()
    {
        // 17. Write a program that given two numbers finds their greatest common divisor (GCD) and their least common multiple (LCM). You may use the formula LCM(a, b) = |a*b| / GCD(a, b).
    }
    static void Question18()
    {
        // 18. * Write a program that for a given number n, outputs a matrix in the form of a spiral: Example for n=4:
    }
}
