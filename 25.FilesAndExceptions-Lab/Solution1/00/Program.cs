using System;

public class Class1 : IFormatProvider
{
    public object GetFormat(Type t)
    {
        if ( t.Equals(this.GetType()) )
            return this;
        return null;
    }
}

public class Class2 : Class1
{
    public int Value { get; set; }
}

public class Example
{
    public static void Main()
    {
        Console.WriteLine(3 is int);
        Console.WriteLine();

        var value = "hello";
        Console.WriteLine("is long : ? " + (value is long) );
        Console.WriteLine("is double : ? " + (value is double));
        Console.WriteLine("is object : ? " + (value is object));
        Console.WriteLine("is valutype : ? " + (value is ValueType));
        Console.WriteLine("is int : ? " + (value is int));
    }
}