using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NutriFlOw.Domain.EntidadesNutriFlow   
{
    public class Usuario
    {
            
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Ingrese un nombre Valido", AllowEmptyStrings = false)]        
        public string Nombre   { get; set; }

        [Required(ErrorMessage = "Ingrese un nombre Valido", AllowEmptyStrings = false)]        
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Ingrese un nombre Valido", AllowEmptyStrings = false)]        
        public string NickName{ get; set; }

        [Required(ErrorMessage = "Por favor ingrese una password", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "El Password debe contener al menos 8 caracteres")]
        public string Password { get; set; }

        [RegularExpression(@"^([0-9a-zA-Z]([\+\-_\.][0-9a-zA-Z]+)*)+@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,17})$",
            ErrorMessage = "Por favor ingrese una direcccion de correo valida")]
        public string Email { get; set; }


        public bool EsValido { get; set; }
        public DateTime FechaRegistro { get; set; }

        public virtual List<ProfileUser> Perfil { get; set; }
             
    }
}
