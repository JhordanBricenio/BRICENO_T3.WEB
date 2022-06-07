using APELLIDO_T3.WEB.DB;
using APELLIDO_T3.WEB.Models;

namespace APELLIDO_T3.WEB.Repositorio
{

    public interface IHistoriaRepositorio
    {
        List<HistoriaClinica> ObtenerTodos();


        void Agregar(HistoriaClinica historiaClinica);
    }
    public class HistoriaRepositorio : IHistoriaRepositorio
    {

        private DbEntities _dbEntities;
        public HistoriaRepositorio(DbEntities dbEntities)
        {
            _dbEntities = dbEntities;
        }

        public void Agregar(HistoriaClinica historiaClinica)
        {
            _dbEntities.Add(historiaClinica);
            _dbEntities.SaveChanges();
        }

        public List<HistoriaClinica> ObtenerTodos()
        {
            return _dbEntities.HistoriaClinicas.ToList();
        }
    }
}
