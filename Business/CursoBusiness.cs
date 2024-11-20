using DAL;
using Entity;

namespace Business
{
    public class CursoBusiness
    {
        private CursoDao _cursoDao;

        public CursoBusiness()
        {
            this._cursoDao = new CursoDao();    
        }

        public List<Curso> ObtenerCursos() 
        {
            try
            {
                return _cursoDao.Cursos;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
