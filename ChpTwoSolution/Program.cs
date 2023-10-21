class ChapterTwoSolution
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
    }
    static void Question1()
    {
        // 1. Declare several variables by selecting for each one of them the most appropriate of the types sbyte, byte, short, ushort, int, uint, long and ulong in order to assign them the following values: 52,130; -115; 4825932; 97; -10000; 20000; 224; 970,700,000; 112; -44; -1,000,000; 1990; 123456789123456789.
        Console.WriteLine("=====Question 1- Assigning Variable=====");
        int intType = -1000000;
        short shortType = -10000;
        sbyte sbyteType1 = -115;
        sbyte sbyteType2 = -44;
        byte byteType = 97;
        byte byteType1 = 112;
        ushort ushortType1 = 224;
        int intType1 = 1990;
        uint uintType1 = 20000;
        ushort ushortType2 = 52130;
        uint uintType2 = 4825932;
        long longType = 970700000;
        ulong ulongType = 123456789123456789;
        Console.WriteLine($"    The lowest negatives value is {intType} followed by {shortType}, {sbyteType1} and {sbyteType2}. The Positives numbers are {byteType}, {byteType1}, {ushortType1}, {intType1}, {uintType1}, {ushortType2}, {uintType2}, {longType}, and {ulongType} respectively.\n   In which the numbers range from {intType} to {ulongType}, i.e. the lowest to the highest.");
    }
    static void Question2()
    {
        // 2. Which of the following values can be assigned to variables of type float, double and decimal: 5, -5.01, 34.567839023; 12.345; 8923.1234857; 3456.091124875956542151256683467?
        Console.WriteLine("=====Question 2- Assigning Variable=====");
        float floatNegNum = -5.01f;
        double doubleNum1 = 5d;
        float floatNum = 12.345f;
        double doubleNum3 = 34.567839023d;
        double doubleNum2 = 8923.1234857d;
        decimal decimalNum = 3456.091124875956542151256683467m;
        Console.WriteLine($"The value {floatNegNum} and {floatNum} are assigned to variable of type float.\nThe value {doubleNum1}, {doubleNum2}, and {doubleNum3} are assigned to variable of type double. While the last and the biggest value ({decimalNum}) was assigned to variable of type decimal.");
    }
    static void Question3()
    {
        // 3.   Write a program, which compares correctly two real numbers with accuracy at least 0.000001.
        Console.WriteLine("=====Question 3- Comparing Real Number Accuracy=====");
        double firstNum = 3.14159265;
        double SecondNum = 3.141593; 
        double accuracy = 0.000001;
        bool equal = Math.Abs(firstNum - SecondNum) < accuracy;
        Console.WriteLine("The number are equal with the specified accuracy.");
    }
    static void Question4()
    {
        // 4. Initialize a variable of type int with a value of 256 in hexadecimal format (256 is 100 in a numeral system with base 16).
        Console.WriteLine("=====Question 4- Hexadecimal Format=====");
        int  valueInHex = 0x100;
        Console.WriteLine("Value in Hexadecimal: "+ valueInHex);
    }
    static void Question5()
    {
        // 5. Declare a variable of type char and assign it as a value the character, which has Unicode code, 72 (use the Windows calculator in order to find hexadecimal representation of 72).
        Console.WriteLine("=====Question 5- Hexadecimal Unicode Representation=====");
        char myChar = (char)0x48;
        Console.WriteLine("The character is: " + myChar);
    }
    static void Question6()
    {
    // 6. Declare a variable isMale of type bool and assign a value to it depending on your gender.
        Console.WriteLine("=====Question 6- Boolean Variable Type=====");
        bool isMale;
        isMale = true;
        Console.WriteLine("Is the person male? " + isMale);
    }
    static void Question7()
    {
        // 7. Declare two variables of type string with values "Hello" and "World". Declare a variable of type object. Assign the value obtained of concatenation of the two string variables (add space if necessary) to this variable. Print the variable of type object.
        Console.WriteLine("=====Question 7- String and Object Variable Type=====");
        string str1 = "Hell0";
        string str2 = "World";
        object obj = str1 +" " + str2;
        Console.WriteLine("The Concatenation of the two string variables is: " + obj);
    }
    static void Question8()
    {
        // 8. Declare two variables of type string and give them values "Hello" and "World". Assign the value obtained by the concatenation of the two variables of type string (do not miss the space in the middle) to a variable of type object. Declare a third variable of type string and initialize it with the value of the variable of type object (you should use type casting).
        Console.WriteLine("=====Question 8- String and Object Variable Type=====");
        string str1 = "Hell0";
        string str2 = "World";
        object obj = str1 +" " + str2;
        string str3 = (string)obj;
        Console.WriteLine("The Concatenation of the three string variables is: " + str3);
    }
    static void Question9()
    {
        // 9. Declare two variables of type string and assign them a value “The "use" of quotations causes difficulties.” (without the outer quotes). In one of the variables use quoted string and in the other do not use it.
        Console.WriteLine("=====Question 9- String  Variable Type=====");
        string stringWithQuotes = "The \"use\" of quotations causes difficulties.";
        string stringWithoutQuotes = "The use of quotations causes difficulties.";
        Console.WriteLine("String with Quotes: " + stringWithQuotes);
        Console.WriteLine("String without Quotes: " + stringWithoutQuotes);
    }
    static void Question10()
    {
        // 10. Write a program to print a figure in the shape of a heart by the sign "o".
        Console.WriteLine("=====Question 10- Shape of Heart using \"o\"=====");
        Console.WriteLine("  o     o  ");
        Console.WriteLine(" o  o o  o ");
        Console.WriteLine("  o  o  o  ");
        Console.WriteLine("   o   o   ");
        Console.WriteLine("    o o    ");
        Console.WriteLine("     o     ");
    }
    static void Question11()
    {
        // 11. Write a program that prints on the console isosceles triangle which sides consist of the copyright character "©".
        Console.WriteLine("=====Question 11- Isosceles Triangle using \"©\"=====");
        Console.WriteLine("    ©   ");
        Console.WriteLine("   ©©©  ");
        Console.WriteLine("  ©©©©© ");
        Console.WriteLine(" ©©©©©©©");
    }
    static void Question12()
    {
        // 12. A company dealing with marketing wants to keep a data record of its employees. Each record should have the following characteristic – first name, last name, age, gender (‘m’ or ‘f’) and unique employee number (27560000 to 27569999). Declare appropriate variables needed to maintain the information for an employee by using the appropriate data types and attribute names.
        Console.WriteLine("=====Question 12- Employee Information=====");
        string firstName = "Bastu";
        string lastName = "Tahir";
        int Age = 28;
        char Gender = 'm';
        int EmployeeNumber = 27560001;
        Console.WriteLine($"Employee name: {lastName} {firstName}");
        Console.WriteLine($"Employee age: {Age}");
        Console.WriteLine($"Employee gender: {Gender}");
        Console.WriteLine($"Employee number: {EmployeeNumber}");
    }
    static void Question13()
    {
        // 13. Declare two variables of type int. Assign to them values 5 and 10 respectively. Exchange (swap) their values and print them.
        Console.WriteLine("=====Question 13- Value Swapping=====");
        int num1 = 5;
        int num2 = 10;
        int swapNum = num1;
        num1 = num2;
        num2 = swapNum;
        Console.WriteLine("num1: " + num1);
        Console.WriteLine("num2: " + num2);
    }
}