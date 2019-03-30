using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppHHelpers.Models
{
    public class Validation
    {

        public int Id { get; set; }

        [Required]
        public string Cedula { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }

        [Range(15,100)]
        public int Edad { get; set; }
        public string Telefono { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public Nullable<int> GeneroId { get; set; }
        public string EstadoCivil { get; set; }
        public string Hobbies { get; set; }

        public virtual Genero Genero { get; set; }



    }

    [MetadataType(typeof(Validation))]
    public partial class Persona
    {

    }
    
    
}