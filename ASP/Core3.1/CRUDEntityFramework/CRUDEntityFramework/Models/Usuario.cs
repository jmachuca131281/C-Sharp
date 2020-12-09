﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDEntityFramework.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage ="El telefóno es requerido")]
        [Display(Name = "Telefóno")]
        public string Telefono { get; set; }

        [Required(ErrorMessage ="El celular es obligatorio")]
        public string Celular { get; set; }

        [Required(ErrorMessage ="El email es obligatorio")]
        public string Email { get; set; }
    }
}
