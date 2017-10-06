using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Memesis.Models.Negocios
{
    public class PerfilModel
    {
        [Key]
        public int Id { get; set; }

        [Required(
            ErrorMessage = "* Obrigatório")]
        [Display(Name = "Data Nascimento")]

        public DateTime DataNasc { get; set; }

        public int UsuarioModelId { get; set; }

        public UsuarioModel Usuario { get; set; }

        public string Briografia { get; set; }
        public string Avatar { get; set; }
    }
}