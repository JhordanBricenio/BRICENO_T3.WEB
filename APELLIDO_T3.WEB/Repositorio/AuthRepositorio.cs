using APELLIDO_T3.WEB.DB;
using APELLIDO_T3.WEB.Models;

namespace APELLIDO_T3.WEB.Repositorio
{
    public interface IAuthRepositorio
    {
        Usuario aunteticacion(string username);
        bool aunteticacionCokie(string username, string password);


    }
    public class AuthRepositorio : IAuthRepositorio
    {
        private DbEntities _dbEntities;
        public AuthRepositorio(DbEntities dbEntities)
        {
            _dbEntities = dbEntities;
        }
        public Usuario aunteticacion(string username)
        {
            return _dbEntities.Usuarios.First(o => o.Username == username);
        }

        public bool aunteticacionCokie(string username, string password)
        {
            return _dbEntities.Usuarios.Any(o => o.Username == username && o.Password == password);
        }
    }
}
