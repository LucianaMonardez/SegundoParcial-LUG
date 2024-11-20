using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Transactions;

namespace Business
{
    public class EstudianteBusiness
    {
        private EstudianteDao _estudianteDao;

        public EstudianteBusiness()
        {
            this._estudianteDao = new EstudianteDao();  
        }

        public List<Estudiante> ObtenerEstudiantes() 
        {
            try
            {
                return _estudianteDao.ObtenerEstudiantes();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void CrearEstudiantes(List<Estudiante> estudiantes)
        {
            try
            {
                if (!estudiantes.Any())
                    throw new Exception("No hay estudiantes pre cargadas, por favor agregue estudiantes nuevos");
                try
                {
                    using (TransactionScope transaction = new TransactionScope())
                    {
                        foreach (var estudiante in estudiantes)
                        {
                            CrearEstudiante(estudiante);
                        }
                        transaction.Complete();
                    }
                }
                catch (Exception ex)
                {

                    throw new Exception($"Ocurrio un error al intentar dar de alta los estudiantes: {ex.Message}");
                }
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
                using (TransactionScope transaction = new TransactionScope())
                {
                    ValidarEstudiante(estudiante, true);
                    _estudianteDao.CrearEstudiante(estudiante);
                    transaction.Complete();
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
                using (TransactionScope transaction = new TransactionScope())
                {
                    ValidarEstudiante(estudiante, false);

                    Estudiante estudianteExistente = _estudianteDao.ObtenerEstudiantePorId(id);

                    if (estudianteExistente is null)
                        throw new Exception($"No existe estudiante con el id {id}");

                    _estudianteDao.ModificarEstudiante(id, estudiante);
                    transaction.Complete();
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
                using (TransactionScope transaction = new TransactionScope())
                {
                    Estudiante estudiante = _estudianteDao.ObtenerEstudiantePorId(id);
                    if (estudiante is null)
                        throw new Exception($"No existe el estudiante con el id {id}");

                   _estudianteDao.EliminarEstudiante(id);
                    transaction.Complete();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void ValidarEstudiante(Estudiante estudiante, bool esAlta)
        {
            if (esAlta)
            {
                if (estudiante.FechaNacimiento > DateTime.Now)
                    throw new Exception("El valor ingresado en el capo fecha nacimiento debe ser menor a la fecha actual");

                int edadEstudiante = DateTime.Now.Year - estudiante.FechaNacimiento.Year;
                if (edadEstudiante < 16 || edadEstudiante > 60)
                    throw new Exception("La edad del estudiante debe ser mayor a 16 años y menor a 60 años");

                //Si es alta alumno el promedio debe ser 0
                if (estudiante.Promedio != 0)
                    throw new Exception("El promedio del alumno debe ser 0, ya que se esta dando de alta en el sistema");
            }
            else
            {
                //Se esta modificando el promedio del alumno
                if (estudiante.Promedio < 0 || estudiante.Promedio > 10)
                    throw new Exception("El promedio del alumno debe estar entre 0 y 10");
            }

            if (estudiante.Nombre.Length < 3)
                throw new Exception("El nombre del estudiante debe tener al menos 3 caracteres");

            if (estudiante.IdCurso == 0)
                throw new Exception("El estudiante debe estar asociado a un curso");
        }

    }
}
