// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// int a;
// int b;

// a = 10;
// b=a;

// Console.WriteLine("valor de a:"+a);
// Console.WriteLine("valor de b:"+b);

// Console.WriteLine("Ingrese un número:");
// string input = Console.ReadLine();
// if (int.TryParse(input, out int number) && number > 0)
// {
//     int reversedNumber = ReverseNumber(number);
//     Console.WriteLine("El número invertido es: " + reversedNumber);
// }
// else
// {
//     Console.WriteLine("El texto ingresado no es un número válido o el número es menor o igual a 0.");
// }

// static int ReverseNumber(int number)
// {
//     int reversedNumber = 0;
//     while (number != 0)
//     {
//         int remainder = number % 10;
//         reversedNumber = reversedNumber * 10 + remainder;
//         number /= 10;
//     }
//     return reversedNumber;
// }

//ejercicio 2

bool realizarCalculo = true;

while (realizarCalculo)
{
    Console.WriteLine("Calculadora");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");

    Console.WriteLine("Ingrese la opción deseada:");
    string opcion = Console.ReadLine();

    Console.WriteLine("Ingrese el primer número:");
    double num1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el segundo número:");
    double num2 = double.Parse(Console.ReadLine());

    double resultado = 0;

    switch (opcion)
    {
        case "1":
            resultado = num1 + num2;
            Console.WriteLine("El resultado de la suma es: " + resultado);
            break;
        case "2":
            resultado = num1 - num2;
            Console.WriteLine("El resultado de la resta es: " + resultado);
            break;
        case "3":
            resultado = num1 * num2;
            Console.WriteLine("El resultado de la multiplicación es: " + resultado);
            break;
        case "4":
            if (num2 != 0)
            {
                resultado = num1 / num2;
                Console.WriteLine("El resultado de la división es: " + resultado);
            }
            else
            {
                Console.WriteLine("No se puede dividir entre 0.");
            }
            break;
        default:
            Console.WriteLine("Opción inválida.");
            break;
    }

    Console.WriteLine("¿Desea realizar otro cálculo? (s/n)");
    string respuesta = Console.ReadLine();

    if (respuesta.ToLower() != "s")
    {
        realizarCalculo = false;
    }

    Console.WriteLine();

}