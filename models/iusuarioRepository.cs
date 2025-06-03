namespace API_Palusa.models
{
    public interface iusuarioRepository
    {
        void save(usuario usuario);

        List<usuario> Get();
        usuario GetById(int id);

        void Update(usuario usuario);
    }
}
