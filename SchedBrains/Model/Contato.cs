using Microsoft.EntityFrameworkCore;
using SchedBrains.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SchedBrains.Model
{
    [Index(nameof(Nome), IsUnique = true)]
    public class Contato
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(50)]
        public string Sobrenome { get; set; }

        [MaxLength(10)]
        public string? Apelido { get; set; }

        [MaxLength(50)]
        public string? Email { get; set; }

        //[MaxLength(50)]
        public string? Imagem { get; set; }

        [MaxLength(15)]
        public string? Telefone { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DataNascimento { get; set; }

        [Required]
        public bool Favorito { get; set; } = false;

        [Required]
        public TipoContato Tipo { get; set; }

        public Contato(string nome, string sobrenome, string? apelido, string? email, DateTime? nascimento, TipoContato tipo, string telefone, string? imagem)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Apelido = apelido;
            Email = email;
            DataNascimento = nascimento;
            Tipo = tipo;
            Telefone = telefone;
            Imagem = imagem;
        }

        public Contato() { }

        public bool AlterarFavorito()
        {
            this.Favorito = !this.Favorito;
            return this.Favorito;
        }

        public bool EmailValido(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                          RegexOptions.None, TimeSpan.FromMilliseconds(200));

                string DomainMapper(Match match)
                {
                    var idn = new IdnMapping();

                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
    }
}
