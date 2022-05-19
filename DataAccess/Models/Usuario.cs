using DataAccess.Infraestructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Usuario : EntityBase
    {
        [Required]
        [Column(TypeName = "VARCHAR(50)")]
        public string UserName { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(50)")]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(50)")]
        public string Mail { get; set; }

        [Column(TypeName = "VARCHAR(30)")]
        public string Telefono { get; set; }

    }
}
