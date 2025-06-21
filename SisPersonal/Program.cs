// See https://aka.ms/new-console-template for more information
using Personal;

Empleado[] empleados = new Empleado[3];

empleados[0] = new Empleado(
    "Camila",
    "Betura",
    new DateTime(2004, 06, 11),
    'S',
    new DateTime(2021, 10, 15),
    65000,
    Cargos.Administrativo
);

empleados[1] = new Empleado(
    "Lucia",
    "Alderete",
    new DateTime(2003, 07, 07),
    'C',
    new DateTime(2020, 05, 10),
    70000,
    Cargos.Ingeniero
);

empleados[2] = new Empleado(
    "Agostina",
    "Salas",
    new DateTime(2001, 02, 05),
    'S',
    new DateTime(2022, 02, 08),
    75000,
    Cargos.Investigador
);

double MontoTotalSalarios = 0;
foreach (Empleado emp in empleados)
{
    MontoTotalSalarios += emp.CalcularSalario();
}
Console.WriteLine($"Monto Total de lo que se paga en concepto de Salarios: ${MontoTotalSalarios}\n");


Empleado ProximoAJubilarse = empleados[0];
foreach (Empleado FuturoJubilado in empleados)
{
    if (FuturoJubilado.FaltaParaJubilarse() < ProximoAJubilarse.FaltaParaJubilarse())
    {
        ProximoAJubilarse = FuturoJubilado;
    }
}

Console.WriteLine("Proximo empleado a jubilarse: ");
Console.WriteLine($"Nombre y Apellido: {ProximoAJubilarse.Nombre} {ProximoAJubilarse.Apellido}");
Console.WriteLine($"Antiguedad: {ProximoAJubilarse.ObtenerAntiguedad()}");
Console.WriteLine($"Edad: {ProximoAJubilarse.ObtenerEdad()}");
Console.WriteLine($"Faltan {ProximoAJubilarse.FaltaParaJubilarse()} anio/s para jubilarse.");
Console.WriteLine($"Salario: {ProximoAJubilarse.CalcularSalario():N2}");