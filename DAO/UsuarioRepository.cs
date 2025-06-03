using API_Palusa.models;

namespace API_Palusa.DAO
{
    public class UsuarioRepository : iusuarioRepository
    {
        private readonly ConnectionContext context = new ConnectionContext();
        public List<usuario> Get()
        {
            return context.usuarios.ToList();
        }

        public usuario GetById(int id)
        {
            return context.usuarios.FirstOrDefault(e => e.id == id);
        }

        public void save(usuario usuario)
        {
            context.usuarios.Add(usuario);
            context.SaveChanges();
        }

        public void Update(usuario usuario)
        {
            context.usuarios.Update(usuario); 
            context.SaveChanges();
        }
    }
}
