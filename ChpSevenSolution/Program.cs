using System.Text;

class ChapterSevenSolution
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
        // Question13();
        // Question14();
        // Question15();
        // Question16();
        // Question17();
        // Question18();
        // Question19();
        // Question20();
        // Question21();
        // Question22();
        // Question23();
        Question24();
        Question25();
    }

    static int[] ReadArrayFromConsole()
    {
        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine()!);
        int[] array = new int[size];

        Console.WriteLine("Enter elements for the array:");
        for (int i = 0; i < size; i++)
        {
            array[i] = int.Parse(Console.ReadLine()!);
        }

        return array;
    }

    static void PrintArray(int[] array, string message)
    {
        Console.WriteLine($"{message}: {string.Join(", ", array)}");
    }
    static void Question1()
    {
        int[] array = new int[20];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i * 5;
        }

        PrintArray(array, "Question 1");
    }

    static void Question2()
    {
        Console.WriteLine("Question 2:");
        int[] array1 = ReadArrayFromConsole();
        int[] array2 = ReadArrayFromConsole();

        bool areEqual = Enumerable.SequenceEqual(array1, array2);
        Console.WriteLine($"The arrays are {(areEqual ? "equal" : "not equal")}");
    }
    
    static void Question3()
    {
        Console.WriteLine("Question 3:");
        char[] array = ReadArrayFromConsole().Select(x => (char)x).ToArray();
        char[] sortedArray = array.OrderBy(c => c).ToArray();
        PrintArray(sortedArray, "Lexicographically sorted array");
    }
    static void PrintArray<T>(T[] array, string message)
    {
        Console.WriteLine($"{message}: {string.Join(", ", array)}");
    }
    static void Question4()
    {
        Console.WriteLine("Question 4:");
        int[] array = ReadArrayFromConsole();
        int[] result = FindMaxSequenceOfEqualElements(array);
        PrintArray(result, "Maximal sequence of consecutive equal elements");
    }
    static int[] FindMaxSequenceOfEqualElements(int[] array)
    {
        int maxCount = 0;
        int currentCount = 1;
        int maxElement = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i - 1])
            {
                currentCount++;
            }
            else
            {
                currentCount = 1;
            }

            if (currentCount > maxCount)
            {
                maxCount = currentCount;
                maxElement = array[i];
            }
        }

        return Enumerable.Repeat(maxElement, maxCount).ToArray();
    }
    static void Question5()
    {
        Console.WriteLine("Question 5:");
        int[] array = ReadArrayFromConsole();
        int[] result = FindMaxSequenceOfIncreasingIntegers(array);
        PrintArray(result, "Maximal sequence of consecutively placed increasing integers");
    }

    static int[] FindMaxSequenceOfIncreasingIntegers(int[] array)
    {
        int maxLength = 1;
        int currentLength = 1;
        int endIndex = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[i - 1])
            {
                currentLength++;
            }
            else
            {
                currentLength = 1;
            }

            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                endIndex = i;
            }
        }

        return array.Skip(endIndex - maxLength + 1).Take(maxLength).ToArray();
    }
    static void Question6()
    {
        Console.WriteLine("Question 6:");
        int[] array = ReadArrayFromConsole();
        int[] result = FindMaxSequenceOfIncreasingElements(array);
        PrintArray(result, "Maximal sequence of increasing elements");
    }

    static int[] FindMaxSequenceOfIncreasingElements(int[] array)
    {
        int maxLength = 1;
        int currentLength = 1;
        int endIndex = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[i - 1])
            {
                currentLength++;
            }
            else
            {
                currentLength = 1;
            }

            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                endIndex = i;
            }
        }

        return array.Skip(endIndex - maxLength + 1).Take(maxLength).ToArray();
    }

    static void Question7()
    {
        Console.WriteLine("Question 7:");
        int[] array = ReadArrayFromConsole();
        Console.Write("Enter the value of K (K < N): ");
        int k = int.Parse(Console.ReadLine()!);
        int result = FindMaxSumConsecutiveElements(array, k);
        Console.WriteLine($"Maximal sum of {k} consecutive elements: {result}");
    }

    static int FindMaxSumConsecutiveElements(int[] array, int k)
    {
        int maxSum = int.MinValue;

        for (int i = 0; i <= array.Length - k; i++)
        {
            int currentSum = array.Skip(i).Take(k).Sum();

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
            }
        }

        return maxSum;
    }
    static void Question8()
    {
        Console.WriteLine("Question 8:");
        int[] array = ReadArrayFromConsole();
        SelectionSort(array);
        PrintArray(array, "Sorted array using selection sort");
    }

    static void SelectionSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }

            if (minIndex != i)
            {
                Swap(ref array[i], ref array[minIndex]);
            }
        }
    }

    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
    static void Question9()
    {
        Console.WriteLine("Question 9:");
        int[] array = ReadArrayFromConsole();
        int result = FindMaxSubsequenceSum(array);
        Console.WriteLine($"Max subsequence sum: {result}");
    }

    static int FindMaxSubsequenceSum(int[] array)
    {
        int maxSum = int.MinValue;
        int currentSum = 0;

        foreach (int num in array)
        {
            currentSum = Math.Max(num, currentSum + num);
            maxSum = Math.Max(maxSum, currentSum);
        }

        return maxSum;
    }
    static void Question10()
    {
        Console.WriteLine("Question 10:");
        int[] array = ReadArrayFromConsole();
        int result = FindMostFrequentlyOccurringElement(array);
        Console.WriteLine($"Most frequently occurring element: {result}");
    }

    static int FindMostFrequentlyOccurringElement(int[] array)
    {
        var frequencyDictionary = array.GroupBy(x => x).ToDictionary(group => group.Key, group => group.Count());

        int maxFrequency = frequencyDictionary.Max(x => x.Value);

        return frequencyDictionary.First(x => x.Value == maxFrequency).Key;
    }
    static void Question11()
    {
        Console.WriteLine("Question 11:");
        int[] array = ReadArrayFromConsole();
        Console.Write("Enter the value of S: ");
        int s = int.Parse(Console.ReadLine()!);
        var result = FindSequenceWithSum(array, s);
        PrintArray(result, $"Sequence with sum {s}");
    }

    static int[] FindSequenceWithSum(int[] array, int s)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int currentSum = 0;
            for (int j = i; j < array.Length; j++)
            {
                currentSum += array[j];
                if (currentSum == s)
                {
                    return array.Skip(i).Take(j - i + 1).ToArray();
                }
            }
        }

        return new int[0];
    }
    static void Question12()
    {
        Console.WriteLine("Question 12:");
        Console.Write("Enter the size of the matrix: ");
        int size = int.Parse(Console.ReadLine()!);
        CreateAndPrintSquareMatrix(size);
    }

    static void CreateAndPrintSquareMatrix(int size)
    {
        int[,] matrix = new int[size, size];

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                matrix[i, j] = i * size + j + 1;
            }
        }

        PrintMatrix(matrix);
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[i, j],3} ");
            }
            Console.WriteLine();
        }
    }

    static void Question13()
    {
        Console.WriteLine("Question 13:");
        Console.Write("Enter the number of rows for the rectangular array: ");
        int rows = int.Parse(Console.ReadLine()!);
        Console.Write("Enter the number of columns for the rectangular array: ");
        int cols = int.Parse(Console.ReadLine()!);

        int[,] array = new int[rows, cols];

        Console.WriteLine("Enter elements for the rectangular array:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = int.Parse(Console.ReadLine()!);
            }
        }

        var result = FindMaxPlatformWithMaxSum(array);
        PrintMatrix(result);
    }

    static int[,] FindMaxPlatformWithMaxSum(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);
        int maxSum = int.MinValue;
        int[,] result = new int[3, 3];

        for (int i = 0; i <= rows - 3; i++)
        {
            for (int j = 0; j <= cols - 3; j++)
            {
                int currentSum = CalculatePlatformSum(array, i, j);
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    result = ExtractPlatform(array, i, j);
                }
            }
        }

        return result;
    }

    static int CalculatePlatformSum(int[,] array, int startRow, int startCol)
    {
        int sum = 0;
        for (int i = startRow; i < startRow + 3; i++)
        {
            for (int j = startCol; j < startCol + 3; j++)
            {
                sum += array[i, j];
            }
        }
        return sum;
    }

    static int[,] ExtractPlatform(int[,] array, int startRow, int startCol)
    {
        int[,] result = new int[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                result[i, j] = array[startRow + i, startCol + j];
            }
        }
        return result;
    }

    static void Question14()
    {
        Console.WriteLine("Question 14:");
        Console.Write("Enter the number of rows for the matrix: ");
        int rows = int.Parse(Console.ReadLine()!);
        Console.Write("Enter the number of columns for the matrix: ");
        int cols = int.Parse(Console.ReadLine()!);

        string[,] matrix = new string[rows, cols];

        Console.WriteLine("Enter elements for the matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = Console.ReadLine()!;
            }
        }

        var result = FindLongestSequenceOfEqualStrings(matrix);
        Console.WriteLine($"Longest sequence of equal string elements: {result}");
    }

    static string FindLongestSequenceOfEqualStrings(string[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        string longestSequence = "";

        for (int i = 0; i < rows; i++)
        {
            string currentSequence = FindLongestEqualSequenceInArray(matrix, i, 0, 0, 1);
            if (currentSequence.Length > longestSequence.Length)
            {
                longestSequence = currentSequence;
            }
        }

        for (int j = 0; j < cols; j++)
        {
            string currentSequence = FindLongestEqualSequenceInArray(matrix, 0, j, 1, 0);
            if (currentSequence.Length > longestSequence.Length)
            {
                longestSequence = currentSequence;
            }
        }

        for (int i = 0; i < rows; i++)
        {
            string currentSequence = FindLongestEqualSequenceInArray(matrix, i, 0, -1, 1);
            if (currentSequence.Length > longestSequence.Length)
            {
                longestSequence = currentSequence;
            }
        }

        for (int j = 0; j < cols; j++)
        {
            string currentSequence = FindLongestEqualSequenceInArray(matrix, rows - 1, j, -1, 1);
            if (currentSequence.Length > longestSequence.Length)
            {
                longestSequence = currentSequence;
            }
        }

        return longestSequence;
    }

    static string FindLongestEqualSequenceInArray(string[,] array, int startRow, int startCol, int rowIncrement, int colIncrement)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        string currentElement = array[startRow, startCol];
        int currentLength = 1;
        int maxLength = 1;

        int currentRow = startRow + rowIncrement;
        int currentCol = startCol + colIncrement;

        while (currentRow >= 0 && currentRow < rows && currentCol >= 0 && currentCol < cols)
        {
            if (array[currentRow, currentCol] == currentElement)
            {
                currentLength++;
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                }
            }
            else
            {
                currentElement = array[currentRow, currentCol];
                currentLength = 1;
            }

            currentRow += rowIncrement;
            currentCol += colIncrement;
        }

        string[] resultArray = new string[maxLength];
        for (int i = 0; i < maxLength; i++)
        {
            resultArray[i] = currentElement;
        }

        return string.Join(", ", resultArray);
    }
    static void Question15()
    {
        Console.WriteLine("Question 15:");
        char[] latinLetters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

        Console.Write("Enter a word: ");
        string word = Console.ReadLine()!;

        var indices = FindLatinLetterIndices(word, latinLetters);
        PrintArray(indices, "Indices of letters from the word");
    }

    static int[] FindLatinLetterIndices(string word, char[] latinLetters)
    {
        return word.Select(c => Array.IndexOf(latinLetters, c) + 1).ToArray();
    }
    static void Question16()
    {
        Console.WriteLine("Question 16:");
        int[] array = ReadArrayFromConsole();
        Console.Write("Enter the element to search: ");
        int elementToFind = int.Parse(Console.ReadLine()!);

        int index = BinarySearch(array, elementToFind);

        Console.WriteLine($"Index of {elementToFind} in the array: {index}");
    }

    static int BinarySearch(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (array[mid] == target)
            {
                return mid;
            }
            else if (array[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return -1;
    }
    static void Question17()
    {
        Console.WriteLine("Question 17:");
        int[] array = ReadArrayFromConsole();
        MergeSort(array);
        PrintArray(array, "Sorted array using merge sort");
    }

    static void MergeSort(int[] array)
    {
        if (array.Length <= 1)
        {
            return;
        }

        int mid = array.Length / 2;
        int[] left = array.Take(mid).ToArray();
        int[] right = array.Skip(mid).ToArray();

        MergeSort(left);
        MergeSort(right);
        Merge(array, left, right);
    }

    static void Merge(int[] result, int[] left, int[] right)
    {
        int i = 0, j = 0, k = 0;

        while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right[j])
            {
                result[k++] = left[i++];
            }
            else
            {
                result[k++] = right[j++];
            }
        }

        while (i < left.Length)
        {
            result[k++] = left[i++];
        }

        while (j < right.Length)
        {
            result[k++] = right[j++];
        }
    }
    static void Question18()
    {
        Console.WriteLine("Question 18:");
        int[] array = ReadArrayFromConsole();
        QuickSort(array, 0, array.Length - 1);
        PrintArray(array, "Sorted array using quick sort");
    }

    static void QuickSort(int[] array, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(array, low, high);

            QuickSort(array, low, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, high);
        }
    }

    static int Partition(int[] array, int low, int high)
    {
        int pivot = array[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (array[j] <= pivot)
            {
                i++;
                Swap(ref array[i], ref array[j]);
            }
        }

        Swap(ref array[i + 1], ref array[high]);
        return i + 1;
    }
    static void Question19()
    {
        Console.WriteLine("Question 19:");
        Console.WriteLine("Prime Number Loading..... ");
        var primes = FindPrimesInRange(1, 10000000);
        PrintArray(primes, "Prime numbers in the range [1…10,000,000]");
    }

    static int[] FindPrimesInRange(int start, int end)
    {
        return Enumerable.Range(start, end - start + 1).Where(IsPrime).ToArray();
    }

    static bool IsPrime(int num)
    {
        if (num < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    static void Question20()
    {
        Console.WriteLine("Question 20:");
        Console.Write("Enter the size of the array: ");
        int n = int.Parse(Console.ReadLine()!);
        int[] array = ReadArraysFromConsole();
        Console.Write("Enter the sum to check for: ");
        int s = int.Parse(Console.ReadLine()!);

        bool hasSubset = CheckSubsetWithSum(array, s);
        Console.WriteLine(hasSubset ? "Yes, there is a subset with the given sum." : "No, there is no subset with the given sum.");
    }

    static bool CheckSubsetWithSum(int[] array, int s)
    {
        int n = array.Length;
        bool[] dp = new bool[s + 1];
        dp[0] = true;

        for (int i = 0; i < n; i++)
        {
            for (int j = s; j >= array[i]; j--)
            {
                if (dp[j - array[i]])
                {
                    dp[j] = true;
                }
            }
        }

        return dp[s];
    }
    static void Question21()
    {
        Console.WriteLine("Question 21:");
        Console.Write("Enter the number of elements (N): ");
        int n = int.Parse(Console.ReadLine()!);
        Console.Write("Enter the number of elements to find (K): ");
        int k = int.Parse(Console.ReadLine()!);
        int[] array = ReadArraysFromConsole();
        Console.Write("Enter the target sum (S): ");
        int s = int.Parse(Console.ReadLine()!);

        var result = FindKElementsWithSum(array, n, k, s);
        if (result.Count > 0)
        {
            Console.WriteLine($"Found a subset: {string.Join(", ", result)}");
        }
        else
        {
            Console.WriteLine("No subset found.");
        }
    }

    static List<int> FindKElementsWithSum(int[] array, int n, int k, int s)
    {
        List<int> currentSubset = new List<int>();
        List<int> result = new List<int>();
        int currentIndex = 0;

        FindKElementsWithSumHelper(array, n, k, s, currentIndex, currentSubset, result);

        return result;
    }

    static void FindKElementsWithSumHelper(int[] array, int n, int k, int s, int currentIndex, List<int> currentSubset, List<int> result)
    {
        if (s == 0 && currentSubset.Count == k)
        {
            result.AddRange(currentSubset);
            return;
        }

        for (int i = currentIndex; i < n; i++)
        {
            currentSubset.Add(array[i]);
            FindKElementsWithSumHelper(array, n, k, s - array[i], i, currentSubset, result);
            currentSubset.RemoveAt(currentSubset.Count - 1);
        }
    }

    static void Question22()
    {
        Console.WriteLine("Question 22:");
        int[] array = ReadArraysFromConsole();
        List<int> result = RemoveMinElementsToSortArray(array);
        Console.WriteLine("Minimum number of elements to remove:" + string.Join(",", result));
    }

    static List<int> RemoveMinElementsToSortArray(int[] array)
    {
        int n = array.Length;
        int[] left = new int[n];
        int[] right = new int[n];

        int maxLength = 0;
        int lastIndex = -1;

        for (int i = 1; i < n; i++)
        {
            left[i] = 1;
            right[i] = -1;

            for (int j = 0; j < i; j++)
            {
                if (array[j] <= array[i] && left[j] + 1 > left[i])
                {
                    left[i] = left[j] + 1;
                    right[i] = j;
                }
            }
            
            if (left[i] > maxLength)
            {
                maxLength = left[i];
                lastIndex = i;
            }
        }

        List<int> result = new List<int>();

        while (lastIndex != -1)
        {
            result.Add(array[lastIndex]);
            lastIndex = right[lastIndex];
        }

        result.Reverse();
        return result;
    }
    static void Question23()
    {
        Console.WriteLine("Question 23:");
        Console.Write("Enter the total number of elements (N): ");
        int n = int.Parse(Console.ReadLine()!);
        Console.Write("Enter the number of elements in each variation (K): ");
        int k = int.Parse(Console.ReadLine()!);

        int[] variations = new int[k];
        GenerateVariations(n, k, variations, 0);
    }
    static void GenerateVariations(int N, int K, int[] variation, int index)
    {
        if (index >= K)
        {
            PrintVariation(variation);
            return;
        }

        for (int i = 1; i <= N; i++)
        {
            variation[index] = i;
            GenerateVariations(N, K, variation, index + 1);
        }
    }

    static void PrintVariation(int[] variation)
    {
        Console.WriteLine("{" + string.Join(", ", variation) + "}");
    }
    static void Question24()
    {
        Console.WriteLine("Question 24:");
        Console.Write("Enter the number of elements (N): ");
        int n = int.Parse(Console.ReadLine()!);
        Console.Write("Enter the number of elements to select (K): ");
        int k = int.Parse(Console.ReadLine()!);

        var combinations = GenerateCombinations(1, n, k);
        PrintCombinations(combinations);
    }

    static List<List<int>> GenerateCombinations(int start, int end, int k)
    {
        List<List<int>> combinations = new List<List<int>>();
        GenerateCombinationsHelper(start, end, k, new List<int>(), combinations);
        return combinations;
    }

    static void GenerateCombinationsHelper(int start, int end, int k, List<int> currentCombination, List<List<int>> combinations)
    {
        if (k == 0)
        {
            combinations.Add(new List<int>(currentCombination));
            return;
        }

        for (int i = start; i <= end; i++)
        {
            currentCombination.Add(i);
            GenerateCombinationsHelper(i + 1, end, k - 1, currentCombination, combinations);
            currentCombination.RemoveAt(currentCombination.Count - 1);
        }
    }

    static void PrintCombinations(List<List<int>> combinations)
    {
        foreach (var combination in combinations)
        {
            Console.WriteLine($"{{ {string.Join(", ", combination)} }}");
        }
    }

    static void Question25()
    {
        Console.WriteLine("Enter the dimensions of the matrix (rows columns):");
        string[] dimensions = Console.ReadLine()!.Split();
        int rows = int.Parse(dimensions[0]);
        int cols = int.Parse(dimensions[1]);

        int[,] matrix = new int[rows, cols];

        Console.WriteLine("Enter the elements of the matrix:");

        for (int row = 0; row < rows; row++)
        {
            string[] rowElements = Console.ReadLine()!.Split();

            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = int.Parse(rowElements[col]);
            }
        }

        int largestArea = FindLargestArea(matrix);
        Console.WriteLine("Largest area of equal numbers: " + largestArea);
    }

    static int FindLargestArea(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        bool[,] visited = new bool[rows, cols];
        int largestArea = 0;

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (!visited[row, col])
                {
                    int currentArea = DFS(matrix, row, col, visited);
                    largestArea = Math.Max(largestArea, currentArea);
                }
            }
        }

        return largestArea;
    }

    static int DFS(int[,] matrix, int row, int col, bool[,] visited)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int currentValue = matrix[row, col];
        int currentArea = 1;

        visited[row, col] = true;

        int[] dx = { -1, 0, 1, 0 };
        int[] dy = { 0, 1, 0, -1 };

        for (int i = 0; i < 4; i++)
        {
            int newRow = row + dx[i];
            int newCol = col + dy[i];

            if (newRow >= 0 && newRow < rows && newCol >= 0 && newCol < cols &&
                matrix[newRow, newCol] == currentValue && !visited[newRow, newCol])
            {
                currentArea += DFS(matrix, newRow, newCol, visited);
            }
        }

        return currentArea;
    }

    static int[] ReadArraysFromConsole()
    {
        Console.WriteLine("Enter the array elements separated by space:");
        return Console.ReadLine()!.Split().Select(int.Parse).ToArray();
    }
}