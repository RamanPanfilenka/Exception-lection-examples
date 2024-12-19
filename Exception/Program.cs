
Console.Write("Enter your age: ");
var ageString = Console.ReadLine();

double number1 = 1.1d;
int number2 = (int)number1;
int age = 0;
var age1 = int.Parse(ageString);

try
{
    if (age < 18)
        throw new NotLegalAgeException(age);

    Console.WriteLine("Welcome");
}
catch (FileNotFoundException ex) 
{ 
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


var test1 = new Test1();

try
{
    test1.Calculate(1, 0);
    Console.WriteLine("After main try");
}
catch (Exception ex)
{
    Console.WriteLine("Main Catch");
    Console.WriteLine(ex.StackTrace);
}
finally
{
    Console.WriteLine("MainFinally");
}


while (true) 
{
    Console.Write("Enter the number 1: ");
    var result1 = Console.ReadLine();
    Console.Write("Enter the number 2: ");
    var result2 = Console.ReadLine();

    try 
    {
        int number1 = int.Parse(result1);
        int number2 = int.Parse(result2);

        var result = number1 / number2;
        Console.WriteLine(result);
    }
    catch (ArgumentNullException ex)
    {
        Console.WriteLine("Sorry, it is null");
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine("Sorry, but I can not divide number on zero. Try one more time. Have a good day! ");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Something went wrong!");
        Console.WriteLine($"Type: {ex.GetType()}");
        Console.WriteLine($"Message: {ex.Message}");
    }  
}

class Test1 
{
    public void Calculate(int a, int b) 
    {
        var test2 = new Test2();
       
        try
        {
            test2.Calculate2(a, b);
            Console.WriteLine("After Calculate try");
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Calculate Catch");
        }
        finally
        {
            Console.WriteLine("Calculate Finally");
        }
    }
}
class Test2
{
    public void Calculate2(int a, int b)
    {
        try
        {
            throw new NotImplementedException();
            Console.WriteLine("After Calculate2 try");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Calculate2 Catch");
        }
        finally 
        {
            Console.WriteLine("Calculate2 Finally");
        }
    }
}

class AgeException : Exception
{
    private int _actualAge;

    public AgeException(int actualAge, string message) : base(message)
    {
        _actualAge = actualAge;
    }


    public AgeException(int actualAge) : base($"This person has age less than 18, but was {actualAge}")
    {
        _actualAge = actualAge;
    }

    public int ActualAge => _actualAge;
}
class NotLegalAgeException : AgeException
{
    public NotLegalAgeException(int actualAge) : base(actualAge, "")
    {
    }
}

