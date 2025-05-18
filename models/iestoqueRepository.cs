namespace API_Palusa.models
{
    public interface iestoqueRepository
    {
        void save(estoque estoque);

        List<estoque> Get();
        estoque GetById(int id);

        void Update(estoque estoque);
    }

}
