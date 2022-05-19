﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Infraestructure
{
    public abstract class EntityBase
    {
        [Key]
        public int IdUsuario { get; set; }

        [Column(TypeName = "BIT")]
        public bool Activo { get; set; }
    }
}
