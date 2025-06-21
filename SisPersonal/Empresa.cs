namespace Personal
{
    public enum Cargos
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }

    public class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public char EstadoCivil { get; set; }
        public DateTime FechaIngresoEmpresa { get; set; }
        public double SueldoBasico { get; set; }
        public Cargos Cargo { get; set; }

        public Empleado(string nombre, string apellido, DateTime fechaNacimiento, char estadoCivil, DateTime fechaIngreso, double sueldo, Cargos cargo){
            Nombre = nombre;
            Apellido = apellido;
            FechaDeNacimiento = fechaNacimiento;
            EstadoCivil = estadoCivil;
            FechaIngresoEmpresa = fechaIngreso;
            SueldoBasico = sueldo;
            Cargo = cargo;
        }


        public int ObtenerAntiguedad()
        {
            DateTime Hoy = DateTime.Today;
            int antiguedad = Hoy.Year - FechaIngresoEmpresa.Year;
            if ((Hoy.Month < FechaIngresoEmpresa.Month) || ((Hoy.Month == FechaIngresoEmpresa.Month) && (Hoy.Day < FechaIngresoEmpresa.Day)))
            {
                antiguedad--;
            }
            return antiguedad;
        }

        public int ObtenerEdad()
        {
            DateTime Hoy = DateTime.Today;
            int edad = Hoy.Year - FechaDeNacimiento.Year;
            if ((Hoy.Month < FechaDeNacimiento.Month) || ((Hoy.Month == FechaDeNacimiento.Month) && (Hoy.Day < FechaDeNacimiento.Day)))
            {
                edad--;
            }
            return edad;
        }

        public int FaltaParaJubilarse()
        {
            return 65 - ObtenerEdad();
        }

        public double CalcularSalario()
        {
            double adicional;
            int antiguedad = ObtenerAntiguedad();
            if (antiguedad < 20)
            {
                adicional = SueldoBasico * antiguedad / 100;
            } else {
                adicional = SueldoBasico * 0.25;
            }
            if (Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista)
            {
                adicional = adicional * 1.5;   
            }
            if (char.ToUpper(EstadoCivil) == 'C')
            {
                adicional += 150000;
            }
            return SueldoBasico + adicional;
        }
    }
}
