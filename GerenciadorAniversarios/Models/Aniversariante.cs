using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorAniversarios.Models
{
    public class Aniversariante
    {
        public int AniversarianteId { get; set; }
        [StringLength(100)]
        public string Nome { get; set; }
        [StringLength(100)]
        public string Sobrenome { get; set; }
        [StringLength(100)]
        public DateTime Aniversario { get; set; }   
    }
}
