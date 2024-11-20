using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class EstudianteMapper
    {
        public static Estudiante Map(SqlDataReader reader, Curso curso) 
        {
            return new Estudiante(reader.GetInt32(0),
                reader.GetString(1),
                reader.GetDateTime(2),
                Convert.ToDouble(reader.GetDecimal(3)),
                reader.GetInt32(4),
                curso);
        }
    }
}
