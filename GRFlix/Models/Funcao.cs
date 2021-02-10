using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GRFlix.Models
{
    public class Funcao
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "A expressão não pode ser nula")]
        [RegularExpression(@"^\s*([-+]?)(\d+)(?:\s*([-+*\/])\s*((?:\s[-+])?\d+)\s*)+$", ErrorMessage = "Informe caracteres válidos")]
        public string Expressao { get; set; }
    }
}
