// See https://aka.ms/new-console-template for more information
using EspacioCalculadora;

Calculadora calc = new Calculadora();
bool otraOperacion = true;
Console.WriteLine("Calculadora");
do
{
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir\n");
    Console.WriteLine("Seleccione la operacion: ");
    string cadena = Console.ReadLine();
    if (double.TryParse(cadena, out double elegirOperacion))
    {
        Console.WriteLine("Ingrese un numero: ");
        cadena = Console.ReadLine();
        if (double.TryParse(cadena, out double num))
        {
            switch (elegirOperacion)
            {
                case 1:
                    calc.Sumar(num);
                    Console.WriteLine($"Resultado: {calc.Resultado()}\n");
                    break;
                case 2:
                    calc.Restar(num);
                    Console.WriteLine($"Resultado: {calc.Resultado()}\n");
                    break;
                case 3:
                    calc.Multiplicar(num);
                    Console.WriteLine($"Resultado: {calc.Resultado()}\n");
                    break;
                case 4:
                    calc.Dividir(num);
                    Console.WriteLine($"Resultado: {calc.Resultado()}\n");
                    break;
                default:
                    Console.WriteLine("Ingrese una opcion valida.\n");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Ingrese un numero.\n");
        }

        bool valido = false;
        do
        {
            Console.WriteLine("Desea realizar otra operacion?");
            Console.WriteLine("1.Si \t2.No\n");
            cadena = Console.ReadLine();
            if (int.TryParse(cadena, out int desicion))
            {
                if (desicion == 1)
                {
                    valido = true;
                    otraOperacion = true;
                }
                else if (desicion == 2)
                {
                    valido = true;
                    otraOperacion = false;
                }
                else
                {
                    Console.WriteLine("Ingrese un numero valido.\n");
                }
            }
            else
            {
                Console.WriteLine("Ingrese un numero.\n");
            }
        } while (!valido);

    }
    else
    {
        Console.WriteLine("Ingrese un numero.\n");
    }

} while (otraOperacion);
calc.Limpiar();