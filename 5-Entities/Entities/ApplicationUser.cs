using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.Entities.Enums;
using Microsoft.AspNetCore.Identity;

namespace Entities.Entities
{
    public class ApplicationUser : IdentityUser<string>
    {
        [Column("USR_CPF")]
        [MaxLength(50)]
        [Display(Name = "CPF")]
        public string CPF { get; set; }

        [Column("USR_IDADE")]
        [Display(Name = "Idade")]
        public int Idade { get; set; }

        [Column("USR_Nome")]
        [MaxLength(255)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("USR_CEP")]
        [MaxLength(15)]
        [Display(Name = "Cep")]
        public string Cep { get; set; }

        [Column("USR_ENDERECO")]
        [MaxLength(255)]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [Column("USR_COMPLEMENTO_ENDERECO")]
        [MaxLength(450)]
        [Display(Name = "Complemento de Endereço")]
        public string ComplementoEndereco { get; set; }

        [Column("USR_CELULAR")]
        [MaxLength(20)]
        [Display(Name = "Celular")]
        public string Celular { get; set; }

        [Column("USR_TELEFONE")]
        [MaxLength(20)]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        [Column("USR_ESTADO")]
        [Display(Name = "ESTADO")]
        public bool Estado { get; set; }

        [Column("USR_TIPO")]
        [Display(Name = "Tipo")]
        public UserType? Tipo { get; set; }
    }
}