using SchedBrains.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedBrains.Controller
{
    internal class ContatoController : DefaultController
    {
        private static void Validar(Contato contato)
        {

        }

        internal static void Adicionar(Contato contato)
        {
            if (contato != null)
            {
                Validar(contato);

                dataContext.Add(contato);
                dataContext.SaveChanges();
            }
        }

        internal static void Atualizar(Contato contato)
        {
            if (contato != null)
            {
                Validar(contato);

                dataContext.TBContato.Update(contato);
                dataContext.SaveChanges();
            }
        }

        internal static void Excluir(Contato contato)
        {
            if (contato != null)
            {
                dataContext.TBContato.Remove(contato);
                dataContext.SaveChanges();
            }
            else
                throw new Exception();
        }

        internal static List<Contato> Listar()
        {
            return dataContext.TBContato.ToList();
        }
    }
}
