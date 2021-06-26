﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CursoMVC.Models.ViewModels
{
    public class UserViewModel
    {
        [Required]
        [EmailAddress]
        [StringLength(100, ErrorMessage ="El {0} debe tener al menos {1} caracteres", MinimumLength =-1)]
        [Display(Name ="Correo Electronico")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)] // Contraseña Encriptada
        [Display(Name ="Contraseña")]
        public string Password { get; set; }

        [Display(Name = "Confirma Contraseña")]
        [Compare("Password", ErrorMessage ="Las contraseñas no son iguales")] //Compara con el campo password si es lo mismo
        public string ConfirmPassword { get; set; }

        [Required]
        public int Edad { get; set; }
    }

    public class EditUserViewModel
    {

        public int Id { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100, ErrorMessage = "El {0} debe tener al menos {1} caracteres", MinimumLength = -1)]
        [Display(Name = "Correo Electronico")]
        public string Email { get; set; }

        
        [DataType(DataType.Password)] // Contraseña Encriptada
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [Display(Name = "Confirma Contraseña")]
        [Compare("Password", ErrorMessage = "Las contraseñas no son iguales")] //Compara con el campo password si es lo mismo
        public string ConfirmPassword { get; set; }

        [Required]
        public int Edad { get; set; }
    }
}