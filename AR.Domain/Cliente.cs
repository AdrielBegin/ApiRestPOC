using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR.Domain
{
    
    public class Cliente
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatorio")]

        [MaxLength(50, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres")]


        public string Nome { get; set; }
        public string CPF { get; set; }
        public string  Idade { get; set; }


    }
}
