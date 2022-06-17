using Microsoft.EntityFrameworkCore;
using SchedBrains.Helpers;
using SchedBrains.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedBrains.Controller
{
    internal class TarefaController : DefaultController
    {
        private static void Validar(Tarefa tarefa)
        {
            if (tarefa.Titulo.Trim() == "")
                throw new Exception("É necessário informar um título para a tarefa!");

            if (tarefa.Titulo.Length > 26)
                throw new Exception("Título muito grande!");

            if (tarefa.Descricao != null && tarefa.Descricao.Length > 2130)
                throw new Exception("Descrição muito grande!");

            if (tarefa.DataMaximaConclusao != null && tarefa.DataMaximaConclusao < DateTime.Now)
                throw new Exception("Data de conclusão inválida!");

            /* Verificar se o id do evento existe no banco
             * Verificar se a prioridade está presente no enum for no slide
             * if (tarefa.Prioridade)
                throw new Exception("É necessário informar um título para a tarefa!");*/

            bool invalido = true;
            foreach (PrioridadeTarefa y in Enum.GetValues(typeof(PrioridadeTarefa)))
            {
                if (y == tarefa.Prioridade)
                {
                    invalido = false;
                    break;
                }
            }
            if (invalido)
                throw new Exception("Prioridade inválida!");
        }

        internal static void Adicionar(Tarefa tarefa)
        {
            if (tarefa != null)
            {
                Validar(tarefa);

                dataContext.Add(tarefa);
                dataContext.SaveChanges();
            }
        }

        internal static void Atualizar(Tarefa tarefa)
        {
            if (tarefa != null)
            {
                Validar(tarefa);

                dataContext.TBTarefa.Update(tarefa);
                dataContext.SaveChanges();
            }
        }

        internal static void Excluir(Tarefa tarefa)
        {
            if (tarefa != null)
            {
                dataContext.TBTarefa.Remove(tarefa);
                dataContext.SaveChanges();
            }
            else
                throw new Exception();
        }

        internal static List<Tarefa> Listar()
        {
            return dataContext.TBTarefa.Include(x => x.Evento).ToList();
        }

        internal static List<Tarefa> Pesquisar(string trecho, string situacao, string prioridade, bool temDataConclusao, DateTime dataConclusao)
        {
            if (temDataConclusao)
                return dataContext.TBTarefa.Include(x => x.Evento).Where(x => (x.Titulo.Contains(trecho) || x.Descricao.Contains(trecho)) && ((char)x.Situacao).ToString().Contains(situacao) && ((char)x.Prioridade).ToString().Contains(prioridade) && x.DataMaximaConclusao != null && x.DataMaximaConclusao.Value.Day == dataConclusao.Day && x.DataMaximaConclusao.Value.Month == dataConclusao.Month && x.DataMaximaConclusao.Value.Year == dataConclusao.Year).ToList();
            else
                return dataContext.TBTarefa.Include(x => x.Evento).Where(x => (x.Titulo.Contains(trecho) || x.Descricao.Contains(trecho)) && ((char)x.Situacao).ToString().Contains(situacao) && ((char)x.Prioridade).ToString().Contains(prioridade)).ToList();
        }
    }
}
