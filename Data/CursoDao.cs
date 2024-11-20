using Entity;
using Mapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CursoDao
    {
        public List<Curso> Cursos = new List<Curso>();

        public CursoDao()
        {
            this.Cursos = ObtenerCursos();
        }

        public List<Curso> ObtenerCursos() 
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionUtils.GetConnectionString()))
                {
                    sqlConnection.Open();
                    string query = "SELECT * FROM CURSO";
                    using (SqlCommand command = new SqlCommand(query, sqlConnection)) 
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read()) 
                            {
                                this.Cursos.Add(CursoMapper.Map(reader));
                            }
                        }
                    }
                    sqlConnection.Close();
                }
                return this.Cursos;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public Curso ObtenerPorId(int id) 
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionUtils.GetConnectionString()))
                {
                    sqlConnection.Open();
                    string query = "SELECT * FROM CURSO WHERE ID_CURSO = @id";

                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                return CursoMapper.Map(reader);
                            }
                        }
                    }
                }

                return null;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
