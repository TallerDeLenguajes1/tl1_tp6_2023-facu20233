// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

bool realizarCalculo = true;

while (realizarCalculo)
{
    Console.WriteLine("Calculadora");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Valor absoluto");
    Console.WriteLine("6. Cuadrado");
    Console.WriteLine("7. Raíz cuadrada");
    Console.WriteLine("8. Seno");
    Console.WriteLine("9. Coseno");
    Console.WriteLine("10. Parte entera de un float");
    Console.WriteLine("11. Máximo entre dos números");
    Console.WriteLine("12. Mínimo entre dos números");

    Console.WriteLine("Ingrese la opción deseada:");
    string opcion = Console.ReadLine();

    if (opcion == "5" || opcion == "6" || opcion == "7" || opcion == "8" || opcion == "10")
    {
        Console.WriteLine("Ingrese un número:");
        double numero = double.Parse(Console.ReadLine());
        double resultado = 0;

        switch (opcion)
        {
            case "5":
                resultado = Math.Abs(numero);
                Console.WriteLine("El valor absoluto del número es: " + resultado);
                break;
            case "6":
                resultado = Math.Pow(numero, 2);
                Console.WriteLine("El cuadrado del número es: " + resultado);
                break;
            case "7":
                if (numero >= 0)
                {
                    resultado = Math.Sqrt(numero);
                    Console.WriteLine("La raíz cuadrada del número es: " + resultado);
                }
                else
                {
                    Console.WriteLine("No se puede calcular la raíz cuadrada de un número negativo.");
                }
                break;
            case "8":
                resultado = Math.Sin(numero);
                Console.WriteLine("El seno del número es: " + resultado);
                break;
            case "10":
                resultado = Math.Floor(numero);
                Console.WriteLine("La parte entera del número es: " + resultado);
                break;
            default:
                Console.WriteLine("Opción inválida.");
                break;
        }
    }
    else if (opcion == "11" || opcion == "12")
    {
        Console.WriteLine("Ingrese el primer número:");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        double num2 = double.Parse(Console.ReadLine());

        double resultado = 0;

        switch (opcion)
        {
            case "11":
                resultado = Math.Max(num1, num2);
                Console.WriteLine("El máximo entre los dos números es: " + resultado);
                break;
            case "12":
                resultado = Math.Min(num1, num2);
                Console.WriteLine("El mínimo entre los dos números es: " + resultado);
                break;
            default:
                Console.WriteLine("Opción inválida.");
                break;
        }
    }
    else
    {
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
    }

    Console.WriteLine("¿Desea realizar otro cálculo? (s/n)");
    string respuesta = Console.ReadLine();

    if (respuesta.ToLower() != "s")
    {
        realizarCalculo = false;
    }

    Console.WriteLine();
}