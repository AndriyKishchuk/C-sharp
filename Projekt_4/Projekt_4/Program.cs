using System;

class Program
{
    delegate int Mydelegate(int a, int b);

    static int Add(int x, int y)
    {
        return x + y;
    }
    static int Subtract(int x, int y)
    {
        return x - y;
    }
    static int Multiply(int x, int y)
    {
        return x * y;
    }
    static void Main()
    {
        Mydelegate mydelegate = Add;
        mydelegate += Subtract;
        mydelegate += Multiply;


        Console.WriteLine(mydelegate(1, 3));
        //  Console.WriteLine(mydelegate(10, 5));
        /*
                Console.WriteLine(Calculate(10, 5, Add));
                Console.WriteLine(Calculate(10, 5, Subtract));

                Action<string> print = message => Console.WriteLine(message);
                print("Hello, World!");

                Func<int, int, int> multiply = (x, y) => x * y;
                int result = multiply(10, 5);
                Console.WriteLine(result);

                List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };


                Predicate<int> isEven = n => n % 2 == 0;
                var evenNumbers = numbers.FindAll(isEven);
                Console.WriteLine(string.Join(", ", evenNumbers));



            }
            static int Calculate(int a, int b, Mydelegate del)
            {
                return del(a, b);
            }*/

        var myClass = new MyClass();
        myClass.MyEvent += amount => Console.WriteLine($"Amount withdrawn: {amount:C}");
        myClass.Withdraw(100);


    }
}
public class MyClass
{
    public event Action<decimal> MyEvent;

    public void Withdraw(decimal amount)
    {
        Console.WriteLine($"Withdrawing {amount:C}");
        MyEvent?.Invoke(amount);
    }
}