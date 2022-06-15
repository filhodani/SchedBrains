using SchedBrains.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedBrains.Controller
{
    internal class EventoController : DefaultController
    {
        private static void Validar(Evento evento)
        {
            
        }

        internal static void Adicionar(Evento evento)
        {
            if (evento != null)
            {
                Validar(evento);

                dataContext.Add(evento);
                dataContext.SaveChanges();
            }
        }

        internal static void Atualizar(Evento evento)
        {
            if (evento != null)
            {
                Validar(evento);

                dataContext.TBEvento.Update(evento);
                dataContext.SaveChanges();
            }
        }

        internal static void Excluir(Evento evento)
        {
            if (evento != null)
            {
                dataContext.TBEvento.Remove(evento);
                dataContext.SaveChanges();
            }
            else
                throw new Exception();
        }

        internal static List<Evento> Listar()
        {
            return dataContext.TBEvento.ToList();
        }

        /*internal static List<Evento> Pesquisar(string trecho, string situacao, string prioridade, bool temDataConclusao, DateTime dataConclusao)
        {
            if (temDataConclusao)
                return dataContext.TBEvento.Where(x => (x.Titulo.Contains(trecho) || x.Descricao.Contains(trecho)) && ((char)x.Situacao).ToString().Contains(situacao) && ((char)x.Prioridade).ToString().Contains(prioridade) && x.DataMaximaConclusao != null && x.DataMaximaConclusao.Value.Day == dataConclusao.Day && x.DataMaximaConclusao.Value.Month == dataConclusao.Month && x.DataMaximaConclusao.Value.Year == dataConclusao.Year).ToList();
            else
                return dataContext.TBEvento.Where(x => (x.Titulo.Contains(trecho) || x.Descricao.Contains(trecho)) && ((char)x.Situacao).ToString().Contains(situacao) && ((char)x.Prioridade).ToString().Contains(prioridade)).ToList();
        }*/
    }
}
