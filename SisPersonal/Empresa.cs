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


        public int ObtenerAntiguedad()
        {
            DateTime Hoy = DateTime.Today;
            int antiguedad = FechaIngresoEmpresa.Year - Hoy.Year;
            if ((Hoy.Month < FechaIngresoEmpresa.Month) || ((Hoy.Month == FechaIngresoEmpresa.Month) && (Hoy.Day < FechaIngresoEmpresa, Day)))
            {
                antiguedad--;
            }
            return antiguedad;
        }

        public int ObtenerEdad()
        {
            DateTime Hoy = DateTime.Today;
            int edad = FechaDeNacimiento.Year - Hoy.Year;
            if ((Hoy.Month < FechaDeNacimiento.Month) || ((Hoy.Month == FechaDeNacimiento.Month) && (Hoy.Day < FechaIngresoEmpresa, Day)))
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
            
        }
    }
}
