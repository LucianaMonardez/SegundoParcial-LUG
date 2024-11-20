using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Profesor { get; set; }
        public string Horario { get; set; }

        public Curso(int id, string nombre, string profesor, string horario)
        {
            Id = id;
            Nombre = nombre;
            Profesor = profesor;
            Horario = horario;
        }
    }
}
