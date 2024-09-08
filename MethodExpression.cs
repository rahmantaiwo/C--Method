public class MethodExperession
{

    public void Add()
    {
        int a = 3;
        int b = 5;

        int sum = a + b;

        Console.WriteLine($"The sum of {a} + {b} = {sum}");
    }
    
    public void Add(int a, int b)
    {
        int sum  = a + b;
        Console.WriteLine($"The sum of {a} + {b} = {sum}");
    }
}



public class MultiplictionSolved
{

    public void Multiply()
    {
        int x = 5;
        int y = 6;

        int product = x * y;

        Console.WriteLine($"The Product of {x} * {y} = {product}");
    }

    public void Multiply(int x, int y)
    {
        int product = x * y;
        Console.WriteLine($"The Product of {x} * {y} = {product}");
    }
    
}

public class IntegerProgram
{
    public void value()
    {
    int a = 5;
    int b = 4;
    if (a == b)
    {
        Console.WriteLine($"{a} and {b} are equal");
    } 
    else
    {
        Console.WriteLine($"{a} and {b} are not equal");
    }
    }
    public void value(int a, int b)
    {
        if (a == b)
    {
        Console.WriteLine($"{a} and {b} are equal");
    } 
    else
    {
        Console.WriteLine($"{a} and {b} are not equal");
    } 
    }
}

public class CalculatorSolver
{
    int n1 = 10;
    int n2 = 20;
    int sum;
    int product;
    int divide;

    public void Sum(int n1, int n2)
    {
        int sum = n1 + n2;
        Console.WriteLine($"The sum of {n1} + {n2} = {sum}");
    }
     public void Product(int n1, int n2)
    {
        int product = n1 * n2;
        Console.WriteLine($"The sum of {n1} * {n2} = {product}");
    }
     public void Divide(int n1, int n2)
    { 
        int divide = n1 / n2;
        Console.WriteLine($"The sum of {n1} / {n2} = {divide}");
    }
    
}

public class NameHuman
{
    public void Boys()
    {
        string firstName = "Raji";
        string lastName = "Tunde";

        string fullName = firstName + " " + lastName;
        Console.WriteLine($"My full name is {firstName} + {lastName} = {fullName}");
    }
    public void Boys(string firstName, string lastName)
    {
        string fullName = firstName + " " + lastName;
        Console.WriteLine($"My full name is {firstName} + {lastName} = {fullName}");
    }
}