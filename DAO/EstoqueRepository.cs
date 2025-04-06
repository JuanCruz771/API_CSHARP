using API_Palusa.models;

namespace API_Palusa.DAO
{
    public class EstoqueRepository : iestoqueRepository
    {
        private readonly ConnectionContext context = new ConnectionContext();
        public List<estoque> Get()
        {
            return context.estoques.ToList();
        }

        public void save(estoque estoque)
        {
            context.estoques.Add(estoque);
            context.SaveChanges();
        }
    }
}
