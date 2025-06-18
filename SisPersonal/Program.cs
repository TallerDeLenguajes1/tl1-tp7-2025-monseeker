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
    Cargo.Administrativo
);

empleados[1] = new Empleado(
    "Lucia",
    "Alderete",
    new DateTime(2003, 07, 07),
    'C',
    new DateTime(2020, 05, 10),
    70000,
    Cargo.Ingeniero
);

empleados[2] = new Empleado(
    "Agostina",
    "Salas",
    new DateTime(2004, 02, 05),
    'S',
    new DateTime(2022, 02, 08),
    75000,
    Cargo.Investigador
);