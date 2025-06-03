using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_Palusa.models
{
    [Table("usuario")]
    public class usuario
    {
        
      
            public usuario(string login, string senha)
            {
                this.login = login;
                this.senha = senha;
               
            }

            [Key]
            public int id { get; private set; }

            public string login { get; set; }
            public string senha { get; set; }


    }
    
}
