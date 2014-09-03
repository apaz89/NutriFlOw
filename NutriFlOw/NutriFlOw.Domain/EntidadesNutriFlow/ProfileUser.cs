using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NutriFlOw.Domain.EntidadesNutriFlow
{
    public class ProfileUser
    {

        
        public DateTime Fecha { get; set; }
        
        [Required(ErrorMessage="Debe ingresar su genero",AllowEmptyStrings=false)]
        public char Genero { get; set; }

        [Required(ErrorMessage = "Debe ingresar su peso actual", AllowEmptyStrings = false)]
        public double Peso { get; set; }

        [Required(ErrorMessage = "Debe su meta de perdida de peso", AllowEmptyStrings = false)]
        public double PesoMeta { get; set; }

        [Required(ErrorMessage = "Debe ingresar su altura", AllowEmptyStrings = false)]
        public double Altura { get; set; }

        [Required(ErrorMessage = "Debe ingresar su fecha de nacimiento", AllowEmptyStrings = false)]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "Debe ingresar su nivel de actividad fisica", AllowEmptyStrings = false)]
        public char QueTanActivo { get; set; } //V:very active - C:coach of potate - L:lightly active

        
        public double MasaCorporal { get; set; }

        //[ForeignKey("UsuarioId")]
        public int UsuarioId { get; set; }


    }
}
