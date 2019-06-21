﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre debe tener de 3 a 50 caracteres")]
        public string Nombre { get; set; }
        [StringLength(256)]
        public string Descripcion { get; set; }
        public Boolean Estado { get; set; } = true;
    }
}
