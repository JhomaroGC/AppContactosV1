using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AppContactosV1.Models
{
    public class Contactos
    {
    //Atributos
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio")]
    public string Nombre { get; set; }

    [Required(ErrorMessage = "El telefono es obligatorio")]
    public string Telefono { get; set; }

    [Required(ErrorMessage = "La direccion es obligatoria")]
    public string Celular { get; set; }

    [Required(ErrorMessage = "El correo es  obligatorio")]
    public string Email { get; set; }

    }
}