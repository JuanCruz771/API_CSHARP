using API_Palusa.models;
using Microsoft.EntityFrameworkCore;

namespace API_Palusa.DAO
{
    public class EstoqueRepository : iestoqueRepository
    {
        private readonly ConnectionContext context = new ConnectionContext();
        public List<estoque> Get()
        {
            return context.estoques.ToList();
        }

        public estoque GetById(int id)
        {
            return context.estoques.FirstOrDefault(e => e.id == id);
        }


        public void save(estoque estoque)
        {
            context.estoques.Add(estoque);
            context.SaveChanges();
        }
        public void Update(estoque estoque)
        {
            context.estoques.Update(estoque); 
            context.SaveChanges();
        }

    }
}
