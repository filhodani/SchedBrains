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


        //public Tarefa(string _Titulo, string? _Descricao, DateTime? _DataMaximaConclusao,
        //    PrioridadeTarefa _Prioridade, string? _Anexos, string? _Contatos, string? _Evento, SituacaoTarefa _Situacao)
        //{
        //    DataCriacao = DateTime.Now;
        //    Titulo = _Titulo;
        //    Descricao = _Descricao;
        //    DataMaximaConclusao = _DataMaximaConclusao;
        //    Prioridade = _Prioridade;
        //    Anexos = _Anexos;
        //    Contatos = _Contatos;
        //    Evento = _Evento;
        //    Situacao = _Situacao;
        //}
    }
}
