// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// int a;
// int b;

// a = 10;
// b=a;

// Console.WriteLine("valor de a:"+a);
// Console.WriteLine("valor de b:"+b);

Console.WriteLine("Ingrese un número:");
string input = Console.ReadLine();
if (int.TryParse(input, out int number) && number > 0)
{
    int reversedNumber = ReverseNumber(number);
    Console.WriteLine("El número invertido es: " + reversedNumber);
}
else
{
    Console.WriteLine("El texto ingresado no es un número válido o el número es menor o igual a 0.");
}

static int ReverseNumber(int number)
{
    int reversedNumber = 0;
    while (number != 0)
    {
        int remainder = number % 10;
        reversedNumber = reversedNumber * 10 + remainder;
        number /= 10;
    }
    return reversedNumber;
}

//v1