// Задача 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
void Exponentiation (int number, int degree)
{
    int result = number;
    for (int count = 1; count < degree; count++)
        {
            result = result * number;
        }
    Console.WriteLine($"The result is: {result}.");
}

Console.WriteLine("Input a number:");
int userNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a degree:");
int userDegree = Convert.ToInt32(Console.ReadLine());

Exponentiation (userNumber, userDegree);
*/

/*
// Задача 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int Sum (int number)
{
    int result = 0;
    int intermediateFigure = 0;
    int remainingNumber = number;

    for (int count = 0; number > 0; count++)
    {
        intermediateFigure = remainingNumber % 10;
        result = result + intermediateFigure;
        remainingNumber = remainingNumber / 10;
        number = remainingNumber;
    }

    return result;
}

Console.WriteLine("Input a number:");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber < 0)
{
    userNumber *= -1;
}
Console.WriteLine($"The sum of figures is: {Sum (userNumber)}");
*/

// Задача 3. Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
/*
int[] createArray (int size, int min, int max)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1);
    }
    return newArray;
}

void showArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int checkNumberOrSymbol (bool checkValue, int number)
{
    while (checkValue == false)
    {
        Console.WriteLine("It is not a number. Input a number, please.");
        checkValue = int.TryParse(Console.ReadLine(), out number);
    }
    return number;
}

Console.WriteLine("Input a quantity of numbers:");
int userSize;
bool userSizeCheck = int.TryParse(Console.ReadLine(), out userSize);
checkNumberOrSymbol (userSizeCheck, userSize);
if (userSize == 0)
    while (userSize == 0)
        {
            Console.WriteLine("It's impossible to create a massive without a value. Please, input a concrete number.");
            userSizeCheck = int.TryParse(Console.ReadLine(), out userSize);
            userSize = checkNumberOrSymbol (userSizeCheck, userSize);
            if (userSize > 0) { break; }
        }       
if (userSize < 0)
    {
        Console.WriteLine("It's impossible to create a massive with negative value of numbers. Your entered value will be converted to a positive number.");
        userSize *= -1;
        Console.WriteLine($"The quantity of numbers is: {userSize}");
    }

Console.WriteLine("Input a minimal random number:");
int minimalNumber;
bool minimalNumberCheck = int.TryParse(Console.ReadLine(), out minimalNumber);
checkNumberOrSymbol (minimalNumberCheck, minimalNumber);

Console.WriteLine("Input a maximal random number:");
int maximalNumber;
bool maximalNumberCheck = int.TryParse(Console.ReadLine(), out maximalNumber);
checkNumberOrSymbol (minimalNumberCheck, minimalNumber);

if (minimalNumber > maximalNumber)
{
    Console.WriteLine("The minimal number cannot be greater than the maximal number. Try again.");
}
else
{
    int[] userArray = createArray (userSize, minimalNumber, maximalNumber);
    showArray (userArray);
}
*/

