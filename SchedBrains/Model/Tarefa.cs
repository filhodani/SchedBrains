using SchedBrains.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedBrains.Model
{
    public class Tarefa
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(26)]
        public string Titulo { get; set; }

        [MaxLength(2130)]
        public string? Descricao { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DataMaximaConclusao { get; set; }

        [Required]
        public PrioridadeTarefa Prioridade { get; set; }

        public string? Anexos { get; set; }

        public string? Contatos { get; set; }

        public int? EventoId { get; set; }
        public Evento Evento { get; set; }

        [NotMapped]
        public string TituloEvento
        {
            get
            {
                if (Evento != null)
                    return Evento.Titulo;

                return "";
            }
        }

        [Required]
        public SituacaoTarefa Situacao { get; set; }


        public Tarefa(string titulo, string? descricao, DateTime? dataMaximaConclusao, PrioridadeTarefa prioridade, string? anexos, string? contatos, int? eventoId, SituacaoTarefa situacao)
        {
            Titulo = titulo;
            Descricao = descricao;
            DataMaximaConclusao = dataMaximaConclusao;
            Prioridade = prioridade;
            Anexos = anexos;
            Contatos = contatos;
            EventoId = eventoId;
            Situacao = situacao;
        }

        public Tarefa() { }
    }
}
