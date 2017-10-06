using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Memesis.Models.Negocios
{
    public class UsuarioModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "* Obrigatório")]
        public string Email { get; set; }

    }
}