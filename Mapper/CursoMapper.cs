using Entity;
using System.Data.SqlClient;

namespace Mapper
{
    public class CursoMapper
    {
        public static Curso Map(SqlDataReader reader)
        {
            return new Curso(reader.GetInt32(0),
                reader.GetString(1),
                reader.GetString(2),
                reader.GetString(3));
        }
     }
}
