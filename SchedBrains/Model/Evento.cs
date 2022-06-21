using SchedBrains.Helpers;
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
        [MaxLength(250)]
        public string Descricao { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DataInicio { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DataTermino { get; set; }

        [Required]
        public PeriodicidadeEvento Periodicidade { get; set; }

        [Required]
        public SituacaoEvento Situacao { get; set; }

        public string? Contatos { get; set; }

        public string? Imagem { get; set; }

        public Evento(string titulo, string local, string descricao, DateTime dataInicio, DateTime dataTermino, PeriodicidadeEvento periodicidade, SituacaoEvento situacao, string? contatos, string? imagem)
        {
            Titulo = titulo;
            Local = local;
            Descricao = descricao;
            DataInicio = dataInicio;
            DataTermino = dataTermino;
            Periodicidade = periodicidade;
            Situacao = situacao;
            Contatos = contatos;
            Imagem = imagem;
        }

        public Evento() { }
    }
}
