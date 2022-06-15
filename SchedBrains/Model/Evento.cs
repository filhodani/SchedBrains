using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedBrains.Model
{
    public class Evento
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Titulo { get; set; }

        [Required]
        [MaxLength(50)]
        public string Local { get; set; }

        [Required]
        [MaxLength(50)]
        public string Descricao { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DataInicio { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DataTermino { get; set; }

        [Required]
        [MaxLength(50)]
        public string Periodicidade { get; set; }

        [Required]
        [MaxLength(50)]
        public string Status { get; set; }

        [Required]
        [MaxLength(50)]
        public string Contato { get; set; }

        [Required]
        [MaxLength(50)]
        public string Imagem { get; set; }

        public Evento(string titulo, string local, string descricao, DateTime dataInicio, DateTime dataTermino, string periodicidade, string status, string contato, string imagem)
        {
            Titulo = titulo;
            Local = local;
            Descricao = descricao;
            DataInicio = dataInicio;
            DataTermino = dataTermino;
            Periodicidade = periodicidade;
            Status = status;
            Imagem = imagem;
            Contato = contato;
        }

        public Evento() { }
    }
}
