namespace Entity
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public double Promedio { get; set; }
        public int IdCurso { get; set; }
        public string NombreCurso { get => Curso.Nombre; }
        public Curso Curso { get; set; }

        public Estudiante(string nombre, DateTime fechaNacimiento, double promedio, int idCurso)
        {
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            Promedio = promedio;
            IdCurso = idCurso;
        }

        public Estudiante(string nombre, double promedio, int idCurso)
        {
            Nombre = nombre;
            Promedio = promedio;
            IdCurso = idCurso;
        }

        public Estudiante(int id, string nombre, DateTime fechaNacimiento, double promedio, int idCurso, Curso curso)
        {
            Id = id;
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            Promedio = promedio;
            IdCurso = idCurso;
            Curso = curso;
        }
    }
}
