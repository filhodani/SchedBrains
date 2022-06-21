using SchedBrains.Helpers;
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
            if (contato.Nome.Trim() == "")
                throw new Exception("É necessário informar o nome do contato!");

            if (contato.Nome.Length > 50)
                throw new Exception("Nome muito grande!");

            if (contato.Sobrenome.Trim() == "")
                throw new Exception("É necessário informar o sobrenome do contato!");

            if (contato.Sobrenome.Length > 50)
                throw new Exception("Sobrenome muito grande!");

            if (contato.Apelido.Length > 10)
                throw new Exception("Apelido muito grande!");

            if (contato.Telefone.Length > 15)
                throw new Exception("Telefone muito grande!");

            if (contato.Email != null && contato.Email != "" && !(new Contato().EmailValido(contato.Email)))
                throw new Exception("Email inválido!");

            if (contato.Email.Length > 50)
                throw new Exception("Email muito grande!");

            if (contato.DataNascimento != null && contato.DataNascimento > DateTime.Today)
                throw new Exception("Data de nascimento inválida!");

            bool invalido = true;
            foreach (TipoContato y in Enum.GetValues(typeof(TipoContato)))
            {
                if (y == contato.Tipo)
                {
                    invalido = false;
                    break;
                }
            }
            if (invalido)
                throw new Exception("Tipo inválido!");
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

        internal static List<Contato> Pesquisar(string busca, string tipo, bool favoritos)
        {
            if (favoritos)
                return dataContext.TBContato.Where(x => (x.Nome.Contains(busca) || x.Sobrenome.Contains(busca) || x.Apelido.Contains(busca) || x.Telefone.Contains(busca) || x.Email.Contains(busca)) && ((char)x.Tipo).ToString().Contains(tipo) && x.Favorito == favoritos).ToList();
            else
                return dataContext.TBContato.Where(x => (x.Nome.Contains(busca) || x.Sobrenome.Contains(busca) || x.Apelido.Contains(busca) || x.Telefone.Contains(busca) || x.Email.Contains(busca)) && ((char)x.Tipo).ToString().Contains(tipo)).ToList();
        }
    }
}
