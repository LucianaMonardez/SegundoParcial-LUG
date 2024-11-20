using Entity;
using Mapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DAL
{
    public class EstudianteDao
    {
        private CursoDao _cursoDao;

        public EstudianteDao()
        {
            this._cursoDao = new CursoDao();
        }

        public Estudiante ObtenerEstudiantePorId(int id) 
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionUtils.GetConnectionString()))
                {
                    sqlConnection.Open();
                    string query = "SELECT * FROM ESTUDIANTE WHERE ID_ESTUDIANTE = @id";

                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                return MappearEstudiante(reader);
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

        public List<Estudiante> ObtenerEstudiantes()
        {
            try
            {
                List<Estudiante> estudiantes = new List<Estudiante>();

                using (SqlConnection sqlConnection = new SqlConnection(ConnectionUtils.GetConnectionString()))
                {
                    sqlConnection.Open();
                    string query = "SELECT * FROM ESTUDIANTE";

                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Estudiante estudiante = MappearEstudiante(reader);

                                estudiantes.Add(estudiante);
                            }
                        }
                    }
                }

                return estudiantes;

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void CrearEstudiante(Estudiante estudiante) 
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionUtils.GetConnectionString()))
                {
                    sqlConnection.Open();

                    string query = "INSERT INTO ESTUDIANTE(NOMBRE, FECHA_NACIMIENTO, PROMEDIO_ACTUAL, ID_CURSO) " +
                        "VALUES(@nombre, @fecha, @promedio, @idCurso)";
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@nombre", estudiante.Nombre);
                        sqlCommand.Parameters.AddWithValue("@fecha", estudiante.FechaNacimiento);
                        sqlCommand.Parameters.AddWithValue("@promedio", estudiante.Promedio);
                        sqlCommand.Parameters.AddWithValue("@idCurso", estudiante.IdCurso);
                        sqlCommand.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void ModificarEstudiante(int id, Estudiante estudiante) 
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionUtils.GetConnectionString()))
                {
                    sqlConnection.Open();

                    string query = "UPDATE ESTUDIANTE SET NOMBRE =@nombre, PROMEDIO_ACTUAL = @promedio, ID_CURSO =@idCurso WHERE ID_ESTUDIANTE = @id";
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@nombre", estudiante.Nombre);
                        sqlCommand.Parameters.AddWithValue("@promedio", estudiante.Promedio);
                        sqlCommand.Parameters.AddWithValue("@idCurso", estudiante.IdCurso);
                        sqlCommand.Parameters.AddWithValue("@id", id);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void EliminarEstudiante(int id) 
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionUtils.GetConnectionString()))
                {
                    sqlConnection.Open();

                    string query = "DELETE FROM ESTUDIANTE WHERE ID_ESTUDIANTE = @id";
                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@id", id);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private Estudiante MappearEstudiante(SqlDataReader reader) 
        {
            Curso curso = _cursoDao.Cursos.FirstOrDefault(x => x.Id == Convert.ToInt32(reader["ID_CURSO"]))
                                    ?? throw new Exception("No se encontro el curso");

            return EstudianteMapper.Map(reader, curso);
        }
    }
}
