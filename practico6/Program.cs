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

//ejercicios

Console.WriteLine("Ingrese una cadena de texto:");
string cadena = Console.ReadLine();

// Obtener la longitud de la cadena
int longitud = cadena.Length;
Console.WriteLine("La longitud de la cadena es: " + longitud);

Console.WriteLine("Ingrese otra cadena de texto:");
string segundaCadena = Console.ReadLine();

// Concatenar las cadenas distintas
string concatenacion = cadena + segundaCadena;
Console.WriteLine("La concatenación de las cadenas es: " + concatenacion);

// Extraer una subcadena de la cadena ingresada
Console.WriteLine("Ingrese el índice inicial para extraer la subcadena:");
int indiceInicial = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la longitud de la subcadena:");
int longitudSubcadena = int.Parse(Console.ReadLine());

string subcadena = cadena.Substring(indiceInicial, longitudSubcadena);
Console.WriteLine("La subcadena extraída es: " + subcadena);

// Utilizar la calculadora para operar dos números y mostrar el resultado
Console.WriteLine("Ingrese el primer número:");
double num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo número:");
double num2 = double.Parse(Console.ReadLine());

double resultadoSuma = num1 + num2;
double resultadoResta = num1 - num2;
double resultadoMultiplicacion = num1 * num2;
double resultadoDivision = num1 / num2;

Console.WriteLine("La suma de " + num1 + " y " + num2 + " es igual a: " + resultadoSuma);
Console.WriteLine("La resta de " + num1 + " y " + num2 + " es igual a: " + resultadoResta);
Console.WriteLine("La multiplicación de " + num1 + " y " + num2 + " es igual a: " + resultadoMultiplicacion);
Console.WriteLine("La división de " + num1 + " entre " + num2 + " es igual a: " + resultadoDivision);

// Recorrer la cadena de texto con un ciclo foreach
Console.WriteLine("Recorrido de la cadena de texto con foreach:");
foreach (char caracter in cadena)
{
    Console.WriteLine(caracter);
}

// Buscar la ocurrencia de una palabra determinada en la cadena ingresada
Console.WriteLine("Ingrese una palabra para buscar en la cadena:");
string palabraBuscada = Console.ReadLine();

bool palabraEncontrada = cadena.Contains(palabraBuscada);
Console.WriteLine("¿La palabra se encuentra en la cadena?: " + palabraEncontrada);

// Convertir la cadena a mayúsculas y luego a minúsculas
string cadenaMayusculas = cadena.ToUpper();
string cadenaMinusculas = cadena.ToLower();

Console.WriteLine("Cadena en mayúsculas: " + cadenaMayusculas);
Console.WriteLine("Cadena en minúsculas: " + cadenaMinusculas);

// Separar la cadena por caracteres determinados y mostrar los resultados
Console.WriteLine("Ingrese los caracteres separadores:");
string separadores = Console.ReadLine();

string[] partes = cadena.Split(separadores.ToCharArray());

Console.WriteLine("Resultados después de separar la cadena:");
foreach (string parte in partes)
{
    Console.WriteLine(parte);
}

// Resolver una ecuación simple ingresada como cadena de caracteres
Console.WriteLine("Ingrese una ecuación simple (por ejemplo, '582+2'):");
string ecuacion = Console.ReadLine();

string[] elementos = ecuacion.Split('+');
double operando1 = double.Parse(elementos[0]);
double operando2 = double.Parse(elementos[1]);
double resultadoEcuacion = operando1 + operando2;

Console.WriteLine("El resultado de la ecuación es: " + resultadoEcuacion);
    