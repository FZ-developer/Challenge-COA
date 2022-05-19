using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTO
{
    public class UsuarioDTO
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Mail { get; set; }

        public string Telefono { get; set; }
    }
}
