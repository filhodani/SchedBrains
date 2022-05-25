using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedBrains.Model
{
    public class Anexo
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Caminho { get; set; }

        [Required]
        public string Extensao { get; set; }
    }
}
