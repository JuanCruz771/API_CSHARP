using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Palusa.models
{
    [Table("Estoque")]
    public class estoque
    {
        public estoque(string codigo, string descricao, string marca, string quantidade, string local)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.marca = marca;
            this.quantidade = quantidade;
            this.local = local;
        }

        [Key]
        public int id { get; private set; }

        public string codigo { get; set; }
        public string descricao { get; set; }
        public string marca { get; set; }
        public string quantidade { get; set; }
        public string local { get; set; }


    }
}
